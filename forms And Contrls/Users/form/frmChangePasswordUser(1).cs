using BusinessLayeres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Users.form
{
    public partial class frmChangePasswordUser : Form
    {
        private int _UserID;
        private clsUsers _clsUsers;
        public frmChangePasswordUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }
        private void _RestDefualtVaules()
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPasswerd.Text = "";
        }
        private void _LoadData()
        {
            
            _clsUsers  =clsUsers.FindUserById(_UserID);
            if (_clsUsers == null)
            {
                _RestDefualtVaules(); // نرجع القيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا المستخدم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                return; // نوقف العملية
            }
            ctrlUserCard1.LoadUserInfo(_UserID);



        }
        private void frmChangePasswordUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text.Trim()))
            {

                e.Cancel = true; // نمنع الانتقال
                errorProviderChangePassword.SetError(tbCurrentPassword, " الرجاء قم بادخال  رمز المستخدم "); // نعرض رسالة خطأ
                return;
            }
            else
            {
                errorProviderChangePassword.SetError(tbCurrentPassword, ""); // نعرض رسالة خطأ

            }

            if (tbCurrentPassword.Text.Trim() != _clsUsers.Password)
            {
                e.Cancel = true; // نمنع الانتقال
                errorProviderChangePassword.SetError(tbCurrentPassword, "رمز المستخدم خطاء من فضلك ادخل الرمز الصحيح "); // نعرض رسالة خطأ
            }
            else
            {
                errorProviderChangePassword.SetError(tbCurrentPassword, ""); // نعرض رسالة خطأ

            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text.Trim()))
            {

                e.Cancel = true; // نمنع الانتقال
                errorProviderChangePassword.SetError(tbNewPassword, " الرجاء قم بادخال  رمز المستخدم "); // نعرض رسالة خطأ
                return;
            }
            else
            {
                errorProviderChangePassword.SetError(tbNewPassword, ""); // نعرض رسالة خطأ

            }

      
        }

        private void tbConfirmPasswerd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPasswerd.Text.Trim()))
            {

                e.Cancel = true; // نمنع الانتقال
                errorProviderChangePassword.SetError(tbConfirmPasswerd, " الرجاء قم بادخال  رمز المستخدم "); // نعرض رسالة خطأ
                return;
            }
            else
            {
                errorProviderChangePassword.SetError(tbConfirmPasswerd, ""); // نعرض رسالة خطأ

            }

            if (tbConfirmPasswerd.Text.Trim() != tbNewPassword.Text.Trim())
            {
                e.Cancel = true; // نمنع الانتقال
                errorProviderChangePassword.SetError(tbConfirmPasswerd, "رمز التكرار خطاء من فضلك كرر الرمز بشكل الصحيح "); // نعرض رسالة خطأ
            }
            else
            {
                errorProviderChangePassword.SetError(tbConfirmPasswerd, ""); // نعرض رسالة خطأ

            }
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // التحقق من كل المدخلات
            {
                MessageBox.Show("بعض الحقول غير صحيحة!, ضع الماوس فوق الأيقونة الحمرة لترئ الخطأ", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
  
            if (clsUsers.ChangePassword(_UserID, tbConfirmPasswerd.Text.Trim()))
            {

              
                MessageBox.Show("تم تغيير الرمز بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // اذا فشل
            {
                MessageBox.Show(" فشل في  تغيير الرمز", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
