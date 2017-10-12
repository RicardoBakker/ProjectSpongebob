namespace Startscherm
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
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button.Font = new System.Drawing.Font("Kristen ITC", 14F);
            this.button.Location = new System.Drawing.Point(91, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(306, 67);
            this.button.TabIndex = 0;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.start_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Kristen ITC", 14F);
            this.button2.Location = new System.Drawing.Point(90, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Highscores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.scores_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 14F);
            this.button3.Location = new System.Drawing.Point(90, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Spelregels";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.rules_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Startscherm.Properties.Resources._1470962d95fe01237f1467465b03a3e8;
            this.ClientSize = new System.Drawing.Size(486, 316);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startscherm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

