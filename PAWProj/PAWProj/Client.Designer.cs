namespace PAWProj
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.getReservationsButton = new System.Windows.Forms.Button();
            this.getEmptySets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, Chef!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(338, 111);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(140, 33);
            this.getOrdersButton.TabIndex = 1;
            this.getOrdersButton.Text = "Orders";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // getReservationsButton
            // 
            this.getReservationsButton.Location = new System.Drawing.Point(338, 177);
            this.getReservationsButton.Name = "getReservationsButton";
            this.getReservationsButton.Size = new System.Drawing.Size(140, 33);
            this.getReservationsButton.TabIndex = 2;
            this.getReservationsButton.Text = "Reservation";
            this.getReservationsButton.UseVisualStyleBackColor = true;
            this.getReservationsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // getEmptySets
            // 
            this.getEmptySets.Location = new System.Drawing.Point(338, 242);
            this.getEmptySets.Name = "getEmptySets";
            this.getEmptySets.Size = new System.Drawing.Size(140, 33);
            this.getEmptySets.TabIndex = 3;
            this.getEmptySets.Text = "FreeSets";
            this.getEmptySets.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getEmptySets);
            this.Controls.Add(this.getReservationsButton);
            this.Controls.Add(this.getOrdersButton);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getOrdersButton;
        private System.Windows.Forms.Button getReservationsButton;
        private System.Windows.Forms.Button getEmptySets;
    }
}