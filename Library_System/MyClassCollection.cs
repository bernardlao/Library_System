using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace MyClassCollection
{
    class MySQLDBUtilities
    {
        MySqlConnection conn;
        MySqlCommand com;
        MySqlDataAdapter myAdapter;
        ConnectionStringSolution css = new ConnectionStringSolution();

        public MySQLDBUtilities()
        {
            com = new MySqlCommand();
        }
        public MySqlConnection OpenConnection()
        {
            conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = GetSettings();
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public MySqlConnection OpenConnection(string settings)
        {
            conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = settings;
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public string GetSettings()
        {
            /*string temp = string.Empty;
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Documents\\Grading System\\settings.ini"))
            {
                string[] setting = File.ReadAllLines("C:\\Users\\" + Environment.UserName + "\\Documents\\Grading System\\settings.ini");
                foreach (string s in setting)
                    temp += s;
            }
            return temp;*/
            string temp = "";
            try
            {
                temp = css.ReadRegistryKey("ConnectionString", "mysqllao");
            }
            catch (Exception e)
            {

            }
            return temp;
        }
        public DataTable SelectTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                myAdapter = new MySqlDataAdapter(query, OpenConnection());
                myAdapter.Fill(dt);
                myAdapter.Dispose();
                CloseConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        
        public void InsertQuery(string query)
        {
            com.CommandText = query;
            try
            {
                com.Connection = OpenConnection();
                int res = com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public string[] GetColumnDatas(string query, string colname)
        {
            List<string> temp = new List<string>();
            DataTable dt = SelectTable(query);
            foreach (DataRow r in dt.Rows)
                temp.Add(r[colname].ToString());
            if (temp.Count == 0)
                temp.Add("");
            return temp.ToArray();
        }

        public long GetID(string query, string colname)
        {
            DataTable dt = SelectTable(query);
            if (dt.Rows.Count != 0)
            {
                DataRow r = dt.Rows[0];
                long i = Convert.ToInt64(r[colname].ToString());
                return i;
            }
            else
                return 0;
        }
        public string DataLookUp(string columnName, string table, string defaultValue, string criteria)
        {
            string query = "SELECT " + columnName + " FROM " + table + " " +
                (criteria.Trim().Length > 0 ? "WHERE " + criteria + " " : "");
            DataTable dt = SelectTable(query);
            if (dt.Rows.Count == 0)
                return defaultValue;
            else
            {
                DataRow r = dt.Rows[0];
                return r[columnName].ToString();
            }
        }
        public void BindComboboxItems(string query, ComboBox cmb, string columnKey, string columnValue)
        {
            DataTable dt = SelectTable(query);
            Dictionary<string, string> d = new Dictionary<string, string>();
            foreach (DataRow r in dt.Rows)
            {
                d.Add(r[columnKey].ToString(), r[columnValue].ToString());
            }
            if (dt.Rows.Count > 0)
            {
                cmb.DataSource = new BindingSource(d, null);
                cmb.ValueMember = "key";
                cmb.DisplayMember = "value";
            }
        }

        public void InsertMultiple(List<string> queries)
        {
            OpenConnection();
            MySqlCommand command = conn.CreateCommand();
            MySqlTransaction trans = conn.BeginTransaction();

            command.Connection = conn;
            command.Transaction = trans;
            try
            {
                for (int i = 0; i < queries.Count; i++)
                {
                    command.CommandText = queries[i].ToString();
                    command.ExecuteNonQuery();
                }
                trans.Commit();
                MessageBox.Show("Committed successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                try
                {
                    trans.Rollback();
                }
                catch (MySqlException ex)
                {
                    if (trans.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                                          " was encountered while attempting to roll back the transaction.");
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
        }
        public DataRow GetLastInsertItem(string query)
        {
            DataTable dt = SelectTable(query);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    return r;
                }
            }
            return null;
        }
    }
    class ConnectionStringSolution
    {
        public string AES_Encrypt(string clearText, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string encryptedString = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(clearText);
                encryptedString = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception e)
            {
                return "";
            }
            return encryptedString;
        }
        public string AES_Decrypt(string encryptedText, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string decryptedString = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESDecrypter = AES.CreateDecryptor();
                byte[] buffer = Convert.FromBase64String(encryptedText);
                decryptedString = ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception e)
            {
                return "";
            }
            return decryptedString;
        }
        public void CreateRegistryKey(string key, string value)
        {
            value = AES_Encrypt(value, "mysqllao");
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
                regKey.CreateSubKey("Library_System");
                regKey = regKey.OpenSubKey("Library_System", true);
                regKey.SetValue(key, value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string ReadRegistryKey(string key, string passkey)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
            regKey.CreateSubKey("Library_System");
            regKey = regKey.OpenSubKey("Library_System", true);
            return AES_Decrypt(regKey.GetValue(key).ToString(), passkey);

        }
    }
    class HelperMethods
    {
        public string CorrectCasing(string source)
        {
            string retval = "";
            if (!source.Equals(""))
            {
                if (source.Contains(' '))
                {
                    string[] temp = source.Split(' ');
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i].Length > 1)
                            retval += temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1).ToLower() + " ";
                        else
                            retval += temp[i].ToUpper();
                    }
                }
                else
                    retval += source.Substring(0, 1).ToUpper() + source.Substring(1).ToLower() + " ";
            }
            retval = retval.Trim();
            return retval;
        }
        public Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        public void TextHandle(ref object sender, ref KeyPressEventArgs e, bool IsDigit)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && IsDigit)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !IsDigit)
                e.Handled = true;
        }
        public void FullnameHandle(ref object sender, ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !e.KeyChar.Equals(',') && !e.KeyChar.Equals('.'))
                e.Handled = true;
        }
        public void AlphaNumericOnly(ref object sender, ref KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public void DecimalHandle(ref object sender, ref KeyPressEventArgs e)
        {
            //TextBox txt = (TextBox)sender;
            DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)sender;
            if (txt.Text.Contains(".") && e.KeyChar == '.')
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        public void LimitTo(ref object sender, ref KeyPressEventArgs e, double count)
        {
            TextBox t = (TextBox)sender;
            if (!t.Text.Equals("") && !t.Text.Equals(".") && !char.IsControl(e.KeyChar))
            {
                try
                {
                    double temp = Convert.ToDouble(t.Text + e.KeyChar);
                    if (temp > count)
                        e.Handled = true;
                }
                catch
                {
                    e.Handled = true;
                }
            }
        }
        public void HypenatedNumberHandle(ref object sender, ref KeyPressEventArgs e)
        {
            DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)sender;
            if (txt.Text.Length > 0)
            {
                if (txt.Text[txt.Text.Length - 1].Equals('-') && e.KeyChar == '-')
                    e.Handled = true;
            }
            if (txt.Text.Length == 0 && e.KeyChar == '-')
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }
        public string GenerateSalt(int len)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder res = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (len-- > 0)
                {

                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);


                }
            }
            return res.ToString();

        }
        public string GenerateSHA256(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            SHA256Managed hashedString = new SHA256Managed();
            byte[] hash = hashedString.ComputeHash(bytes);
            string hashedStrings = String.Empty;

            foreach (byte b in hash)
                hashedStrings += String.Format("{0:X2}", b);
            return hashedStrings;
        }
        public void ClearTextEdit(DevExpress.XtraEditors.XtraUserControl form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is DevExpress.XtraEditors.TextEdit)
                {
                    (c as DevExpress.XtraEditors.TextEdit).Text = "";
                }
                if (c is DevExpress.XtraEditors.MemoEdit)
                {
                    (c as DevExpress.XtraEditors.MemoEdit).Text = "";
                }
            }
        }
        /*public DataTable ConvertToDataTable<T>(List<T> data)
        {
            DataTable table = new DataTable();
            FieldInfo[] fields = typeof(T).GetField();
            foreach (FieldInfo field in fields)
            {
                table.Columns.Add(field.Name, field.FieldType);
            }
            foreach (T item in data)
            {
                DataRow row = new DataRow();
                foreach (FieldInfo field in fields)
                {
                    row[field.Name] = field.GetValue(item);
                }
                table.Rows.Add(row);
            }
            return table;
        }*/
    }
    
}
