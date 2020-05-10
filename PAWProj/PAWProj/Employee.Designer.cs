namespace PAWProj
{
    partial class Employee
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
            this.getEmptySets = new System.Windows.Forms.Button();
            this.getReservationsButton = new System.Windows.Forms.Button();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getEmptySets
            // 
            this.getEmptySets.Location = new System.Drawing.Point(18, 342);
            this.getEmptySets.Name = "getEmptySets";
            this.getEmptySets.Size = new System.Drawing.Size(140, 70);
            this.getEmptySets.TabIndex = 7;
            this.getEmptySets.Text = "FreeSets";
            this.getEmptySets.UseVisualStyleBackColor = true;
            // 
            // getReservationsButton
            // 
            this.getReservationsButton.Location = new System.Drawing.Point(18, 209);
            this.getReservationsButton.Name = "getReservationsButton";
            this.getReservationsButton.Size = new System.Drawing.Size(140, 70);
            this.getReservationsButton.TabIndex = 6;
            this.getReservationsButton.Text = "Reservation";
            this.getReservationsButton.UseVisualStyleBackColor = true;
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(18, 78);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(140, 70);
            this.getOrdersButton.TabIndex = 5;
            this.getOrdersButton.Text = "Orders";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello, Chef!";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getEmptySets);
            this.Controls.Add(this.getReservationsButton);
            this.Controls.Add(this.getOrdersButton);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getEmptySets;
        private System.Windows.Forms.Button getReservationsButton;
        private System.Windows.Forms.Button getOrdersButton;
        private System.Windows.Forms.Label label1;
    }
}