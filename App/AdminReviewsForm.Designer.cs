namespace WindowsForms_SQL_course_work
{
    partial class AdminReviewsForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.reviewID = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.reviewsList.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(106, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID отзыва";
            // 
            // reviewID
            // 
            this.reviewID.Location = new System.Drawing.Point(70, 343);
            this.reviewID.MaxLength = 30;
            this.reviewID.Name = "reviewID";
            this.reviewID.Size = new System.Drawing.Size(145, 20);
            this.reviewID.TabIndex = 24;
            this.reviewID.TextChanged += new System.EventHandler(this.reviewID_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.deleteButton.Location = new System.Drawing.Point(274, 331);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(145, 39);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AdminReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.reviewID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reviewsList);
            this.Name = "AdminReviewsForm";
            this.Text = "AdminReviewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.reviewsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewsList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox reviewID;
        private System.Windows.Forms.Button deleteButton;
    }
}