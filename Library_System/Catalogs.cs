using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using MyClassCollection;

namespace Library_System
{
    public partial class Catalogs : DevExpress.XtraReports.UI.XtraReport
    {
        List<Catalogs> reports = new List<Catalogs>();
        MySQLDBUtilities db = new MySQLDBUtilities();
        public Catalogs()
        {
            InitializeComponent();
        }
        public void PrepareData(List<DataRow> dr)
        {
            foreach (DataRow r in dr)
            {
                Catalogs c = new Catalogs();
                DataTable dt = db.SelectTable("SELECT * FROM (((tblbookauthor ba INNER JOIN tblauthor a ON ba.authorID=a.authorID)" + 
                    " RIGHT JOIN tblbook b ON ba.bookID=b.bookID) LEFT JOIN tblpublisher p ON p.publisherID=b.publisherID)" + 
                    " LEFT JOIN tblsubject s ON b.subjectID=s.subjectID WHERE b.bookID =" + r["bookID"].ToString() + ";");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ApplyInfo(dt, c);
                        c.CreateDocument();
                        reports.Add(c);
                    }
                }
            }
            Catalogs main = reports[0];
            if (reports.Count > 1)
            {
                for (int i = 1; i < reports.Count; i++)
                {
                    main.Pages.AddRange(reports[i].Pages);
                }
            }
            main.ShowPreviewDialog();
        }
        private void ApplyInfo(DataTable dt, Catalogs c)
        {
            if (dt.Rows.Count > 0)
            {
                DataRow ro = dt.Rows[0];
                c.lblDeweyAuthor.Text = (!ro["deweyDecimal"].ToString().Equals("")?ro["deweyDecimal"].ToString() + Environment.NewLine:"") +
                    (!ro["cattersNo"].ToString().Equals("")?ro["cattersNo"].ToString() + Environment.NewLine :"")+
                    ro["yearOfPublication"].ToString();
                c.lblDeweySubject.Text = (!ro["deweyDecimal"].ToString().Equals("") ? ro["deweyDecimal"].ToString() + Environment.NewLine : "") +
                    (!ro["cattersNo"].ToString().Equals("") ? ro["cattersNo"].ToString() + Environment.NewLine : "") +
                    ro["yearOfPublication"].ToString();
                c.lblDeweyTitle.Text = (!ro["deweyDecimal"].ToString().Equals("") ? ro["deweyDecimal"].ToString() + Environment.NewLine : "") +
                    (!ro["cattersNo"].ToString().Equals("") ? ro["cattersNo"].ToString() + Environment.NewLine : "") +
                    ro["yearOfPublication"].ToString();

                c.lblDetailsAuthor.Text += GetAuthor(dt, lblDetailsAuthor.Text, true) + Environment.NewLine;
                c.lblDetailsAuthor.Text += "     " + ro["title"].ToString()  + GetAuthor(dt, lblDetailsAuthor.Text, false)  + Environment.NewLine;
                c.lblDetailsAuthor.Text += ro["address"].ToString() + " : " + ro["publisherName"].ToString() + ", " + (ro["isCopyright"].ToString().Equals("0") ? "" : "c") + ro["yearOfPublication"].ToString() + "." + Environment.NewLine;
                c.lblDetailsAuthor.Text += "     " + ro["pages"].ToString() + " p. : " + ro["typeOfIllustration"].ToString() + Environment.NewLine;
                c.lblDetailsAuthor.Text += Environment.NewLine + (!ro["noteArea"].ToString().Equals("")?"     " +  ro["noteArea"].ToString() + Environment.NewLine:"");
                c.lblDetailsAuthor.Text += "     " + (!ro["ISBN"].ToString().Equals("") ? "ISBN: " + ro["ISBN"].ToString() + Environment.NewLine : "") + Environment.NewLine;
                c.lblDetailsAuthor.Text += "     " + "1.  " +  ro["subjectName"].ToString();

                c.lblDetailsSubject.Text += "     " + ro["subjectName"].ToString().ToUpper() + Environment.NewLine;
                c.lblDetailsSubject.Text += GetAuthor(dt, lblDetailsSubject.Text, true) + Environment.NewLine;
                c.lblDetailsSubject.Text += "     " + ro["title"].ToString() + GetAuthor(dt, lblDetailsAuthor.Text, false) + Environment.NewLine;
                c.lblDetailsSubject.Text += ro["address"].ToString() + " : " + ro["publisherName"].ToString() + ", " + (ro["isCopyright"].ToString().Equals("0") ? "" : "c") + ro["yearOfPublication"].ToString() + "." + Environment.NewLine;
                c.lblDetailsSubject.Text += "     " + ro["pages"].ToString() + " p. : " + ro["typeOfIllustration"].ToString() + Environment.NewLine;
                c.lblDetailsSubject.Text += Environment.NewLine + (!ro["noteArea"].ToString().Equals("") ? "     " + ro["noteArea"].ToString() + Environment.NewLine : "");
                c.lblDetailsSubject.Text += "     " + (!ro["ISBN"].ToString().Equals("")?"ISBN: " + ro["ISBN"].ToString():"");

                c.lblDetailsTitle.Text += "     " + ro["title"].ToString() + Environment.NewLine;
                c.lblDetailsTitle.Text += GetAuthor(dt, lblDetailsTitle.Text, true) + Environment.NewLine;
                c.lblDetailsTitle.Text += "     " + ro["title"].ToString()  + GetAuthor(dt, lblDetailsAuthor.Text, false) + Environment.NewLine;
                c.lblDetailsTitle.Text += ro["address"].ToString() + " : " + ro["publisherName"].ToString() + ", " + (ro["isCopyright"].ToString().Equals("0") ? "" : "c") + ro["yearOfPublication"].ToString() + "." + Environment.NewLine;
                c.lblDetailsTitle.Text += "     " + ro["pages"].ToString() + " p. : " + ro["typeOfIllustration"].ToString() + Environment.NewLine;
                c.lblDetailsTitle.Text += Environment.NewLine + (!ro["noteArea"].ToString().Equals("") ? "     " + ro["noteArea"].ToString() + Environment.NewLine : "");
                c.lblDetailsTitle.Text += "     " + (!ro["ISBN"].ToString().Equals("") ? "ISBN: " + ro["ISBN"].ToString() : "");

                if (ro["subjectName"].ToString().ToLower().Equals("fiction"))
                    c.pnlSubject.Dispose();
            }
        }
        private string GetAuthor(DataTable dt, string text, bool isFormal)
        {
            int count = 0;
            if (dt.Rows.Count > 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    count++;
                    DataRow r = dt.Rows[i];
                    if (isFormal)
                    {
                        text += r["lname"].ToString() + ", " + r["fname"].ToString() + (!r["mname"].ToString().Equals("") ? " " + r["mname"].ToString()[0] + "." : "") + (i == 0 ? " and " : "");
                    }
                    else
                    {
                        text += r["fname"].ToString() + (!r["mname"].ToString().Equals("") ? " " + r["mname"].ToString() + ". " : " ") + r["lname"].ToString() + (i == 0 ? " and " : "");
                    }
                    if (count == 2)
                        i = dt.Rows.Count;
                }
                if (dt.Rows.Count > 2)
                    text += " et al.";
            }
            else
            {
                DataRow r = dt.Rows[0];
                if (r["fname"].ToString().Equals(""))
                {
                    text += (isFormal?r["corporation"].ToString():" - - ");
                }
                else
                {
                    if (isFormal)
                    {
                        text += r["lname"].ToString() + ", " + r["fname"].ToString() + (!r["mname"].ToString().Equals("") ? " " + r["mname"].ToString()[0] + "." : "");
                    }
                    else
                    {
                        if (!r["subjectName"].ToString().ToLower().Equals("fiction"))
                            text += " / " + r["fname"].ToString() + (!r["mname"].ToString().Equals("") ? " " + r["mname"].ToString() + ". " : " ") + r["lname"].ToString() + ". -";
                        else
                            text += " - - ";
                    }
                }
            }
            return text;
        }
    }
}
