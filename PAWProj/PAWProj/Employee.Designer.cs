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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addWaiterBtn = new System.Windows.Forms.Button();
            this.viewOrdersBtn = new System.Windows.Forms.Button();
            this.viewReservationsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.waiterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello, Chef!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(-3, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1896, 58);
            this.textBox1.TabIndex = 14;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(147, 59);
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.time.Size = new System.Drawing.Size(86, 23);
            this.time.TabIndex = 15;
            this.time.Text = "00:00:00";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Location = new System.Drawing.Point(-3, -2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(263, 851);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addWaiterBtn
            // 
            this.addWaiterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.addWaiterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.addWaiterBtn.FlatAppearance.BorderSize = 0;
            this.addWaiterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.addWaiterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.addWaiterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWaiterBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWaiterBtn.ForeColor = System.Drawing.Color.White;
            this.addWaiterBtn.Image = ((System.Drawing.Image)(resources.GetObject("addWaiterBtn.Image")));
            this.addWaiterBtn.Location = new System.Drawing.Point(-3, 113);
            this.addWaiterBtn.Name = "addWaiterBtn";
            this.addWaiterBtn.Size = new System.Drawing.Size(263, 150);
            this.addWaiterBtn.TabIndex = 20;
            this.addWaiterBtn.Text = "Add waiter";
            this.addWaiterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addWaiterBtn.UseVisualStyleBackColor = false;
            this.addWaiterBtn.Click += new System.EventHandler(this.addWaiterBtn_Click);
            // 
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.viewOrdersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.viewOrdersBtn.FlatAppearance.BorderSize = 0;
            this.viewOrdersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.viewOrdersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.viewOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrdersBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersBtn.ForeColor = System.Drawing.Color.White;
            this.viewOrdersBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewOrdersBtn.Image")));
            this.viewOrdersBtn.Location = new System.Drawing.Point(-3, 269);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.Size = new System.Drawing.Size(263, 150);
            this.viewOrdersBtn.TabIndex = 21;
            this.viewOrdersBtn.Text = "View Orders";
            this.viewOrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewOrdersBtn.UseVisualStyleBackColor = false;
            this.viewOrdersBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
            // 
            // viewReservationsBtn
            // 
            this.viewReservationsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.viewReservationsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.viewReservationsBtn.FlatAppearance.BorderSize = 0;
            this.viewReservationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.viewReservationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.viewReservationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReservationsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationsBtn.ForeColor = System.Drawing.Color.White;
            this.viewReservationsBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewReservationsBtn.Image")));
            this.viewReservationsBtn.Location = new System.Drawing.Point(-3, 425);
            this.viewReservationsBtn.Name = "viewReservationsBtn";
            this.viewReservationsBtn.Size = new System.Drawing.Size(263, 150);
            this.viewReservationsBtn.TabIndex = 22;
            this.viewReservationsBtn.Text = "View Reservations";
            this.viewReservationsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.viewReservationsBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.Yellow;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutBtn.Location = new System.Drawing.Point(1068, 9);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(36, 40);
            this.logoutBtn.TabIndex = 26;
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(1231, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 40);
            this.button4.TabIndex = 25;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_maximize.ForeColor = System.Drawing.Color.Yellow;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_maximize.Location = new System.Drawing.Point(1180, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(36, 40);
            this.btn_maximize.TabIndex = 24;
            this.btn_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_minimize.ForeColor = System.Drawing.Color.Yellow;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_minimize.Location = new System.Drawing.Point(1122, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(36, 40);
            this.btn_minimize.TabIndex = 23;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.time_Click);
            // 
            // waiterPanel
            // 
            this.waiterPanel.Location = new System.Drawing.Point(256, 55);
            this.waiterPanel.Name = "waiterPanel";
            this.waiterPanel.Size = new System.Drawing.Size(1026, 699);
            this.waiterPanel.TabIndex = 27;
            this.waiterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.waiterPanel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.viewReservationsBtn);
            this.Controls.Add(this.viewOrdersBtn);
            this.Controls.Add(this.addWaiterBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addWaiterBtn;
        private System.Windows.Forms.Button viewOrdersBtn;
        private System.Windows.Forms.Button viewReservationsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel waiterPanel;
    }
}