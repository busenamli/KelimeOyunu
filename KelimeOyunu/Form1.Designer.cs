
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
            this.exit_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.add_word_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_button.Location = new System.Drawing.Point(362, 183);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(135, 41);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "OYUNA BAŞLA";
            this.start_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_button.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.exit_button.Location = new System.Drawing.Point(362, 309);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 41);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "OYUNDAN ÇIK";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcome_label.Font = new System.Drawing.Font("Century751 No2 BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_label.Location = new System.Drawing.Point(306, 101);
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
            this.add_word_button.Location = new System.Drawing.Point(362, 246);
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
            this.panel1.Controls.Add(this.welcome_label);
            this.panel1.Controls.Add(this.add_word_button);
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 437);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 437);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button add_word_button;
        private System.Windows.Forms.Panel panel1;
    }
}

