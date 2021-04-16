
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
            this.cevap_uzunluk_upDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cevap_text = new System.Windows.Forms.TextBox();
            this.soru_text = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cevap_uzunluk_upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cevap_uzunluk_upDown);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cevap_text);
            this.panel2.Controls.Add(this.soru_text);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 555);
            this.panel2.TabIndex = 5;
            // 
            // cevap_uzunluk_upDown
            // 
            this.cevap_uzunluk_upDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cevap_uzunluk_upDown.Font = new System.Drawing.Font("Century751 No2 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap_uzunluk_upDown.Location = new System.Drawing.Point(315, 398);
            this.cevap_uzunluk_upDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cevap_uzunluk_upDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cevap_uzunluk_upDown.Name = "cevap_uzunluk_upDown";
            this.cevap_uzunluk_upDown.Size = new System.Drawing.Size(208, 27);
            this.cevap_uzunluk_upDown.TabIndex = 9;
            this.cevap_uzunluk_upDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(126, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanım:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(126, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 58);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kelime:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(126, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kelime Kategorisi:\r\n(Harf sayısını giriniz)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            // 
            // cevap_text
            // 
            this.cevap_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cevap_text.Font = new System.Drawing.Font("Century751 No2 BT", 12F);
            this.cevap_text.Location = new System.Drawing.Point(315, 292);
            this.cevap_text.Name = "cevap_text";
            this.cevap_text.Size = new System.Drawing.Size(208, 27);
            this.cevap_text.TabIndex = 4;
            this.cevap_text.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            // 
            // soru_text
            // 
            this.soru_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soru_text.Font = new System.Drawing.Font("Century751 No2 BT", 12F);
            this.soru_text.Location = new System.Drawing.Point(315, 137);
            this.soru_text.Multiline = true;
            this.soru_text.Name = "soru_text";
            this.soru_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.soru_text.Size = new System.Drawing.Size(208, 106);
            this.soru_text.TabIndex = 3;
            this.soru_text.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_button.BackColor = System.Drawing.Color.Snow;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.Location = new System.Drawing.Point(715, 278);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(146, 53);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "KAYDET";
            this.save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.TextChanged += new System.EventHandler(this.soru_text_TextChanged);
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::KelimeOyunu.Properties.Resources.photo_1569982175971_d92b01cf8694;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 555);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(990, 555);
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWord";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cevap_uzunluk_upDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cevap_text;
        private System.Windows.Forms.TextBox soru_text;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cevap_uzunluk_upDown;
    }
}