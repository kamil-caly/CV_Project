using System.Windows.Forms;

namespace library_man
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

        public void clearTexboxes()
        {
            loginBox.Text = "";
            passwordBox.Text = "";
        }

        public static bool doExit()
        {
            if (MessageBox.Show("Do u want to exit?", "Login Form", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return true;
            return false;
        }

        public void emptyBoxes()
        {
            MessageBox.Show("Login or password cannot be empty!", "Warning", MessageBoxButtons.OK);
        }

        public TextBox getLogin()
        {
            return loginBox;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // loginB
            // 
            this.loginB.BackColor = System.Drawing.Color.Lime;
            this.loginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginB.Location = new System.Drawing.Point(56, 369);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(129, 36);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = false;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // cancelB
            // 
            this.cancelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelB.Location = new System.Drawing.Point(274, 369);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(133, 36);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = false;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Red;
            this.exitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitB.Location = new System.Drawing.Point(430, 0);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(33, 39);
            this.exitB.TabIndex = 4;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBox.Location = new System.Drawing.Point(232, 223);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(175, 38);
            this.loginBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(232, 292);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(175, 38);
            this.passwordBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_man.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(56, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private PictureBox pictureBox1;
    }
}

