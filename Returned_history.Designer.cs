
namespace library_man
{
    partial class Returned_history
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
            this.returnedGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSurnameText = new System.Windows.Forms.TextBox();
            this.studentNameText = new System.Windows.Forms.TextBox();
            this.studentIdText = new System.Windows.Forms.TextBox();
            this.studentIndeksText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.bookIdText = new System.Windows.Forms.TextBox();
            this.issuedDataText = new System.Windows.Forms.TextBox();
            this.returnedDataText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnedGridView
            // 
            this.returnedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedGridView.Location = new System.Drawing.Point(13, 13);
            this.returnedGridView.Name = "returnedGridView";
            this.returnedGridView.Size = new System.Drawing.Size(906, 441);
            this.returnedGridView.TabIndex = 0;
            this.returnedGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnedGridView_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(13, 462);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 51);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(150, 462);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 51);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchText.Location = new System.Drawing.Point(365, 475);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(233, 29);
            this.searchText.TabIndex = 5;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(283, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // studentSurnameText
            // 
            this.studentSurnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentSurnameText.Location = new System.Drawing.Point(188, 655);
            this.studentSurnameText.Name = "studentSurnameText";
            this.studentSurnameText.Size = new System.Drawing.Size(274, 29);
            this.studentSurnameText.TabIndex = 7;
            // 
            // studentNameText
            // 
            this.studentNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameText.Location = new System.Drawing.Point(188, 618);
            this.studentNameText.Name = "studentNameText";
            this.studentNameText.Size = new System.Drawing.Size(274, 29);
            this.studentNameText.TabIndex = 8;
            // 
            // studentIdText
            // 
            this.studentIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentIdText.Location = new System.Drawing.Point(188, 536);
            this.studentIdText.Name = "studentIdText";
            this.studentIdText.Size = new System.Drawing.Size(274, 29);
            this.studentIdText.TabIndex = 9;
            // 
            // studentIndeksText
            // 
            this.studentIndeksText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentIndeksText.Location = new System.Drawing.Point(188, 577);
            this.studentIndeksText.Name = "studentIndeksText";
            this.studentIndeksText.Size = new System.Drawing.Size(274, 29);
            this.studentIndeksText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student_indeks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Student_surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Student_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(473, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Issued_data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(473, 653);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Returned_data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(473, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Book_id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(470, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Book_name";
            // 
            // bookNameText
            // 
            this.bookNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookNameText.Location = new System.Drawing.Point(623, 572);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(274, 29);
            this.bookNameText.TabIndex = 18;
            // 
            // bookIdText
            // 
            this.bookIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookIdText.Location = new System.Drawing.Point(623, 531);
            this.bookIdText.Name = "bookIdText";
            this.bookIdText.Size = new System.Drawing.Size(274, 29);
            this.bookIdText.TabIndex = 17;
            // 
            // issuedDataText
            // 
            this.issuedDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issuedDataText.Location = new System.Drawing.Point(623, 613);
            this.issuedDataText.Name = "issuedDataText";
            this.issuedDataText.Size = new System.Drawing.Size(274, 29);
            this.issuedDataText.TabIndex = 16;
            // 
            // returnedDataText
            // 
            this.returnedDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnedDataText.Location = new System.Drawing.Point(623, 653);
            this.returnedDataText.Name = "returnedDataText";
            this.returnedDataText.Size = new System.Drawing.Size(274, 29);
            this.returnedDataText.TabIndex = 15;
            // 
            // Returned_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 691);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bookNameText);
            this.Controls.Add(this.bookIdText);
            this.Controls.Add(this.issuedDataText);
            this.Controls.Add(this.returnedDataText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentIndeksText);
            this.Controls.Add(this.studentIdText);
            this.Controls.Add(this.studentNameText);
            this.Controls.Add(this.studentSurnameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.returnedGridView);
            this.Name = "Returned_history";
            this.Text = "Returned_history";
            ((System.ComponentModel.ISupportInitialize)(this.returnedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView returnedGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentSurnameText;
        private System.Windows.Forms.TextBox studentNameText;
        private System.Windows.Forms.TextBox studentIdText;
        private System.Windows.Forms.TextBox studentIndeksText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox bookIdText;
        private System.Windows.Forms.TextBox issuedDataText;
        private System.Windows.Forms.TextBox returnedDataText;
    }
}