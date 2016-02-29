using System;

namespace spammaster
{
    partial class ApiKey
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
            this.busenaL = new System.Windows.Forms.Label();
            this.ikeltiraktaBTN = new System.Windows.Forms.Button();
            this.apiKeyTB = new System.Windows.Forms.TextBox();
            this.ikeltiL = new System.Windows.Forms.Label();
            this.testiBTN = new System.Windows.Forms.Button();
            this.iseitBTN = new System.Windows.Forms.Button();
            this.busenaPB = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išeitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.busenaPB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // busenaL
            // 
            this.busenaL.AutoSize = true;
            this.busenaL.Location = new System.Drawing.Point(50, 63);
            this.busenaL.Name = "busenaL";
            this.busenaL.Size = new System.Drawing.Size(0, 13);
            this.busenaL.TabIndex = 5;
            // 
            // ikeltiraktaBTN
            // 
            this.ikeltiraktaBTN.Location = new System.Drawing.Point(154, 261);
            this.ikeltiraktaBTN.Name = "ikeltiraktaBTN";
            this.ikeltiraktaBTN.Size = new System.Drawing.Size(75, 23);
            this.ikeltiraktaBTN.TabIndex = 6;
            this.ikeltiraktaBTN.Text = "Įkelti";
            this.ikeltiraktaBTN.UseVisualStyleBackColor = true;
            this.ikeltiraktaBTN.Click += new System.EventHandler(this.ikeltiraktaBTN_Click);
            // 
            // apiKeyTB
            // 
            this.apiKeyTB.Location = new System.Drawing.Point(31, 235);
            this.apiKeyTB.Name = "apiKeyTB";
            this.apiKeyTB.Size = new System.Drawing.Size(333, 20);
            this.apiKeyTB.TabIndex = 7;
            // 
            // ikeltiL
            // 
            this.ikeltiL.AutoSize = true;
            this.ikeltiL.Location = new System.Drawing.Point(142, 215);
            this.ikeltiL.Name = "ikeltiL";
            this.ikeltiL.Size = new System.Drawing.Size(85, 13);
            this.ikeltiL.TabIndex = 8;
            this.ikeltiL.Text = "Įkelti naują raktą";
            // 
            // testiBTN
            // 
            this.testiBTN.Location = new System.Drawing.Point(304, 302);
            this.testiBTN.Name = "testiBTN";
            this.testiBTN.Size = new System.Drawing.Size(75, 23);
            this.testiBTN.TabIndex = 9;
            this.testiBTN.Text = "Tęsti";
            this.testiBTN.UseVisualStyleBackColor = true;
            this.testiBTN.Click += new System.EventHandler(this.testiBTN_Click);
            // 
            // iseitBTN
            // 
            this.iseitBTN.Location = new System.Drawing.Point(13, 302);
            this.iseitBTN.Name = "iseitBTN";
            this.iseitBTN.Size = new System.Drawing.Size(75, 23);
            this.iseitBTN.TabIndex = 10;
            this.iseitBTN.Text = "Išeiti";
            this.iseitBTN.UseVisualStyleBackColor = true;
            this.iseitBTN.Click += new System.EventHandler(this.iseitBTN_Click);
            // 
            // busenaPB
            // 
            this.busenaPB.Location = new System.Drawing.Point(128, 79);
            this.busenaPB.Name = "busenaPB";
            this.busenaPB.Size = new System.Drawing.Size(125, 125);
            this.busenaPB.TabIndex = 11;
            this.busenaPB.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.išeitiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // išeitiToolStripMenuItem
            // 
            this.išeitiToolStripMenuItem.Name = "išeitiToolStripMenuItem";
            this.išeitiToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.išeitiToolStripMenuItem.Text = "Išeiti";
            this.išeitiToolStripMenuItem.Click += new System.EventHandler(this.išeitiToolStripMenuItem_Click);
            // 
            // internetL
            // 
            this.internetL.AutoSize = true;
            this.internetL.Location = new System.Drawing.Point(50, 24);
            this.internetL.Name = "internetL";
            this.internetL.Size = new System.Drawing.Size(0, 13);
            this.internetL.TabIndex = 13;
            // 
            // ApiKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 337);
            this.Controls.Add(this.internetL);
            this.Controls.Add(this.busenaPB);
            this.Controls.Add(this.iseitBTN);
            this.Controls.Add(this.testiBTN);
            this.Controls.Add(this.ikeltiL);
            this.Controls.Add(this.apiKeyTB);
            this.Controls.Add(this.ikeltiraktaBTN);
            this.Controls.Add(this.busenaL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ApiKey";
            this.Text = "Prisijungti";
            this.Load += new System.EventHandler(this.ApiKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busenaPB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label busenaL;
        private System.Windows.Forms.Button ikeltiraktaBTN;
        private System.Windows.Forms.TextBox apiKeyTB;
        private System.Windows.Forms.Label ikeltiL;
        private System.Windows.Forms.Button testiBTN;
        private System.Windows.Forms.Button iseitBTN;
        private System.Windows.Forms.PictureBox busenaPB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išeitiToolStripMenuItem;
        private System.Windows.Forms.Label internetL;
    }
}

