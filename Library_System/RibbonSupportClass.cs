using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MyClassCollection;
using Library_System;
using Library_System.Manage_Users;
using Library_System.Manage_Books;

namespace RibbonSupport
{
    class RibbonSupportClass
    {
        frmMain mf;
        private MySQLDBUtilities db = new MySQLDBUtilities();
        public RibbonSupportClass(RibbonForm rf)
        {
            mf = (frmMain)rf;
        }

        public void SaveNow(SaveSender ss)
        {
            switch (ss)
            {
                case SaveSender.AddBook: SaveBook(); break;
                case SaveSender.AddUser: SaveUser(); break;
                case SaveSender.UpdateUser: UpdateUser(); break;
                case SaveSender.ResetPassword: ResetPassword(); break;
                case SaveSender.EditSubject: UpdateSubject(); break;
                case SaveSender.DeleteSubject: DeleteSubject(); break;
                case SaveSender.EditPublisher: UpdatePublisher(); break;
                case SaveSender.DeletePublisher: DeletePublisher(); break;
                case SaveSender.EditAuthor: UpdateAuthor(); break;
                case SaveSender.DeleteAuthor: DeleteAuthor(); break;
            }
        }
        private void SaveBook()
        {
            addBookInfo abi = (addBookInfo)mf.scMain.Panel1.Controls[0];
            abi.SaveDB();
        }
        private void SaveUser()
        {
            addUser au = (addUser)mf.scMain.Panel1.Controls[0];
            au.SaveUser();
        }
        private void UpdateUser()
        {
            viewUsers vu = (viewUsers)mf.scMain.Panel2.Controls[0];
            vu.UpdateNow();
        }
        private void ResetPassword()
        {
            viewUsers vu = (viewUsers)mf.scMain.Panel2.Controls[0];
            vu.ResetPasswordNow();
        }
        private void UpdateSubject()
        {
            subjectManage sm = (subjectManage)mf.scMain.Panel1.Controls[0];
            sm.UpdateNow();
        }
        private void DeleteSubject()
        {
            subjectManage sm = (subjectManage)mf.scMain.Panel1.Controls[0];
            sm.DeleteNow();
        }
        private void UpdatePublisher()
        {
            publisherManage pm = (publisherManage)mf.scMain.Panel1.Controls[0];
            pm.UpdateNow();
        }
        private void DeletePublisher()
        {
            publisherManage pm = (publisherManage)mf.scMain.Panel1.Controls[0];
            pm.DeleteNow();
        }
        private void UpdateAuthor()
        {
            authorManage am = (authorManage)mf.scMain.Panel2.Controls[0];
            am.UpdateNow();
        }
        private void DeleteAuthor()
        {
            authorManage am = (authorManage)mf.scMain.Panel2.Controls[0];
            am.DeleteNow();
        }
    }
    public enum SaveSender
    {
        None,
        AddBook,
        AddUser,
        UpdateUser,
        ResetPassword,
        EditSubject,
        DeleteSubject,
        EditPublisher,
        DeletePublisher,
        EditAuthor,
        DeleteAuthor
    }
}
