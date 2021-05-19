namespace econ
{
    partial class Form1
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
            this.btsave = new System.Windows.Forms.Button();
            this.lbcid = new System.Windows.Forms.Label();
            this.lbfname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbcon = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.textcid = new System.Windows.Forms.TextBox();
            this.textfname = new System.Windows.Forms.TextBox();
            this.textlname = new System.Windows.Forms.TextBox();
            this.textcon = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbserch = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.Aqua;
            this.btsave.Location = new System.Drawing.Point(51, 354);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(77, 32);
            this.btsave.TabIndex = 0;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbcid
            // 
            this.lbcid.AutoSize = true;
            this.lbcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcid.Location = new System.Drawing.Point(32, 50);
            this.lbcid.Name = "lbcid";
            this.lbcid.Size = new System.Drawing.Size(96, 20);
            this.lbcid.TabIndex = 1;
            this.lbcid.Text = "Contact ID";
            // 
            // lbfname
            // 
            this.lbfname.AutoSize = true;
            this.lbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfname.Location = new System.Drawing.Point(32, 80);
            this.lbfname.Name = "lbfname";
            this.lbfname.Size = new System.Drawing.Size(96, 20);
            this.lbfname.TabIndex = 2;
            this.lbfname.Text = "First Name";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(31, 112);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(95, 20);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Last Name";
            // 
            // lbcon
            // 
            this.lbcon.AutoSize = true;
            this.lbcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcon.Location = new System.Drawing.Point(32, 146);
            this.lbcon.Name = "lbcon";
            this.lbcon.Size = new System.Drawing.Size(83, 20);
            this.lbcon.TabIndex = 4;
            this.lbcon.Text = "Contatct ";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.Location = new System.Drawing.Point(32, 197);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(75, 20);
            this.lbaddress.TabIndex = 5;
            this.lbaddress.Text = "Address";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgender.Location = new System.Drawing.Point(32, 278);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(65, 20);
            this.lbgender.TabIndex = 6;
            this.lbgender.Text = "gender";
            // 
            // textcid
            // 
            this.textcid.Location = new System.Drawing.Point(161, 50);
            this.textcid.Name = "textcid";
            this.textcid.ReadOnly = true;
            this.textcid.Size = new System.Drawing.Size(146, 20);
            this.textcid.TabIndex = 7;
            // 
            // textfname
            // 
            this.textfname.Location = new System.Drawing.Point(161, 82);
            this.textfname.Name = "textfname";
            this.textfname.Size = new System.Drawing.Size(146, 20);
            this.textfname.TabIndex = 8;
            // 
            // textlname
            // 
            this.textlname.Location = new System.Drawing.Point(161, 114);
            this.textlname.Name = "textlname";
            this.textlname.Size = new System.Drawing.Size(146, 20);
            this.textlname.TabIndex = 9;
            // 
            // textcon
            // 
            this.textcon.Location = new System.Drawing.Point(161, 148);
            this.textcon.Name = "textcon";
            this.textcon.Size = new System.Drawing.Size(146, 20);
            this.textcon.TabIndex = 10;
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(161, 176);
            this.textaddress.Multiline = true;
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(146, 74);
            this.textaddress.TabIndex = 11;
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(161, 276);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(146, 21);
            this.combogender.TabIndex = 12;
            this.combogender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.Yellow;
            this.btupdate.Location = new System.Drawing.Point(148, 354);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(77, 32);
            this.btupdate.TabIndex = 13;
            this.btupdate.Text = "UPDATE";
            this.btupdate.UseVisualStyleBackColor = false;
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.Red;
            this.btdelete.Location = new System.Drawing.Point(249, 354);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(76, 32);
            this.btdelete.TabIndex = 14;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = false;
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btclear.Location = new System.Drawing.Point(345, 354);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(76, 32);
            this.btclear.TabIndex = 15;
            this.btclear.Text = "CLEAR";
            this.btclear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 214);
            this.dataGridView1.TabIndex = 16;
            // 
            // lbserch
            // 
            this.lbserch.AutoSize = true;
            this.lbserch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbserch.Location = new System.Drawing.Point(341, 48);
            this.lbserch.Name = "lbserch";
            this.lbserch.Size = new System.Drawing.Size(66, 20);
            this.lbserch.TabIndex = 17;
            this.lbserch.Text = "Search";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(413, 48);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(310, 20);
            this.textsearch.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 416);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.lbserch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textcon);
            this.Controls.Add(this.textlname);
            this.Controls.Add(this.textfname);
            this.Controls.Add(this.textcid);
            this.Controls.Add(this.lbgender);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbcon);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbfname);
            this.Controls.Add(this.lbcid);
            this.Controls.Add(this.btsave);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbcid;
        private System.Windows.Forms.Label lbfname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbcon;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.TextBox textcid;
        private System.Windows.Forms.TextBox textfname;
        private System.Windows.Forms.TextBox textlname;
        private System.Windows.Forms.TextBox textcon;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbserch;
        private System.Windows.Forms.TextBox textsearch;
    }
}

