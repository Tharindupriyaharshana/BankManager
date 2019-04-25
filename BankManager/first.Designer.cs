namespace BankManager
{
    partial class homecontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unameover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaybleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conatct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.unamefut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today Installments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overdue Installments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1211, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Up Comming Installments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(168, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 10);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uname,
            this.Installment,
            this.contact,
            this.groupnum,
            this.Account});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(18, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 388);
            this.dataGridView1.TabIndex = 5;
            // 
            // Uname
            // 
            this.Uname.HeaderText = "Name";
            this.Uname.Name = "Uname";
            // 
            // Installment
            // 
            this.Installment.HeaderText = "Installment";
            this.Installment.Name = "Installment";
            // 
            // contact
            // 
            this.contact.HeaderText = "Conatct Number";
            this.contact.Name = "contact";
            // 
            // groupnum
            // 
            this.groupnum.HeaderText = "Group Number";
            this.groupnum.Name = "groupnum";
            // 
            // Account
            // 
            this.Account.HeaderText = "Account Status";
            this.Account.Name = "Account";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unameover,
            this.Instover,
            this.Duedate,
            this.PaybleAmount,
            this.Conatct});
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(610, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(545, 388);
            this.dataGridView2.TabIndex = 6;
            // 
            // unameover
            // 
            this.unameover.HeaderText = "Name";
            this.unameover.Name = "unameover";
            // 
            // Instover
            // 
            this.Instover.HeaderText = "Installment";
            this.Instover.Name = "Instover";
            // 
            // Duedate
            // 
            this.Duedate.HeaderText = "Due Date";
            this.Duedate.Name = "Duedate";
            // 
            // PaybleAmount
            // 
            this.PaybleAmount.HeaderText = "Payble Amount";
            this.PaybleAmount.Name = "PaybleAmount";
            // 
            // Conatct
            // 
            this.Conatct.HeaderText = "Contact Number";
            this.Conatct.Name = "Conatct";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unamefut,
            this.InstallmentAmount,
            this.datpay,
            this.con});
            this.dataGridView3.GridColor = System.Drawing.Color.Black;
            this.dataGridView3.Location = new System.Drawing.Point(1190, 195);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(443, 388);
            this.dataGridView3.TabIndex = 7;
            // 
            // unamefut
            // 
            this.unamefut.HeaderText = "Name";
            this.unamefut.Name = "unamefut";
            // 
            // InstallmentAmount
            // 
            this.InstallmentAmount.HeaderText = "Installment";
            this.InstallmentAmount.Name = "InstallmentAmount";
            // 
            // datpay
            // 
            this.datpay.HeaderText = "Due Date";
            this.datpay.Name = "datpay";
            // 
            // con
            // 
            this.con.HeaderText = "Contact Number";
            this.con.Name = "con";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(433, 599);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 66);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "20";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1027, 599);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 66);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 38);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(1505, 616);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 66);
            this.panel4.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 38);
            this.label9.TabIndex = 9;
            this.label9.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 38);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(20, 715);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 66);
            this.panel5.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "50";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 38);
            this.label12.TabIndex = 8;
            this.label12.Text = "Active Accounts";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(413, 715);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 66);
            this.panel6.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(250, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 38);
            this.label13.TabIndex = 9;
            this.label13.Text = "50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 38);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ongoing Loans";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Location = new System.Drawing.Point(849, 715);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 66);
            this.panel7.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(250, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 38);
            this.label15.TabIndex = 9;
            this.label15.Text = "50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 38);
            this.label16.TabIndex = 8;
            this.label16.Text = "Pending Loans";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(1300, 715);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 66);
            this.panel8.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(250, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 38);
            this.label17.TabIndex = 9;
            this.label17.Text = "50";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 38);
            this.label18.TabIndex = 8;
            this.label18.Text = "Active Groups";
            // 
            // homecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "homecontrol";
            this.Size = new System.Drawing.Size(1752, 851);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installment;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unameover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaybleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conatct;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn unamefut;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn datpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn con;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}
