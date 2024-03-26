namespace WindowsForms_SQL_course_work
{
    partial class MainForm
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
            this.bookID = new System.Windows.Forms.TextBox();
            this.bookList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.booksAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.ordersCheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(182, 325);
            this.bookID.MaxLength = 30;
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(145, 20);
            this.bookID.TabIndex = 23;
            // 
            // bookList
            // 
            this.bookList.BackgroundColor = System.Drawing.Color.Thistle;
            this.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookList.Location = new System.Drawing.Point(12, 12);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(776, 291);
            this.bookList.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(215, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID Книги";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // booksAmount
            // 
            this.booksAmount.Location = new System.Drawing.Point(361, 325);
            this.booksAmount.Name = "booksAmount";
            this.booksAmount.Size = new System.Drawing.Size(120, 20);
            this.booksAmount.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(368, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Количество";
            // 
            // buyButton
            // 
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.buyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buyButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.buyButton.Location = new System.Drawing.Point(487, 312);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(145, 39);
            this.buyButton.TabIndex = 26;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // ordersCheckButton
            // 
            this.ordersCheckButton.FlatAppearance.BorderSize = 0;
            this.ordersCheckButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.ordersCheckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ordersCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersCheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ordersCheckButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ordersCheckButton.Location = new System.Drawing.Point(252, 383);
            this.ordersCheckButton.Name = "ordersCheckButton";
            this.ordersCheckButton.Size = new System.Drawing.Size(215, 39);
            this.ordersCheckButton.TabIndex = 27;
            this.ordersCheckButton.Text = "Посмотреть заказы";
            this.ordersCheckButton.UseVisualStyleBackColor = true;
            this.ordersCheckButton.Click += new System.EventHandler(this.ordersCheckButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersCheckButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksAmount);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bookList);
            this.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown booksAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Button ordersCheckButton;
    }
}