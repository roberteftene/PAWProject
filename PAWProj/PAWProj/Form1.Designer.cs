namespace PAWProj
{
    partial class Form1
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
            this.clientButton = new System.Windows.Forms.Button();
            this.waiterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientlogin_usercontrol1 = new PAWProj.clientlogin_usercontrol();
            this.employee_usercontrol1 = new PAWProj.employee_usercontrol();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientButton.Location = new System.Drawing.Point(242, 190);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(183, 58);
            this.clientButton.TabIndex = 2;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // waiterButton
            // 
            this.waiterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.waiterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waiterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waiterButton.Location = new System.Drawing.Point(504, 190);
            this.waiterButton.Name = "waiterButton";
            this.waiterButton.Size = new System.Drawing.Size(183, 58);
            this.waiterButton.TabIndex = 3;
            this.waiterButton.TabStop = false;
            this.waiterButton.Text = "Employee";
            this.waiterButton.UseVisualStyleBackColor = false;
            this.waiterButton.Click += new System.EventHandler(this.waiterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(236, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lucky client or proud employee?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientlogin_usercontrol1
            // 
            this.clientlogin_usercontrol1.Location = new System.Drawing.Point(209, 254);
            this.clientlogin_usercontrol1.Name = "clientlogin_usercontrol1";
            this.clientlogin_usercontrol1.Size = new System.Drawing.Size(451, 312);
            this.clientlogin_usercontrol1.TabIndex = 5;
            this.clientlogin_usercontrol1.Load += new System.EventHandler(this.clientlogin_usercontrol1_Load_1);
            // 
            // employee_usercontrol1
            // 
            this.employee_usercontrol1.Location = new System.Drawing.Point(190, 285);
            this.employee_usercontrol1.Name = "employee_usercontrol1";
            this.employee_usercontrol1.Size = new System.Drawing.Size(574, 307);
            this.employee_usercontrol1.TabIndex = 6;
            this.employee_usercontrol1.Load += new System.EventHandler(this.employee_usercontrol1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 691);
            this.Controls.Add(this.employee_usercontrol1);
            this.Controls.Add(this.clientlogin_usercontrol1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waiterButton);
            this.Controls.Add(this.clientButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button waiterButton;
        private System.Windows.Forms.Label label1;
        private clientlogin_usercontrol clientlogin_usercontrol1;
        private employee_usercontrol employee_usercontrol1;
    }
}

