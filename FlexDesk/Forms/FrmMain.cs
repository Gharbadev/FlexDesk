using Common;
using CommonController;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AccountingProject.Forms
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        bool isnew = true; Reserve r = new Reserve();

        List<SeatCommon> order = new List<SeatCommon>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
          

            //if (this.lblLogin.Text == "Admin" && this.txtuseridlogin.Text == "1")
            //{
            //    //userTransactionToolStripMenuItem.Visible = true;
            //}

            if (!Globals.Isadmin)
            {
                // tabControl1.TabPages.Remove(tabseat);
                metroTabControl1.TabPages.Remove(tabseats);
            }
            clearcontroll();

        }

        private void clearcontroll()
        {
            txtseatid.Text = new CommonController.CitiesCommonControllor().GetMaximimID().ToString();
            dataGridView1.DataSource= new CitiesCommonControllor().GetSeat(0);
            if (!Globals.Isadmin)
            {
                dataGridView2.DataSource = new CitiesCommonControllor().GetReserve(Globals.Userid,0,"");
                dataGridView2.Columns["SeatID"].Visible = false;
                dataGridView2.Columns["UserID"].Visible = false;
            }
            
            dataGridView1.Update();
            dataGridView1.Refresh();

            txtseatno.Clear();
            txtseatname.Clear();
            isnew = true;
            dtpdate.ResetText();

            //dtpupdatedate.ValueChanged -= dtpdate_ValueChanged;
            dtpupdatedate.ResetText();
            //dtpupdatedate.ValueChanged += dtpdate_ValueChanged;

            cmbseat.DataSource = null;
            //layoutopenorder();
        }


        private void userCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser create = new CreateUser();
            create.Show();
        }

        private void storeCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //this.components.SetDefaultStyle(this, metroStyleManager1.Purple);

            metroStyleManager1.Theme = metroStyleManager1.Theme = MetroThemeStyle.Dark;
            this.Theme = metroStyleManager1.Theme;
            this.Refresh();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = metroStyleManager1.Theme = MetroThemeStyle.Light;
            this.Theme = metroStyleManager1.Theme;
            this.Refresh();
        }

        private void itemCetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cityCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void itemCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                saveupdateseate();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveupdateseate() 
        {
            try
            {
                if (ValidateControl() == true)
                {

                    SeatCommon c = new SeatCommon();
                    c.SeatID = Convert.ToInt32(txtseatid.Text);
                    c.SeatNo = txtseatno.Text;
                    c.SeatName = txtseatname.Text;
                    new CommonController.CitiesCommonControllor().SaveCity(c, isnew);
                    MessageBox.Show("Seat has been Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearcontroll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ValidateControl()
        {

            if (this.txtseatno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Seat No.", "FrmSeat SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtseatno.Focus();
                return false;

            }
            if (this.txtseatname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Seat Name.", "FrmSeat SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtseatname.Focus();
                return false;
            }
            return true;

        }

        public void SetParaOut()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtseatid.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["SeatID"].Value.ToString();
                    txtseatno.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["SeatNo"].Value.ToString();
                    txtseatname.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["SeatName"].Value.ToString();
                    isnew = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetParaOut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isnew==false)
                {
                    saveupdateseate();
                }
                else
                {
                    MessageBox.Show("Please Selct Seat", "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (isnew == false)
                {
                    
                        DialogResult result = MessageBox.Show("Do you really want to delete this Seat?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                        new CitiesCommonControllor().DeleteSeat(Convert.ToInt32(txtseatid.Text.Trim()));
                            MessageBox.Show("Seat has been Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearcontroll();
                        }
                    
                    
                }
                else
                {
                    MessageBox.Show("Please Selct Seat", "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clearcontroll();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SetParaOut();
        }


        public void layoutopenorder()
        {   //categorytile

            order = new List<SeatCommon>();
           // flowLayoutPanel1.Controls.Clear();
            order = new CitiesCommonControllor().GetSeat(0);

            int basex = 0; //flowLayoutPanel1.Location.X;
            int basey = 0; //flowLayoutPanel1.Location.Y;
            for (int i = 0; i < order.Count; i++)
            {

                System.Windows.Forms.Button bt = new Button();
                bt.FlatAppearance.BorderColor = Color.WhiteSmoke;
                bt.Font = new System.Drawing.Font("VAGRounded-Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bt.FlatAppearance.BorderSize = 1;
                bt.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                bt.ForeColor = System.Drawing.Color.Black;
                bt.BackColor = System.Drawing.Color.FromArgb(250, 244, 136);
                bt.Left = basex;
                bt.Top = basey;
                basey += 50;
               
                bt.Width = 80;
                bt.Height = 70;
                bt.Name = String.Format(order[i].SeatID.ToString());
               
               
                //bt.Dock = System.Windows.Forms.DockStyle.Fill;
                bt.Text = String.Format(order[i].SeatNo + " " + order[i].SeatName.ToString());
                bt.Text = bt.Text.Replace(" ", "  " + System.Environment.NewLine);
                bt.TextAlign = ContentAlignment.MiddleCenter;
                bt.UseVisualStyleBackColor = false;
                bt.Click += new EventHandler(order_click);
               // bt.Paint += new System.Windows.Forms.PaintEventHandler(this.Category_Paint);
               // p.Controls.Add(bt);

                //flowLayoutPanel1.Controls.Add(bt);



                
            }



        }

        private void Category_Paint(object sender, PaintEventArgs e)
        {

            //ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
            //                   System.Drawing.Color.FromArgb(250, 244, 136), 5, ButtonBorderStyle.Outset,

            //                   System.Drawing.Color.FromArgb(250, 244, 136), 5, ButtonBorderStyle.Outset,

            //                  System.Drawing.Color.FromArgb(250, 244, 136), 5, ButtonBorderStyle.Inset,

            //                   System.Drawing.Color.FromArgb(250, 244, 136), 5, ButtonBorderStyle.Inset);

            
        }
        
        private void order_click(object sender, EventArgs e)
        {

            
           
        }

        private void tabseat_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbseat.SelectedValue)>0)
            {
                if (!Globals.Isadmin)
                {
                    
                    r.SeatID = Convert.ToInt32(cmbseat.SelectedValue);
                    r.UserID = Globals.Userid;
                    r.Date = dtpdate.Value.Date;
                    if (r != null )
                    {
                        if (r.SeatID > 0)
                        {
                            try
                            {

                                if (!new CommonController.CitiesCommonControllor().GetReservebyUser(r.SeatID, r.UserID, r.Date))
                                {
                                    new CommonController.CitiesCommonControllor().SaveReserve(r);
                                    MessageBox.Show("Reservation has been saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearcontroll();
                                }
                                else
                                {
                                    MessageBox.Show("You already reserved a seat on this date.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    clearcontroll();
                                }



                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a seat", "FrmCity SaveRecord", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clearcontroll();
        }
        List<Reserve> li;
        List<SeatCommon> ls = new List<SeatCommon>();
        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {
            ls.Clear();
            order.Clear();
            order = new CitiesCommonControllor().GetSeat(0);
            ls = new CitiesCommonControllor().GetSeat(0);
            
            if (order.Count>0)
            {
                
                for (int i = 0; i < order.Count; i++)
                {
                    li = new CitiesCommonControllor().GetReserve(Globals.Userid, order[i].SeatID, dtpdate.Value.Date.ToString());
                    if (li.Count > 0)
                    {

                         var it = ls.Where(x => x.SeatID == li[0].SeatID).SingleOrDefault();
                         ls.Remove(it);

                        //ls.RemoveAt(i);
         
                    }
                }
                
            }
            cmbseat.DataSource = ls;
            cmbseat.DisplayMember = "SeatName";
            cmbseat.ValueMember = "SeatID";
            cmbseat.SelectedIndex = -1;

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void btnseatupdate_Click(object sender, EventArgs e)
        {
            try
            {
                var sid = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["SeatID"].Value.ToString();
                var sname = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["SeatName"].Value.ToString();
                var sdate = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["Date"].Value.ToString();
               
                
                    DialogResult result = MessageBox.Show("Do you really want to update seat " + sname + " on " + Convert.ToDateTime(sdate).Date.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                     {
                        li.Clear();
                       li = new CitiesCommonControllor().GetReserve(Globals.Userid, Convert.ToInt32(sid), dtpupdatedate.Value.Date.ToString());
                    if (li.Count>0)
                    {
                        MessageBox.Show("You already reserved a seat on this date !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearcontroll();
                    }
                    else
                    {
                        new CitiesCommonControllor().UpdateRSeat(Convert.ToInt32(sid.Trim()), sdate, Globals.Userid, dtpupdatedate.Value.Date.ToString());
                        MessageBox.Show("Seat has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearcontroll();
                    }
                    
                    }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnseatedelete_Click(object sender, EventArgs e)
        {
            try
            {
                var sid = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["SeatID"].Value.ToString();
                var sname = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["SeatName"].Value.ToString();
                var sdate = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["Date"].Value.ToString();

                DialogResult result = MessageBox.Show("Do you really want to delete seat "+ sname + " on "+Convert.ToDateTime(sdate).Date.ToString()+"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    new CitiesCommonControllor().DeleteRSeat(Convert.ToInt32(sid.Trim()), sdate, Globals.Userid);
                    MessageBox.Show("Seat has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearcontroll();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtpupdatedate_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count>0)
            {
                var sdate = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells["Date"].Value.ToString();

                if (dtpupdatedate.Value.Date == Convert.ToDateTime(sdate).Date)
                {
                    MessageBox.Show("Please change the date for an update !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateUser frm = new CreateUser();
            frm.Show();
        }
    }
}
