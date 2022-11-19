namespace AccountingProject.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtseatid = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtseatname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseatno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbseat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpupdatedate = new System.Windows.Forms.DateTimePicker();
            this.btnseatupdate = new System.Windows.Forms.Button();
            this.btnseatedelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabseats = new MetroFramework.Controls.MetroTabPage();
            this.tabreserve = new MetroFramework.Controls.MetroTabPage();
            this.tabbook = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tabseats.SuspendLayout();
            this.tabreserve.SuspendLayout();
            this.tabbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seat ID:";
            // 
            // txtseatid
            // 
            this.txtseatid.Enabled = false;
            this.txtseatid.Location = new System.Drawing.Point(125, 140);
            this.txtseatid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtseatid.Name = "txtseatid";
            this.txtseatid.ReadOnly = true;
            this.txtseatid.Size = new System.Drawing.Size(399, 26);
            this.txtseatid.TabIndex = 9;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(440, 314);
            this.btnnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(98, 50);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(619, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 496);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(334, 314);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 50);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(230, 314);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 50);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(125, 314);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 50);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seat Name:";
            // 
            // txtseatname
            // 
            this.txtseatname.Location = new System.Drawing.Point(127, 232);
            this.txtseatname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtseatname.Name = "txtseatname";
            this.txtseatname.Size = new System.Drawing.Size(399, 26);
            this.txtseatname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seat No:";
            // 
            // txtseatno
            // 
            this.txtseatno.Location = new System.Drawing.Point(127, 184);
            this.txtseatno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtseatno.Name = "txtseatno";
            this.txtseatno.Size = new System.Drawing.Size(399, 26);
            this.txtseatno.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(93, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Available Seat:";
            // 
            // cmbseat
            // 
            this.cmbseat.FormattingEnabled = true;
            this.cmbseat.Location = new System.Drawing.Point(242, 140);
            this.cmbseat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbseat.Name = "cmbseat";
            this.cmbseat.Size = new System.Drawing.Size(466, 28);
            this.cmbseat.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(242, 80);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(466, 26);
            this.dtpdate.TabIndex = 3;
            this.dtpdate.ValueChanged += new System.EventHandler(this.dtpdate_ValueChanged);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(584, 200);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(125, 60);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date:";
            // 
            // dtpupdatedate
            // 
            this.dtpupdatedate.Location = new System.Drawing.Point(26, 204);
            this.dtpupdatedate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpupdatedate.Name = "dtpupdatedate";
            this.dtpupdatedate.Size = new System.Drawing.Size(298, 26);
            this.dtpupdatedate.TabIndex = 11;
            this.dtpupdatedate.ValueChanged += new System.EventHandler(this.dtpupdatedate_ValueChanged);
            // 
            // btnseatupdate
            // 
            this.btnseatupdate.Location = new System.Drawing.Point(26, 254);
            this.btnseatupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnseatupdate.Name = "btnseatupdate";
            this.btnseatupdate.Size = new System.Drawing.Size(155, 62);
            this.btnseatupdate.TabIndex = 10;
            this.btnseatupdate.Text = "Update Date";
            this.btnseatupdate.UseVisualStyleBackColor = true;
            this.btnseatupdate.Click += new System.EventHandler(this.btnseatupdate_Click);
            // 
            // btnseatedelete
            // 
            this.btnseatedelete.Location = new System.Drawing.Point(188, 254);
            this.btnseatedelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnseatedelete.Name = "btnseatedelete";
            this.btnseatedelete.Size = new System.Drawing.Size(136, 62);
            this.btnseatedelete.TabIndex = 9;
            this.btnseatedelete.Text = "Delete";
            this.btnseatedelete.UseVisualStyleBackColor = true;
            this.btnseatedelete.Click += new System.EventHandler(this.btnseatedelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(349, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1099, 548);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Seat Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Seat No";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 336;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Seat Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 336;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabseats);
            this.metroTabControl1.Controls.Add(this.tabreserve);
            this.metroTabControl1.Controls.Add(this.tabbook);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(30, 92);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1500, 683);
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabseats
            // 
            this.tabseats.Controls.Add(this.button2);
            this.tabseats.Controls.Add(this.btnnew);
            this.tabseats.Controls.Add(this.label4);
            this.tabseats.Controls.Add(this.dataGridView1);
            this.tabseats.Controls.Add(this.txtseatid);
            this.tabseats.Controls.Add(this.txtseatno);
            this.tabseats.Controls.Add(this.btndelete);
            this.tabseats.Controls.Add(this.label1);
            this.tabseats.Controls.Add(this.btnupdate);
            this.tabseats.Controls.Add(this.txtseatname);
            this.tabseats.Controls.Add(this.btnadd);
            this.tabseats.Controls.Add(this.label2);
            this.tabseats.HorizontalScrollbarBarColor = true;
            this.tabseats.HorizontalScrollbarHighlightOnWheel = false;
            this.tabseats.HorizontalScrollbarSize = 12;
            this.tabseats.Location = new System.Drawing.Point(4, 38);
            this.tabseats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabseats.Name = "tabseats";
            this.tabseats.Size = new System.Drawing.Size(1492, 641);
            this.tabseats.TabIndex = 0;
            this.tabseats.Text = "Add Seat";
            this.tabseats.VerticalScrollbarBarColor = true;
            this.tabseats.VerticalScrollbarHighlightOnWheel = false;
            this.tabseats.VerticalScrollbarSize = 11;
            // 
            // tabreserve
            // 
            this.tabreserve.Controls.Add(this.button1);
            this.tabreserve.Controls.Add(this.label5);
            this.tabreserve.Controls.Add(this.btncancel);
            this.tabreserve.Controls.Add(this.cmbseat);
            this.tabreserve.Controls.Add(this.dtpdate);
            this.tabreserve.Controls.Add(this.label3);
            this.tabreserve.HorizontalScrollbarBarColor = true;
            this.tabreserve.HorizontalScrollbarHighlightOnWheel = false;
            this.tabreserve.HorizontalScrollbarSize = 12;
            this.tabreserve.Location = new System.Drawing.Point(4, 38);
            this.tabreserve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabreserve.Name = "tabreserve";
            this.tabreserve.Size = new System.Drawing.Size(1492, 640);
            this.tabreserve.TabIndex = 1;
            this.tabreserve.Text = "Reserve Seat";
            this.tabreserve.VerticalScrollbarBarColor = true;
            this.tabreserve.VerticalScrollbarHighlightOnWheel = false;
            this.tabreserve.VerticalScrollbarSize = 11;
            // 
            // tabbook
            // 
            this.tabbook.Controls.Add(this.label7);
            this.tabbook.Controls.Add(this.dtpupdatedate);
            this.tabbook.Controls.Add(this.btnseatupdate);
            this.tabbook.Controls.Add(this.btnseatedelete);
            this.tabbook.Controls.Add(this.dataGridView2);
            this.tabbook.HorizontalScrollbarBarColor = true;
            this.tabbook.HorizontalScrollbarHighlightOnWheel = false;
            this.tabbook.HorizontalScrollbarSize = 12;
            this.tabbook.Location = new System.Drawing.Point(4, 38);
            this.tabbook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabbook.Name = "tabbook";
            this.tabbook.Size = new System.Drawing.Size(1492, 640);
            this.tabbook.TabIndex = 2;
            this.tabbook.Text = "Check Seat";
            this.tabbook.VerticalScrollbarBarColor = true;
            this.tabbook.VerticalScrollbarHighlightOnWheel = false;
            this.tabbook.VerticalScrollbarSize = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Create User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 806);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tabseats.ResumeLayout(false);
            this.tabseats.PerformLayout();
            this.tabreserve.ResumeLayout(false);
            this.tabreserve.PerformLayout();
            this.tabbook.ResumeLayout(false);
            this.tabbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtseatname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseatno;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtseatid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbseat;
        private System.Windows.Forms.Button btnseatupdate;
        private System.Windows.Forms.Button btnseatedelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpupdatedate;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabseats;
        private MetroFramework.Controls.MetroTabPage tabreserve;
        private MetroFramework.Controls.MetroTabPage tabbook;
        private System.Windows.Forms.Button button2;
    }
}