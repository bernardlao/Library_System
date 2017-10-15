using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyClassCollection;

namespace Logs
{
    class ActivityLog
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        public ActivityLog()
        { }
        public void Login(string userID)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            if (userID.Equals("Admin"))
            {
                logDescription = "Admin has logged in";
            }
            else if (userID.Equals("Guest"))
            {
                logDescription = "Guest has logged in";
            }
            else
            {
                DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1");
                DataRow r = dt.Rows[0];
                logDescription = "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " that has " + r["librarianID"].ToString() +
                    " librarian ID has logged in";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + ((userID.Equals("Admin")||userID.Equals("Guest"))?"0":userID) +
                ",'User Log','Login','" + logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void Logout(string userID)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            if (userID.Equals("Admin"))
            {
                logDescription = "Admin has logged out";
            }
            else
            {
                DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1");
                DataRow r = dt.Rows[0];
                logDescription = "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " that has " + r["librarianID"].ToString() +
                    " librarian ID has logged out";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + ((userID.Equals("Admin") || userID.Equals("Guest")) ? "0" : userID) +
                ",'User Log','Logout','" + logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void AddAccount(string librarianID, string fname, string mname, string lname, string username)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "The admin created an account with the username " + username + " and Librarian ID of " + librarianID +
                " for " + GenerateFullname(fname, mname, lname);
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(0," + "'User','Register User','" + 
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdateAccount(List<string> ids)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "The admin update some account(s) with the Librarian ID as follows : ";
            foreach (string s in ids)
            {
                logDescription += s + "; ";
            }
            logDescription = logDescription.Remove(logDescription.Length - 1);
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(0," + "'User','Update User','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void ResetPassword(List<string> ids)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "The admin reset the password of some account(s) with the Librarian ID as follows : ";
            foreach (string s in ids)
            {
                logDescription += s + "; ";
            }
            logDescription = logDescription.Remove(logDescription.Length - 1);
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(0," + "'User','Reset Password','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void ApproveBorrowerRegistration(string userID, List<string> cons)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            if (userID.Equals("Admin"))
            {
                logDescription += "The admin approved the following borrower registration : ";
            }
            else
            {
                DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
                DataRow r = dt.Rows[0];
                logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                    " Librarian ID approved the following borrower registration : ";
            }
            foreach (string s in cons)
            {
                string[] arr = s.Split(',');
                logDescription += arr[0] + "-" + GenerateFullname(arr[1], arr[2], arr[3]) + "; ";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES("+ (userID.Equals("Admin")?"0":userID)+"," + "'Borrower','Approve Borrower','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void RegisterBorrower(string borrowerID, string fname, string mname, string lname)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "A guest user Register a borrower account namely " + GenerateFullname(fname, mname, lname) + " with " + borrowerID + " ID.";
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(-1," + "'Borrower','Register Borrower','" +
                           logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdateBorrower(string borrowerID, string fname, string mname, string lname)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "The admin updated the account of " + GenerateFullname(fname, mname, lname) + " with " + borrowerID + " ID";
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(0," + "'Borrower','Update Borrower','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void AddBook(string userID, string title, string quantity, string volume, List<string> authors)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString()+
                " added a book with" + Environment.NewLine + "Title:" + title + ";" + (volume.Equals("") ? "Volume" : volume + ";") + " and Quantity:" + quantity + ";The book has the following author(s): " + Environment.NewLine;
            foreach (string s in authors)
            {
                DataTable d = db.SelectTable("SELECT * FROM tblauthor WHERE authorID=" + s);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in d.Rows)
                        {
                            if (row["fname"].ToString().Equals(""))
                                logDescription += row["corporation"].ToString() + "; ";
                            else
                                logDescription += GenerateFullname(row["fname"].ToString(), row["mname"].ToString(), row["lname"].ToString()) + ";";
                        }
                    }
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES("+userID +"," + "'Book','Add Book','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdateBook(string userID, string oTitle, string oQuantity, string oVolume, List<string> oAuthors, string title, string quantity, string volume, List<string> authors)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
               " updated a book with" + Environment.NewLine + "Title:" + oTitle + ";" + (oVolume.Equals("") ? "" : "Volume:" + oVolume + ";") + " and Quantity:" + oQuantity + ";That has the following author(s): " + Environment.NewLine;
            foreach (string s in oAuthors)
            {
                DataTable d = db.SelectTable("SELECT * FROM tblauthor WHERE authorID=" + s);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in d.Rows)
                        {
                            logDescription += GenerateFullname(row["fname"].ToString(), row["mname"].ToString(), row["lname"].ToString()) + ";";
                        }
                    }
                }
            }
            logDescription += " TO " + Environment.NewLine +"Title:" + title + ";" + (volume.Equals("") ? "" : "Volume:" + volume + ";") + " and Quantity:" + quantity + ";That has the following author(s): " + Environment.NewLine;
            foreach (string s in authors)
            {
                DataTable d = db.SelectTable("SELECT * FROM tblauthor WHERE authorID=" + s);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in d.Rows)
                        {
                            logDescription += (row["fname"].ToString().Equals("") ? row["corporation"].ToString() :
                                GenerateFullname(row["fname"].ToString(), row["mname"].ToString(), row["lname"].ToString())) + ";";
                        }
                    }
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Book','Update Book','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void DeleteBook(string userID, List<string> bookIDs)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " deleted some book(s) as follows : ";
            string ids = "";
            foreach (string s in bookIDs) 
                ids += s + ",";
            ids = ids.Remove(ids.Length - 1);
            DataTable books = db.SelectTable("SELECT * FROM tblbook WHERE bookID IN(" + ids + ");");
            if (books != null)
            {
                if (books.Rows.Count > 0)
                {
                    foreach (DataRow row in books.Rows)
                    {
                        logDescription +="Call Number:" + row["callNumber"].ToString() + ";Title:" + row["title"].ToString() + ";Quantity" + row["quantity"].ToString() +
                            (row["volume"].ToString().Equals("") ? "" : ";Volume:" + row["volume"].ToString()) + "; ";
                    }
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Book','Delete Book','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdateSubject(string userID, List<DataRow> dr, DataTable orig)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " updated some subject(s) as follows : " + Environment.NewLine;
            foreach (DataRow row in dr)
            {
                DataRow original = orig.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(row["subjectID"].ToString())).SingleOrDefault();
                if (original != null)
                {
                    logDescription += original["subjectName"].ToString() + " to " + row["subjectName"].ToString() + "; ";
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Subject','Update Subject','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void DeleteSubject(string userID, List<DataRow> dr)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " deleted some subject(s) as follows : " + Environment.NewLine;
            foreach (DataRow row in dr)
            {
                logDescription += row["subjectName"].ToString() + "; ";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Subject','Delete Subject','" +
                logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdatePublisbher(string userID, List<DataRow> dr, DataTable orig)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " updated some publisher(s) as follows : " + Environment.NewLine;
            foreach (DataRow row in dr)
            {
                DataRow original = orig.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(row["publisherID"].ToString())).SingleOrDefault();
                if (original != null)
                {
                    logDescription += "Publisher Name:" + original["publisherName"].ToString() + " to " + row["publisherName"].ToString() + ";Address:" +
                        original["address"].ToString() + " to " + row["address"].ToString() + ";"; 
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Publisher','Update Publisher','" +
               logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void DeletePublisher(string userID, List<DataRow> dr)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " deleted some publisher(s) as follows : " + Environment.NewLine;
            foreach (DataRow row in dr)
            {
                logDescription += "Publisher Name:" + row["publisherName"].ToString() + ";Address:" + row["address"].ToString() + ";";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Publisher','Delete Publisher','" +
               logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void UpdateAuthor(string userID, List<DataRow> dr, DataTable orig)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " updated some author(s) as follows : ";
            foreach (DataRow row in dr)
            {
                DataRow o = orig.AsEnumerable().Where(s => s["authorID"].ToString().Equals(row["authorID"].ToString())).SingleOrDefault();
                if (o != null)
                {
                    if (o["fname"].ToString().Equals(""))
                    {
                        logDescription += o["corporation"].ToString() + " to " + row["corporation"].ToString() + "; ";
                    }
                    else
                    {
                        logDescription += GenerateFullname(o["fname"].ToString(), o["mname"].ToString(), o["lname"].ToString()) + " to " +
                            GenerateFullname(row["fname"].ToString(), row["mname"].ToString(), row["lname"].ToString()) + "; ";
                    }
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Author','Update Author','" +
               logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void DeleteAuthor(string userID, List<DataRow> dr)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " deleted some author(s) as follows : ";
            foreach (DataRow row in dr)
            {
                if (row["fname"].ToString().Equals(""))
                {
                    logDescription += row["corporation"].ToString() + "; ";
                }
                else
                {
                    logDescription += GenerateFullname(row["fname"].ToString(), row["mname"].ToString(), row["lname"].ToString()) + "; ";
                }
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Author','Delete Author','" +
               logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        public void ApplySantion(string userID, List<DataRow> dr)
        {
            DateTime now = db.GetServerDateTime();
            string logDescription = "";
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID=" + userID + " LIMIT 1;");
            DataRow r = dt.Rows[0];
            logDescription += "Librarian " + GenerateFullname(r["fname"].ToString(), r["mname"].ToString(), r["lname"].ToString()) + " with " + r["librarianID"].ToString() +
                " apply sanction to some penalty as follows : ";
            foreach (DataRow row in dr)
            {
                logDescription += "Borrower:" + row["bfullname"].ToString() + "; Received By:" + row["rfullname"].ToString() + "; Book Title:" + row["title"].ToString() +
                    "; Quantity:" + row["quantity"].ToString() + "; Date Returned:" + row["dateReturned"].ToString() + "; Days Exceeded:" + row["daysExceed"].ToString() + ";";
            }
            db.InsertQuery("INSERT INTO tbllogs (userID, logTable, logType, logDescription,logDate) VALUES(" + userID + "," + "'Penalty','Apply Sanction','" +
               logDescription + "','" + now.ToString("yyyy-MM-dd hh:mm:ss") + "');");
        }
        private string GenerateFullname(string fname, string mname, string lname)
        {
            string fullname = fname + (mname.Equals("") ? "" : " " + mname + " ") + lname;
            return fullname;
        }
    }
}
