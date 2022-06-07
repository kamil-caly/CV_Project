
namespace library_man
{
    partial class AddBooks
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
            this.dataGridAddBooks = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.authorTb = new System.Windows.Forms.TextBox();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.idTb = new System.Windows.Forms.TextBox();
            this.sfdasdf = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.sgsfg = new System.Windows.Forms.Label();
            this.dsgsdfg = new System.Windows.Forms.Label();
            this.clearB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAddBooks
            // 
            this.dataGridAddBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridAddBooks.Name = "dataGridAddBooks";
            this.dataGridAddBooks.Size = new System.Drawing.Size(764, 324);
            this.dataGridAddBooks.TabIndex = 0;
            this.dataGridAddBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAddBooks_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridAddBooks);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 352);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.priceTb);
            this.panel2.Controls.Add(this.authorTb);
            this.panel2.Controls.Add(this.titleTb);
            this.panel2.Controls.Add(this.idTb);
            this.panel2.Controls.Add(this.sfdasdf);
            this.panel2.Controls.Add(this.sdf);
            this.panel2.Controls.Add(this.sgsfg);
            this.panel2.Controls.Add(this.dsgsdfg);
            this.panel2.Location = new System.Drawing.Point(12, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 162);
            this.panel2.TabIndex = 3;
            // 
            // priceTb
            // 
            this.priceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceTb.Location = new System.Drawing.Point(425, 73);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(100, 29);
            this.priceTb.TabIndex = 7;
            // 
            // authorTb
            // 
            this.authorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorTb.Location = new System.Drawing.Point(298, 73);
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(100, 29);
            this.authorTb.TabIndex = 6;
            // 
            // titleTb
            // 
            this.titleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTb.Location = new System.Drawing.Point(169, 73);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(100, 29);
            this.titleTb.TabIndex = 5;
            // 
            // idTb
            // 
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTb.Location = new System.Drawing.Point(34, 73);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(100, 29);
            this.idTb.TabIndex = 4;
            // 
            // sfdasdf
            // 
            this.sfdasdf.AutoSize = true;
            this.sfdasdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sfdasdf.Location = new System.Drawing.Point(445, 20);
            this.sfdasdf.Name = "sfdasdf";
            this.sfdasdf.Size = new System.Drawing.Size(58, 24);
            this.sfdasdf.TabIndex = 3;
            this.sfdasdf.Text = "Price";
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sdf.Location = new System.Drawing.Point(312, 20);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(72, 24);
            this.sdf.TabIndex = 2;
            this.sdf.Text = "Author";
            // 
            // sgsfg
            // 
            this.sgsfg.AutoSize = true;
            this.sgsfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sgsfg.Location = new System.Drawing.Point(196, 20);
            this.sgsfg.Name = "sgsfg";
            this.sgsfg.Size = new System.Drawing.Size(50, 24);
            this.sgsfg.TabIndex = 1;
            this.sgsfg.Text = "Title";
            // 
            // dsgsdfg
            // 
            this.dsgsdfg.AutoSize = true;
            this.dsgsdfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dsgsdfg.Location = new System.Drawing.Point(67, 20);
            this.dsgsdfg.Name = "dsgsdfg";
            this.dsgsdfg.Size = new System.Drawing.Size(27, 24);
            this.dsgsdfg.TabIndex = 0;
            this.dsgsdfg.Text = "Id";
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearB.Location = new System.Drawing.Point(618, 470);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(158, 41);
            this.clearB.TabIndex = 8;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // addB
            // 
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addB.Location = new System.Drawing.Point(618, 401);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(158, 41);
            this.addB.TabIndex = 9;
            this.addB.Text = "Add Book";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 557);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAddBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.TextBox authorTb;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label sfdasdf;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label sgsfg;
        private System.Windows.Forms.Label dsgsdfg;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button addB;
    }
}