namespace GoogleURLShortener
{
    partial class URLShortener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLShortener));
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKisalt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKisaAdres = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(14, 33);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(373, 23);
            this.txtAdres.TabIndex = 0;
            // 
            // btnKisalt
            // 
            this.btnKisalt.Location = new System.Drawing.Point(394, 33);
            this.btnKisalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKisalt.Name = "btnKisalt";
            this.btnKisalt.Size = new System.Drawing.Size(87, 28);
            this.btnKisalt.TabIndex = 1;
            this.btnKisalt.Text = "Kısalt";
            this.btnKisalt.UseVisualStyleBackColor = true;
            this.btnKisalt.Click += new System.EventHandler(this.btnKisalt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kısa Adres :";
            // 
            // txtKisaAdres
            // 
            this.txtKisaAdres.Location = new System.Drawing.Point(97, 84);
            this.txtKisaAdres.Name = "txtKisaAdres";
            this.txtKisaAdres.Size = new System.Drawing.Size(290, 23);
            this.txtKisaAdres.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Location = new System.Drawing.Point(0, 139);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(195, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.karadasburak.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // URLShortener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 155);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtKisaAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKisalt);
            this.Controls.Add(this.txtAdres);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "URLShortener";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google URL Shortener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKisalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKisaAdres;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}