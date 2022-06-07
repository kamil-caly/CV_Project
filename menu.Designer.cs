
namespace library_man
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBooksDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.completeBooksDetailToolStripMenuItem,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackgroundImage = global::library_man.Properties.Resources.icons8_books_501;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBook,
            this.viewBooks});
            this.booksToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_books_50;
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            // 
            // addNewBook
            // 
            this.addNewBook.Image = global::library_man.Properties.Resources.icons8_add_book_48;
            resources.ApplyResources(this.addNewBook, "addNewBook");
            this.addNewBook.Name = "addNewBook";
            this.addNewBook.Click += new System.EventHandler(this.addNewBook_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Image = global::library_man.Properties.Resources.icons8_view_50;
            resources.ApplyResources(this.viewBooks, "viewBooks");
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.studentToolStripMenuItem.CheckOnClick = true;
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentToolStripMenuItem});
            resources.ApplyResources(this.studentToolStripMenuItem, "studentToolStripMenuItem");
            this.studentToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_student_male_100;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_add_user_male_50;
            resources.ApplyResources(this.addStudentToolStripMenuItem, "addStudentToolStripMenuItem");
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_student_male_50;
            resources.ApplyResources(this.viewStudentToolStripMenuItem, "viewStudentToolStripMenuItem");
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_bookmark_book_64;
            resources.ApplyResources(this.issueBooksToolStripMenuItem, "issueBooksToolStripMenuItem");
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.returnBooksToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_return_book_50;
            resources.ApplyResources(this.returnBooksToolStripMenuItem, "returnBooksToolStripMenuItem");
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // completeBooksDetailToolStripMenuItem
            // 
            this.completeBooksDetailToolStripMenuItem.CheckOnClick = true;
            this.completeBooksDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuedBooksToolStripMenuItem,
            this.returnedBooksToolStripMenuItem});
            this.completeBooksDetailToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_book_philosophy_50;
            resources.ApplyResources(this.completeBooksDetailToolStripMenuItem, "completeBooksDetailToolStripMenuItem");
            this.completeBooksDetailToolStripMenuItem.Name = "completeBooksDetailToolStripMenuItem";
            this.completeBooksDetailToolStripMenuItem.Click += new System.EventHandler(this.completeBooksDetailToolStripMenuItem_Click);
            // 
            // issuedBooksToolStripMenuItem
            // 
            this.issuedBooksToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_bookmark_book_641;
            resources.ApplyResources(this.issuedBooksToolStripMenuItem, "issuedBooksToolStripMenuItem");
            this.issuedBooksToolStripMenuItem.Name = "issuedBooksToolStripMenuItem";
            this.issuedBooksToolStripMenuItem.Click += new System.EventHandler(this.issuedBooksToolStripMenuItem_Click);
            // 
            // returnedBooksToolStripMenuItem
            // 
            this.returnedBooksToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_return_book_501;
            resources.ApplyResources(this.returnedBooksToolStripMenuItem, "returnedBooksToolStripMenuItem");
            this.returnedBooksToolStripMenuItem.Name = "returnedBooksToolStripMenuItem";
            this.returnedBooksToolStripMenuItem.Click += new System.EventHandler(this.returnedBooksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.Image = global::library_man.Properties.Resources.icons8_exit_sign_50;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library_man.Properties.Resources.library;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBook;
        private System.Windows.Forms.ToolStripMenuItem viewBooks;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeBooksDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnedBooksToolStripMenuItem;
    }
}