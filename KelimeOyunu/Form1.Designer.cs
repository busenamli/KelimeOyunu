
namespace KelimeOyunu
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
            this.start_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.add_word_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.exit_picture = new System.Windows.Forms.PictureBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_button.Location = new System.Drawing.Point(345, 364);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(135, 41);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "OYUNA BAŞLA";
            this.start_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_label.Font = new System.Drawing.Font("Century751 No2 BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_label.Location = new System.Drawing.Point(383, 107);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(258, 50);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "HOŞGELDİNİZ";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_word_button
            // 
            this.add_word_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_word_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.add_word_button.Location = new System.Drawing.Point(543, 364);
            this.add_word_button.Name = "add_word_button";
            this.add_word_button.Size = new System.Drawing.Size(135, 41);
            this.add_word_button.TabIndex = 1;
            this.add_word_button.Text = "KELİME EKLE";
            this.add_word_button.UseVisualStyleBackColor = true;
            this.add_word_button.Click += new System.EventHandler(this.add_word_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name_text);
            this.panel1.Controls.Add(this.welcome_label);
            this.panel1.Controls.Add(this.add_word_button);
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 566);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.back_picture);
            this.panel2.Controls.Add(this.exit_picture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 34);
            this.panel2.TabIndex = 5;
            // 
            // back_picture
            // 
            this.back_picture.Image = global::KelimeOyunu.Properties.Resources.left_arrow;
            this.back_picture.Location = new System.Drawing.Point(3, 4);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(28, 27);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 4;
            this.back_picture.TabStop = false;
            this.back_picture.Visible = false;
            this.back_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exit_picture
            // 
            this.exit_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_picture.Image = global::KelimeOyunu.Properties.Resources.close_button_png;
            this.exit_picture.Location = new System.Drawing.Point(969, 3);
            this.exit_picture.Name = "exit_picture";
            this.exit_picture.Size = new System.Drawing.Size(28, 27);
            this.exit_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_picture.TabIndex = 3;
            this.exit_picture.TabStop = false;
            this.exit_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // name_text
            // 
            this.name_text.Font = new System.Drawing.Font("Century751 No2 BT", 12F, System.Drawing.FontStyle.Italic);
            this.name_text.Location = new System.Drawing.Point(440, 235);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(135, 27);
            this.name_text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(440, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adınızı Giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button add_word_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox exit_picture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label1;
    }
}

