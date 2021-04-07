
namespace KelimeOyunu
{
    partial class AddWord
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cevap_uzunluk_text = new System.Windows.Forms.TextBox();
            this.cevap_text = new System.Windows.Forms.TextBox();
            this.soru_text = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cevap_uzunluk_text);
            this.panel2.Controls.Add(this.cevap_text);
            this.panel2.Controls.Add(this.soru_text);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 5;
            // 
            // cevap_uzunluk_text
            // 
            this.cevap_uzunluk_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cevap_uzunluk_text.Font = new System.Drawing.Font("Century751 No2 BT", 14F);
            this.cevap_uzunluk_text.Location = new System.Drawing.Point(467, 132);
            this.cevap_uzunluk_text.Name = "cevap_uzunluk_text";
            this.cevap_uzunluk_text.Size = new System.Drawing.Size(82, 30);
            this.cevap_uzunluk_text.TabIndex = 5;
            // 
            // cevap_text
            // 
            this.cevap_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cevap_text.Font = new System.Drawing.Font("Century751 No2 BT", 14F);
            this.cevap_text.Location = new System.Drawing.Point(361, 132);
            this.cevap_text.Name = "cevap_text";
            this.cevap_text.Size = new System.Drawing.Size(82, 30);
            this.cevap_text.TabIndex = 4;
            // 
            // soru_text
            // 
            this.soru_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soru_text.Font = new System.Drawing.Font("Century751 No2 BT", 14F);
            this.soru_text.Location = new System.Drawing.Point(216, 132);
            this.soru_text.Multiline = true;
            this.soru_text.Name = "soru_text";
            this.soru_text.Size = new System.Drawing.Size(121, 30);
            this.soru_text.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.Location = new System.Drawing.Point(329, 261);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(135, 41);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "KAYDET";
            this.save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWord";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cevap_uzunluk_text;
        private System.Windows.Forms.TextBox cevap_text;
        private System.Windows.Forms.TextBox soru_text;
        private System.Windows.Forms.Button save_button;
    }
}