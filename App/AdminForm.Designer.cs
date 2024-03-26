namespace WindowsForms_SQL_course_work
{
    partial class AdminForm
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
            this.reviewsButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewsButton
            // 
            this.reviewsButton.FlatAppearance.BorderSize = 0;
            this.reviewsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.reviewsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.reviewsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.reviewsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.reviewsButton.Location = new System.Drawing.Point(301, 99);
            this.reviewsButton.Name = "reviewsButton";
            this.reviewsButton.Size = new System.Drawing.Size(190, 39);
            this.reviewsButton.TabIndex = 27;
            this.reviewsButton.Text = "Отзывы";
            this.reviewsButton.UseVisualStyleBackColor = true;
            this.reviewsButton.Click += new System.EventHandler(this.reviewsButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.FlatAppearance.BorderSize = 0;
            this.restockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.restockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.restockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.restockButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.restockButton.Location = new System.Drawing.Point(301, 178);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(190, 39);
            this.restockButton.TabIndex = 28;
            this.restockButton.Text = "Книги";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.customersButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.customersButton.Location = new System.Drawing.Point(301, 262);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(190, 39);
            this.customersButton.TabIndex = 29;
            this.customersButton.Text = "Покупатели";
            this.customersButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.reviewsButton);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reviewsButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button customersButton;
    }
}