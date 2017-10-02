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
using Library_System.Borrowers_Menu;

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
                case SaveSender.EditBook: UpdateBook(); break;
                case SaveSender.DeleteBook: DeleteBook(); break;
                case SaveSender.RegisterBorrower: RegisterBorrowers(); break;
            }
        }
        public void BorrowNow(SaveSender ss)
        {
            if (ss == SaveSender.ViewSearch)
                BorrowSelected();
        }
        private void SaveBook()
        {
            addBookInfo abi = (addBookInfo)mf.scMain.Panel1.Controls[0];
            abi.SaveDB();
        }
        private void UpdateBook()
        {
            addBookInfo abi = (addBookInfo)mf.scMain.Panel1.Controls[0];
            abi.UpdateNow();
        }
        private void DeleteBook()
        {
            Books b = (Books)mf.scMain.Panel1.Controls[0];
            b.DeleteNow();
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
        private void RegisterBorrowers()
        {
            RegisterBorrower rb = (RegisterBorrower)mf.scMain.Panel2.Controls[0];
            rb.SaveNow();
        }
        private void BorrowSelected()
        {
            Books b = (Books)mf.scMain.Panel1.Controls[0];
            b.BorrowSelected();
            frmMain.ss = SaveSender.None;
        }
    }
    public enum SaveSender
    {
        None,
        AddBook,
        EditBook,
        DeleteBook,
        ViewSearch,
        AddUser,
        UpdateUser,
        ResetPassword,
        EditSubject,
        DeleteSubject,
        EditPublisher,
        DeletePublisher,
        EditAuthor,
        DeleteAuthor,
        RegisterBorrower
    }
}
