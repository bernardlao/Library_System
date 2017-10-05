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
using Library_System.Borrowing_Menu;

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
                case SaveSender.ApproveBorrower: ApproveRegistration(); break;
                case SaveSender.EditBorrower: UpdateBorrower(); break;
                case SaveSender.DeleteBorrower: DeleteBorrower(); break;
                case SaveSender.CheckAndSanctionPenalty: ApplySanction(); break;
            }
        }
        public void BorrowNow(SaveSender ss)
        {
            if (ss == SaveSender.ViewSearch)
                BorrowSelected();
        }
        public void ApproveBorrow(bool isApproved)
        {
            if (isApproved)
                Approve();
            else
                Reject();
        }
        public void ReceiveBookReturns()
        {
            ReceiveReturns();
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
            viewUsers vu = (viewUsers)mf.scMain.Panel2.Controls[0];
            au.SaveUser();
            vu.RefreshUsers();
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
            
        }
        private void ApproveRegistration()
        {
            Borrowers b = (Borrowers)mf.scMain.Panel2.Controls[0];
            b.ApproveRegistration();
        }
        private void UpdateBorrower()
        {
            if (mf.scMain.Panel2.Controls.Count > 0)
            {
                RegisterBorrower rb = (RegisterBorrower)mf.scMain.Panel2.Controls[0];
                rb.UpdateNow();
                Borrowers b = (Borrowers)mf.scMain.Panel1.Controls[0];
                b.LoadList();
            }
        }
        private void DeleteBorrower()
        {
            Borrowers b = (Borrowers)mf.scMain.Panel2.Controls[0];
            b.DeleteBorrower();
        }
        private void Approve()
        {
            BorrowedBooks bb = (BorrowedBooks)mf.scMain.Panel2.Controls[0];
            bb.ApproveBorrowRequest();
        }
        private void Reject()
        {
            BorrowedBooks bb = (BorrowedBooks)mf.scMain.Panel2.Controls[0];
            bb.RejectBorrowRequest();
        }
        private void ReceiveReturns()
        {
            BorrowedBooks bb = (BorrowedBooks)mf.scMain.Panel2.Controls[0];
            bb.ReceiveBookReturns();
        }
        private void ApplySanction() 
        {
            Penalties p = (Penalties)mf.scMain.Panel2.Controls[0];
            p.ApplySanction();
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
        RegisterBorrower,
        ApproveBorrower,
        EditBorrower,
        DeleteBorrower,
        BorrowList,
        ReceiveList,
        CheckTransactionRecord,
        CheckAndSanctionPenalty,
        CheckAllPenalties
    }
}
