namespace spammaster
{
    partial class Skydine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skydine));
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gavejaiTB = new System.Windows.Forms.TextBox();
            this.temaTB = new System.Windows.Forms.TextBox();
            this.tekstasTB = new System.Windows.Forms.TextBox();
            this.gavejaiL = new System.Windows.Forms.Label();
            this.temaL = new System.Windows.Forms.Label();
            this.tekstasL = new System.Windows.Forms.Label();
            this.siustiBTN = new System.Windows.Forms.Button();
            this.jusuelL = new System.Windows.Forms.Label();
            this.jusuelTB = new System.Windows.Forms.TextBox();
            this.isjungtiBTN = new System.Windows.Forms.Button();
            this.griztiBTN = new System.Windows.Forms.Button();
            this.taisytigPB = new System.Windows.Forms.PictureBox();
            this.pridetigPB = new System.Windows.Forms.PictureBox();
            this.pridetigL = new System.Windows.Forms.Label();
            this.taisytigL = new System.Windows.Forms.Label();
            this.gavejuList = new System.Windows.Forms.ListBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lauktiB = new System.Windows.Forms.ProgressBar();
            this.redaguotigBTN = new System.Windows.Forms.Button();
            this.naujasgBTN = new System.Windows.Forms.Button();
            this.trintigBTN = new System.Windows.Forms.Button();
            this.infoL = new System.Windows.Forms.Label();
            this.failasTB = new System.Windows.Forms.TextBox();
            this.failasBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taisytigPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridetigPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FirstName.DataPropertyName = "first_name";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 82;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastName.DataPropertyName = "last_name";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 83;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // gavejaiTB
            // 
            this.gavejaiTB.Location = new System.Drawing.Point(59, 46);
            this.gavejaiTB.Name = "gavejaiTB";
            this.gavejaiTB.Size = new System.Drawing.Size(219, 20);
            this.gavejaiTB.TabIndex = 0;
            // 
            // temaTB
            // 
            this.temaTB.Location = new System.Drawing.Point(59, 73);
            this.temaTB.Name = "temaTB";
            this.temaTB.Size = new System.Drawing.Size(219, 20);
            this.temaTB.TabIndex = 1;
            // 
            // tekstasTB
            // 
            this.tekstasTB.Location = new System.Drawing.Point(59, 99);
            this.tekstasTB.Multiline = true;
            this.tekstasTB.Name = "tekstasTB";
            this.tekstasTB.Size = new System.Drawing.Size(219, 152);
            this.tekstasTB.TabIndex = 2;
            // 
            // gavejaiL
            // 
            this.gavejaiL.AutoSize = true;
            this.gavejaiL.Location = new System.Drawing.Point(8, 49);
            this.gavejaiL.Name = "gavejaiL";
            this.gavejaiL.Size = new System.Drawing.Size(46, 13);
            this.gavejaiL.TabIndex = 3;
            this.gavejaiL.Text = "Gavėjai:";
            // 
            // temaL
            // 
            this.temaL.AutoSize = true;
            this.temaL.Location = new System.Drawing.Point(8, 76);
            this.temaL.Name = "temaL";
            this.temaL.Size = new System.Drawing.Size(37, 13);
            this.temaL.TabIndex = 4;
            this.temaL.Text = "Tema:";
            // 
            // tekstasL
            // 
            this.tekstasL.AutoSize = true;
            this.tekstasL.Location = new System.Drawing.Point(8, 107);
            this.tekstasL.Name = "tekstasL";
            this.tekstasL.Size = new System.Drawing.Size(48, 13);
            this.tekstasL.TabIndex = 5;
            this.tekstasL.Text = "Tekstas:";
            // 
            // siustiBTN
            // 
            this.siustiBTN.Location = new System.Drawing.Point(122, 288);
            this.siustiBTN.Name = "siustiBTN";
            this.siustiBTN.Size = new System.Drawing.Size(75, 23);
            this.siustiBTN.TabIndex = 6;
            this.siustiBTN.Text = "Siųsti";
            this.siustiBTN.UseVisualStyleBackColor = true;
            this.siustiBTN.Click += new System.EventHandler(this.siustiBTN_Click);
            // 
            // jusuelL
            // 
            this.jusuelL.AutoSize = true;
            this.jusuelL.Location = new System.Drawing.Point(8, 9);
            this.jusuelL.Name = "jusuelL";
            this.jusuelL.Size = new System.Drawing.Size(270, 13);
            this.jusuelL.TabIndex = 8;
            this.jusuelL.Text = "Jūsų el. pašto adresas (registruotas SendGrid paskyroje)";
            // 
            // jusuelTB
            // 
            this.jusuelTB.Location = new System.Drawing.Point(284, 6);
            this.jusuelTB.Name = "jusuelTB";
            this.jusuelTB.Size = new System.Drawing.Size(191, 20);
            this.jusuelTB.TabIndex = 10;
            // 
            // isjungtiBTN
            // 
            this.isjungtiBTN.Location = new System.Drawing.Point(466, 288);
            this.isjungtiBTN.Name = "isjungtiBTN";
            this.isjungtiBTN.Size = new System.Drawing.Size(148, 23);
            this.isjungtiBTN.TabIndex = 11;
            this.isjungtiBTN.Text = "Išjungti programą";
            this.isjungtiBTN.UseVisualStyleBackColor = true;
            this.isjungtiBTN.Click += new System.EventHandler(this.isjungtiBTN_Click);
            // 
            // griztiBTN
            // 
            this.griztiBTN.Location = new System.Drawing.Point(315, 288);
            this.griztiBTN.Name = "griztiBTN";
            this.griztiBTN.Size = new System.Drawing.Size(145, 23);
            this.griztiBTN.TabIndex = 12;
            this.griztiBTN.Text = "Grįžti į prisijungimo langą";
            this.griztiBTN.UseVisualStyleBackColor = true;
            this.griztiBTN.Click += new System.EventHandler(this.griztiBTN_Click);
            // 
            // taisytigPB
            // 
            this.taisytigPB.Image = ((System.Drawing.Image)(resources.GetObject("taisytigPB.Image")));
            this.taisytigPB.Location = new System.Drawing.Point(466, 32);
            this.taisytigPB.Name = "taisytigPB";
            this.taisytigPB.Size = new System.Drawing.Size(100, 61);
            this.taisytigPB.TabIndex = 16;
            this.taisytigPB.TabStop = false;
            this.taisytigPB.Click += new System.EventHandler(this.taisytigPB_Click);
            // 
            // pridetigPB
            // 
            this.pridetigPB.Image = ((System.Drawing.Image)(resources.GetObject("pridetigPB.Image")));
            this.pridetigPB.Location = new System.Drawing.Point(368, 32);
            this.pridetigPB.Name = "pridetigPB";
            this.pridetigPB.Size = new System.Drawing.Size(97, 61);
            this.pridetigPB.TabIndex = 15;
            this.pridetigPB.TabStop = false;
            this.pridetigPB.Click += new System.EventHandler(this.pridetigPB_Click);
            // 
            // pridetigL
            // 
            this.pridetigL.AutoSize = true;
            this.pridetigL.BackColor = System.Drawing.Color.Transparent;
            this.pridetigL.Location = new System.Drawing.Point(377, 53);
            this.pridetigL.Name = "pridetigL";
            this.pridetigL.Size = new System.Drawing.Size(76, 13);
            this.pridetigL.TabIndex = 17;
            this.pridetigL.Text = "Pridėti gavėjus";
            // 
            // taisytigL
            // 
            this.taisytigL.AutoSize = true;
            this.taisytigL.Location = new System.Drawing.Point(475, 53);
            this.taisytigL.Name = "taisytigL";
            this.taisytigL.Size = new System.Drawing.Size(79, 13);
            this.taisytigL.TabIndex = 18;
            this.taisytigL.Text = "Tvarkyti sąrašą";
            // 
            // gavejuList
            // 
            this.gavejuList.FormattingEnabled = true;
            this.gavejuList.Location = new System.Drawing.Point(315, 126);
            this.gavejuList.Name = "gavejuList";
            this.gavejuList.Size = new System.Drawing.Size(299, 160);
            this.gavejuList.TabIndex = 19;
            this.gavejuList.DoubleClick += new System.EventHandler(this.gavejuList_DoubleClick);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email});
            this.dataGrid.Location = new System.Drawing.Point(315, 126);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(299, 159);
            this.dataGrid.TabIndex = 0;
            // 
            // lauktiB
            // 
            this.lauktiB.Location = new System.Drawing.Point(315, 91);
            this.lauktiB.Name = "lauktiB";
            this.lauktiB.Size = new System.Drawing.Size(299, 10);
            this.lauktiB.TabIndex = 21;
            // 
            // redaguotigBTN
            // 
            this.redaguotigBTN.Location = new System.Drawing.Point(416, 102);
            this.redaguotigBTN.Name = "redaguotigBTN";
            this.redaguotigBTN.Size = new System.Drawing.Size(95, 23);
            this.redaguotigBTN.TabIndex = 22;
            this.redaguotigBTN.Text = "Redaguoti";
            this.redaguotigBTN.UseVisualStyleBackColor = true;
            this.redaguotigBTN.Click += new System.EventHandler(this.redaguotigBTN_Click);
            // 
            // naujasgBTN
            // 
            this.naujasgBTN.Location = new System.Drawing.Point(315, 102);
            this.naujasgBTN.Name = "naujasgBTN";
            this.naujasgBTN.Size = new System.Drawing.Size(95, 23);
            this.naujasgBTN.TabIndex = 23;
            this.naujasgBTN.Text = "Naujas";
            this.naujasgBTN.UseVisualStyleBackColor = true;
            this.naujasgBTN.Click += new System.EventHandler(this.naujasgBTN_Click);
            // 
            // trintigBTN
            // 
            this.trintigBTN.Location = new System.Drawing.Point(517, 102);
            this.trintigBTN.Name = "trintigBTN";
            this.trintigBTN.Size = new System.Drawing.Size(95, 23);
            this.trintigBTN.TabIndex = 24;
            this.trintigBTN.Text = "Trinti";
            this.trintigBTN.UseVisualStyleBackColor = true;
            this.trintigBTN.Click += new System.EventHandler(this.trintigBTN_Click);
            // 
            // infoL
            // 
            this.infoL.AutoSize = true;
            this.infoL.Location = new System.Drawing.Point(318, 107);
            this.infoL.Name = "infoL";
            this.infoL.Size = new System.Drawing.Size(295, 13);
            this.infoL.TabIndex = 25;
            this.infoL.Text = "Du kartus spustelėkite kontaktą, kurį norite pridėti prie gavėjų";
            // 
            // failasTB
            // 
            this.failasTB.Location = new System.Drawing.Point(59, 258);
            this.failasTB.Name = "failasTB";
            this.failasTB.ReadOnly = true;
            this.failasTB.Size = new System.Drawing.Size(138, 20);
            this.failasTB.TabIndex = 26;
            // 
            // failasBTN
            // 
            this.failasBTN.Location = new System.Drawing.Point(204, 256);
            this.failasBTN.Name = "failasBTN";
            this.failasBTN.Size = new System.Drawing.Size(75, 23);
            this.failasBTN.TabIndex = 27;
            this.failasBTN.Text = "Pridėti failą";
            this.failasBTN.UseVisualStyleBackColor = true;
            this.failasBTN.Click += new System.EventHandler(this.failasBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Skydine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 322);
            //this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.failasBTN);
            this.Controls.Add(this.failasTB);
            this.Controls.Add(this.infoL);
            this.Controls.Add(this.trintigBTN);
            this.Controls.Add(this.naujasgBTN);
            this.Controls.Add(this.redaguotigBTN);
            this.Controls.Add(this.lauktiB);
            this.Controls.Add(this.taisytigL);
            this.Controls.Add(this.pridetigL);
            this.Controls.Add(this.taisytigPB);
            this.Controls.Add(this.pridetigPB);
            this.Controls.Add(this.griztiBTN);
            this.Controls.Add(this.isjungtiBTN);
            this.Controls.Add(this.jusuelTB);
            this.Controls.Add(this.jusuelL);
            this.Controls.Add(this.siustiBTN);
            this.Controls.Add(this.tekstasL);
            this.Controls.Add(this.temaL);
            this.Controls.Add(this.gavejaiL);
            this.Controls.Add(this.tekstasTB);
            this.Controls.Add(this.temaTB);
            this.Controls.Add(this.gavejaiTB);
            this.Name = "Skydine";
            this.Text = "Skydinė";
            this.Load += new System.EventHandler(this.Skydine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taisytigPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridetigPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox gavejaiTB;
        private System.Windows.Forms.TextBox temaTB;
        private System.Windows.Forms.TextBox tekstasTB;
        private System.Windows.Forms.Label gavejaiL;
        private System.Windows.Forms.Label temaL;
        private System.Windows.Forms.Label tekstasL;
        private System.Windows.Forms.Button siustiBTN;
        private System.Windows.Forms.Label jusuelL;
        private System.Windows.Forms.TextBox jusuelTB;
        private System.Windows.Forms.Button isjungtiBTN;
        private System.Windows.Forms.Button griztiBTN;
        private System.Windows.Forms.PictureBox pridetigPB;
        private System.Windows.Forms.PictureBox taisytigPB;
        private System.Windows.Forms.Label pridetigL;
        private System.Windows.Forms.Label taisytigL;
        private System.Windows.Forms.ListBox gavejuList;
        private System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.ProgressBar lauktiB;
        private System.Windows.Forms.Button redaguotigBTN;
        private System.Windows.Forms.Button naujasgBTN;
        private System.Windows.Forms.Button trintigBTN;
        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.TextBox failasTB;
        private System.Windows.Forms.Button failasBTN;
        private System.Windows.Forms.Timer timer1;
    }
}