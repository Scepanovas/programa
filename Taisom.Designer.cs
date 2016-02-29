namespace spammaster
{
    partial class Taisom
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
            this.vardasTB = new System.Windows.Forms.TextBox();
            this.pavardeTB = new System.Windows.Forms.TextBox();
            this.elpastasTB = new System.Windows.Forms.TextBox();
            this.vardasL = new System.Windows.Forms.Label();
            this.pavardeL = new System.Windows.Forms.Label();
            this.elpastasL = new System.Windows.Forms.Label();
            this.issaugotiBTN = new System.Windows.Forms.Button();
            this.atsauktiBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vardasTB
            // 
            this.vardasTB.Location = new System.Drawing.Point(87, 12);
            this.vardasTB.Name = "vardasTB";
            this.vardasTB.Size = new System.Drawing.Size(185, 20);
            this.vardasTB.TabIndex = 0;
            // 
            // pavardeTB
            // 
            this.pavardeTB.Location = new System.Drawing.Point(87, 38);
            this.pavardeTB.Name = "pavardeTB";
            this.pavardeTB.Size = new System.Drawing.Size(185, 20);
            this.pavardeTB.TabIndex = 1;
            // 
            // elpastasTB
            // 
            this.elpastasTB.Location = new System.Drawing.Point(87, 64);
            this.elpastasTB.Name = "elpastasTB";
            this.elpastasTB.Size = new System.Drawing.Size(185, 20);
            this.elpastasTB.TabIndex = 2;
            // 
            // vardasL
            // 
            this.vardasL.AutoSize = true;
            this.vardasL.Location = new System.Drawing.Point(24, 18);
            this.vardasL.Name = "vardasL";
            this.vardasL.Size = new System.Drawing.Size(43, 13);
            this.vardasL.TabIndex = 3;
            this.vardasL.Text = "Vardas:";
            // 
            // pavardeL
            // 
            this.pavardeL.AutoSize = true;
            this.pavardeL.Location = new System.Drawing.Point(24, 45);
            this.pavardeL.Name = "pavardeL";
            this.pavardeL.Size = new System.Drawing.Size(50, 13);
            this.pavardeL.TabIndex = 4;
            this.pavardeL.Text = "Pavardė:";
            // 
            // elpastasL
            // 
            this.elpastasL.AutoSize = true;
            this.elpastasL.Location = new System.Drawing.Point(24, 71);
            this.elpastasL.Name = "elpastasL";
            this.elpastasL.Size = new System.Drawing.Size(57, 13);
            this.elpastasL.TabIndex = 5;
            this.elpastasL.Text = "El. Paštas:";
            // 
            // issaugotiBTN
            // 
            this.issaugotiBTN.Location = new System.Drawing.Point(27, 90);
            this.issaugotiBTN.Name = "issaugotiBTN";
            this.issaugotiBTN.Size = new System.Drawing.Size(75, 23);
            this.issaugotiBTN.TabIndex = 6;
            this.issaugotiBTN.Text = "Išsaugoti";
            this.issaugotiBTN.UseVisualStyleBackColor = true;
            this.issaugotiBTN.Click += new System.EventHandler(this.issaugotiBTN_Click);
            // 
            // atsauktiBTN
            // 
            this.atsauktiBTN.Location = new System.Drawing.Point(196, 89);
            this.atsauktiBTN.Name = "atsauktiBTN";
            this.atsauktiBTN.Size = new System.Drawing.Size(75, 23);
            this.atsauktiBTN.TabIndex = 7;
            this.atsauktiBTN.Text = "Atšaukti";
            this.atsauktiBTN.UseVisualStyleBackColor = true;
            this.atsauktiBTN.Click += new System.EventHandler(this.atsauktiBTN_Click);
            // 
            // Taisom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.atsauktiBTN);
            this.Controls.Add(this.issaugotiBTN);
            this.Controls.Add(this.elpastasL);
            this.Controls.Add(this.pavardeL);
            this.Controls.Add(this.vardasL);
            this.Controls.Add(this.elpastasTB);
            this.Controls.Add(this.pavardeTB);
            this.Controls.Add(this.vardasTB);
            this.Name = "Tvarkom";
            this.Text = "Tvarkom";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.Taisom_Load);

        }

        #endregion

        private System.Windows.Forms.TextBox vardasTB;
        private System.Windows.Forms.TextBox pavardeTB;
        private System.Windows.Forms.TextBox elpastasTB;
        private System.Windows.Forms.Label vardasL;
        private System.Windows.Forms.Label pavardeL;
        private System.Windows.Forms.Label elpastasL;
        private System.Windows.Forms.Button issaugotiBTN;
        private System.Windows.Forms.Button atsauktiBTN;
    }
}