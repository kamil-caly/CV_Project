
namespace library_man
{
    partial class ViewStudents
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
            this.refreshB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indexTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.idTb = new System.Windows.Forms.TextBox();
            this.sfdasdf = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.sgsfg = new System.Windows.Forms.Label();
            this.dsgsdfg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshB
            // 
            this.refreshB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshB.Location = new System.Drawing.Point(18, 189);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(158, 41);
            this.refreshB.TabIndex = 16;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearB.Location = new System.Drawing.Point(667, 130);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(140, 41);
            this.clearB.TabIndex = 15;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTb.Location = new System.Drawing.Point(358, 194);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(221, 29);
            this.searchTb.TabIndex = 14;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(199, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Student";
            // 
            // updateB
            // 
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateB.Location = new System.Drawing.Point(667, 71);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(140, 41);
            this.updateB.TabIndex = 12;
            this.updateB.Text = "Update Student";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteB.Location = new System.Drawing.Point(667, 12);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(140, 41);
            this.deleteB.TabIndex = 11;
            this.deleteB.Text = "Delete Student";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.emailTb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.indexTb);
            this.panel2.Controls.Add(this.surnameTb);
            this.panel2.Controls.Add(this.nameTb);
            this.panel2.Controls.Add(this.idTb);
            this.panel2.Controls.Add(this.sfdasdf);
            this.panel2.Controls.Add(this.sdf);
            this.panel2.Controls.Add(this.sgsfg);
            this.panel2.Controls.Add(this.dsgsdfg);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 162);
            this.panel2.TabIndex = 10;
            // 
            // indexTb
            // 
            this.indexTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.indexTb.Location = new System.Drawing.Point(419, 12);
            this.indexTb.Name = "indexTb";
            this.indexTb.Size = new System.Drawing.Size(219, 29);
            this.indexTb.TabIndex = 7;
            // 
            // surnameTb
            // 
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameTb.Location = new System.Drawing.Point(99, 104);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(241, 29);
            this.surnameTb.TabIndex = 6;
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTb.Location = new System.Drawing.Point(99, 59);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(241, 29);
            this.nameTb.TabIndex = 5;
            // 
            // idTb
            // 
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTb.Location = new System.Drawing.Point(99, 12);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(241, 29);
            this.idTb.TabIndex = 4;
            // 
            // sfdasdf
            // 
            this.sfdasdf.AutoSize = true;
            this.sfdasdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sfdasdf.Location = new System.Drawing.Point(355, 17);
            this.sfdasdf.Name = "sfdasdf";
            this.sfdasdf.Size = new System.Drawing.Size(62, 24);
            this.sfdasdf.TabIndex = 3;
            this.sfdasdf.Text = "Index";
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sdf.Location = new System.Drawing.Point(7, 107);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(94, 24);
            this.sdf.TabIndex = 2;
            this.sdf.Text = "Surname";
            // 
            // sgsfg
            // 
            this.sgsfg.AutoSize = true;
            this.sgsfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sgsfg.Location = new System.Drawing.Point(7, 59);
            this.sgsfg.Name = "sgsfg";
            this.sgsfg.Size = new System.Drawing.Size(65, 24);
            this.sgsfg.TabIndex = 1;
            this.sgsfg.Text = "Name";
            // 
            // dsgsdfg
            // 
            this.dsgsdfg.AutoSize = true;
            this.dsgsdfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dsgsdfg.Location = new System.Drawing.Point(7, 17);
            this.dsgsdfg.Name = "dsgsdfg";
            this.dsgsdfg.Size = new System.Drawing.Size(27, 24);
            this.dsgsdfg.TabIndex = 0;
            this.dsgsdfg.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewStudents);
            this.panel1.Location = new System.Drawing.Point(10, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 297);
            this.panel1.TabIndex = 9;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 7);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(781, 279);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(351, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTb.Location = new System.Drawing.Point(419, 58);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(219, 29);
            this.emailTb.TabIndex = 9;
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 549);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudents";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indexTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label sfdasdf;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label sgsfg;
        private System.Windows.Forms.Label dsgsdfg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}