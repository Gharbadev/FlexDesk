
using Common;
using CommonController;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProject.Forms
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            
            // cmbusername.Select();
         //  cmbusername.DataSource = new LoginCommonControllor().GetUsers(0);
            //cmbusername.DisplayMember = "UserName";
            //cmbusername.ValueMember = "UserID";
            //cmbusername.SelectedIndex = 0;
            this.txtusername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool validateControls()
        {
            try
            {
                if (this.txtusername.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please Enter User Name.", "Enter User...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtusername.Focus();
                    return false;
                }
                else if (this.txtpassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please Enter Password.", "Enter Password...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtpassword.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmLogIn BtnLogIn_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //FrmMain frm = new FrmMain();
            //frm.Show();

            try
            {
                if (validateControls())
                {
                    LoginCommon u = new LoginCommon(this.txtusername.Text, this.txtpassword.Text);
                    LoginCommon verifiedUser = new LoginCommonControllor().VerifyUser(u);


                    if (verifiedUser != null)
                    {
                        //setCompanyInfo();
                        FrmMain frm = new FrmMain();
                        if (verifiedUser.IsAdmin)
                        {
                            Globals.Isadmin = true;
                        }
                        else
                        {
                            Globals.Userid = verifiedUser.UserID;
                            Globals.Isadmin = false;
                        }
                       
                      //  frm.lblLogin.Text = verifiedUser.UserName;
                     //   frm.txtuseridlogin.Text = verifiedUser.UserID.ToString();
                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name and/or Password.", "Invalid user...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txtpassword.Clear();
                        // this.cmbusername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmLogIn BtnLogIn_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
