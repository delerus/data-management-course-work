namespace WindowsForms_SQL_course_work
{
    partial class AdminBooksForm
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
            this.reviewsList = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.bookPrice = new System.Windows.Forms.TextBox();
            this.bookYear = new System.Windows.Forms.TextBox();
            this.bookAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsList)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewsList
            // 
            this.reviewsList.BackgroundColor = System.Drawing.Color.Thistle;
            this.reviewsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsList.Location = new System.Drawing.Point(12, 12);
            this.reviewsList.Name = "reviewsList";
            this.reviewsList.Size = new System.Drawing.Size(776, 291);
            this.reviewsList.TabIndex = 10;
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(24, 336);
            this.bookID.MaxLength = 30;
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(145, 20);
            this.bookID.TabIndex = 26;
            this.bookID.TextChanged += new System.EventHandler(this.reviewID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(60, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID книги";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(203, 336);
            this.bookAuthor.MaxLength = 30;
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(145, 20);
            this.bookAuthor.TabIndex = 28;
            this.bookAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID автора";
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(24, 396);
            this.bookName.MaxLength = 30;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(145, 20);
            this.bookName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Название";
            // 
            // bookGenre
            // 
            this.bookGenre.Location = new System.Drawing.Point(203, 396);
            this.bookGenre.MaxLength = 30;
            this.bookGenre.Name = "bookGenre";
            this.bookGenre.Size = new System.Drawing.Size(145, 20);
            this.bookGenre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(351, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(411, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(449, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Год";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.deleteButton.Location = new System.Drawing.Point(569, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(145, 39);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.addButton.Location = new System.Drawing.Point(569, 383);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 39);
            this.addButton.TabIndex = 40;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bookPrice
            // 
            this.bookPrice.Location = new System.Drawing.Point(363, 396);
            this.bookPrice.MaxLength = 30;
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(145, 20);
            this.bookPrice.TabIndex = 41;
            // 
            // bookYear
            // 
            this.bookYear.Location = new System.Drawing.Point(442, 336);
            this.bookYear.MaxLength = 30;
            this.bookYear.Name = "bookYear";
            this.bookYear.Size = new System.Drawing.Size(66, 20);
            this.bookYear.TabIndex = 42;
            // 
            // bookAmount
            // 
            this.bookAmount.Location = new System.Drawing.Point(363, 336);
            this.bookAmount.MaxLength = 30;
            this.bookAmount.Name = "bookAmount";
            this.bookAmount.Size = new System.Drawing.Size(66, 20);
            this.bookAmount.TabIndex = 43;
            // 
            // AdminBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookAmount);
            this.Controls.Add(this.bookYear);
            this.Controls.Add(this.bookPrice);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reviewsList);
            this.Name = "AdminBooksForm";
            this.Text = "AdminBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.reviewsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewsList;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bookPrice;
        private System.Windows.Forms.TextBox bookYear;
        private System.Windows.Forms.TextBox bookAmount;
    }
}