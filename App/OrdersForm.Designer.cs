﻿namespace WindowsForms_SQL_course_work
{
    partial class OrdersForm
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
            this.ordersList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersList
            // 
            this.ordersList.BackgroundColor = System.Drawing.Color.Thistle;
            this.ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersList.Location = new System.Drawing.Point(12, 12);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(776, 426);
            this.ordersList.TabIndex = 9;
            this.ordersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersList_CellContentClick);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersList);
            this.Name = "OrdersForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersList;
    }
}