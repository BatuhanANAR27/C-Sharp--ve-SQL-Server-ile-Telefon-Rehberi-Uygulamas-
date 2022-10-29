
namespace TelefonRehberi
{
    partial class Kullanıcı
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
            this.KullanıcıLabel = new System.Windows.Forms.Label();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.KullanıcıTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullanıcıLabel
            // 
            this.KullanıcıLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullanıcıLabel.Location = new System.Drawing.Point(46, 61);
            this.KullanıcıLabel.Name = "KullanıcıLabel";
            this.KullanıcıLabel.Size = new System.Drawing.Size(144, 36);
            this.KullanıcıLabel.TabIndex = 0;
            this.KullanıcıLabel.Text = "Kullanıcı Adı";
            // 
            // SifreLabel
            // 
            this.SifreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreLabel.Location = new System.Drawing.Point(46, 138);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(144, 36);
            this.SifreLabel.TabIndex = 1;
            this.SifreLabel.Text = "Sifre";
            // 
            // KullanıcıTextBox
            // 
            this.KullanıcıTextBox.Location = new System.Drawing.Point(196, 57);
            this.KullanıcıTextBox.Multiline = true;
            this.KullanıcıTextBox.Name = "KullanıcıTextBox";
            this.KullanıcıTextBox.Size = new System.Drawing.Size(227, 40);
            this.KullanıcıTextBox.TabIndex = 2;
           
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(196, 134);
            this.SifreTextBox.Multiline = true;
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.PasswordChar = '*';
            this.SifreTextBox.Size = new System.Drawing.Size(227, 40);
            this.SifreTextBox.TabIndex = 3;
            // 
            // GirisiButton
            // 
            this.GirisiButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GirisiButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GirisiButton.Location = new System.Drawing.Point(447, 224);
            this.GirisiButton.Name = "GirisiButton";
            this.GirisiButton.Size = new System.Drawing.Size(103, 71);
            this.GirisiButton.TabIndex = 4;
            this.GirisiButton.Text = "GİRİS";
            this.GirisiButton.UseVisualStyleBackColor = false;
            this.GirisiButton.Click += new System.EventHandler(this.GirisiButton_Click);
            // 
            // Kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(642, 361);
            this.Controls.Add(this.GirisiButton);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullanıcıTextBox);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.KullanıcıLabel);
            this.Name = "Kullanıcı";
            this.Text = "Kullanıcı";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullanıcıLabel;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.TextBox KullanıcıTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisiButton;
    }
}