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
    public partial class CreateUser : MetroFramework.Forms.MetroForm
    {
        private LoginCommon user;
        private bool isNew = true;
        public CreateUser()
        {
            InitializeComponent();
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {
            ClearControls();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    if (isNew == true)
                    {
                        this.txtuserid.Text = Convert.ToString(0);
                    }
                    LoginCommon u = new LoginCommon(Convert.ToInt32(this.txtuserid.Text), this.txtusername.Text, this.txtpassword.Text, this.chkisadmin.Checked);
                  
                    txtusername.Focus();
                   
                    if (new LoginCommonControllor().SaveUser(u))
                    {
                        MessageBox.Show("User is saved successfully.", "Saved...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "tsbtnSave_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            try
            {
                this.txtusername.Clear();
                this.txtpassword.Clear();


                this.chkisadmin.Checked = true;


                this.btndelete.Enabled = false;

                this.txtuserid.Text = new LoginCommonControllor().GetMaximumID().ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool ValidateControls()
        {
            try
            {
                if (this.txtusername.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please Enter User Name.", "Enter User Name...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtusername.Focus();
                    return false;
                }
                else if (this.txtusername.Text.Trim().Contains("'"))
                {
                    MessageBox.Show("Please enter a valid user name.", "Enter Valid User Name...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtusername.Focus();
                    return false;
                }
                else if (this.txtpassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please enter user password.", "Enter Password...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtpassword.Focus();
                    return false;
                }
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmUsers ValidateControls", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SchForms.SchUsers frm = new SchForms.SchUsers();
                frm.ShowDialog();

                if (frm.item != null)
                {
                    ClearControls();
                    this.user = frm.item;

                    this.txtuserid.Text = frm.item.UserID.ToString();
                    this.txtusername.Text = frm.item.UserName;
                    this.txtpassword.Text = frm.item.Password;

                    this.chkisadmin.Checked = frm.item.IsAdmin;





                    // this.btndelete.Enabled = true;
                    this.isNew = false;



                    if (frm.item.UserID > 0)
                    {
                        btndelete.Enabled = true;

                        chkisadmin.Visible = true;
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "tsbtnEdit_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete this user ?", "Confirm Suppression...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (new LoginCommonControllor().DeleteUser(user))
                    {
                        MessageBox.Show("User has been deleted successfully.", "Suppression Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "tsbtnDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
