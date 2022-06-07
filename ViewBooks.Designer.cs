
namespace library_man
{
    partial class ViewBooks
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
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
            this.deleteB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.clearB = new System.Windows.Forms.Button();
            this.refreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 7);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(781, 219);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewBooks);
            this.panel1.Location = new System.Drawing.Point(12, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 234);
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
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 162);
            this.panel2.TabIndex = 2;
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
            // deleteB
            // 
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteB.Location = new System.Drawing.Point(623, 14);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(158, 41);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "Delete Book";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // updateB
            // 
            this.updateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateB.Location = new System.Drawing.Point(623, 73);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(158, 41);
            this.updateB.TabIndex = 4;
            this.updateB.Text = "Update Book";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(210, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Book";
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTb.Location = new System.Drawing.Point(377, 191);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(140, 29);
            this.searchTb.TabIndex = 6;
            this.searchTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearB.Location = new System.Drawing.Point(623, 132);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(158, 41);
            this.clearB.TabIndex = 7;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // refreshB
            // 
            this.refreshB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshB.Location = new System.Drawing.Point(33, 186);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(158, 41);
            this.refreshB.TabIndex = 8;
            this.refreshB.Text = "Refresh";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 488);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
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
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button refreshB;
    }
}