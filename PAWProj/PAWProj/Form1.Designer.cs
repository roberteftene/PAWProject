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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientButton = new System.Windows.Forms.Button();
            this.waiterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_usercontrol1 = new PAWProj.employee_usercontrol();
            this.clientlogin_usercontrol1 = new PAWProj.clientlogin_usercontrol();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.clientButton.FlatAppearance.BorderSize = 3;
            this.clientButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.clientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.clientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientButton.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.clientButton.ForeColor = System.Drawing.Color.White;
            this.clientButton.Image = ((System.Drawing.Image)(resources.GetObject("clientButton.Image")));
            this.clientButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clientButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientButton.Location = new System.Drawing.Point(12, 129);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(387, 229);
            this.clientButton.TabIndex = 2;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // waiterButton
            // 
            this.waiterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.waiterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waiterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.waiterButton.FlatAppearance.BorderSize = 3;
            this.waiterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.waiterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.waiterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.waiterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiterButton.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.waiterButton.ForeColor = System.Drawing.Color.White;
            this.waiterButton.Image = ((System.Drawing.Image)(resources.GetObject("waiterButton.Image")));
            this.waiterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.waiterButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.waiterButton.Location = new System.Drawing.Point(12, 385);
            this.waiterButton.Name = "waiterButton";
            this.waiterButton.Size = new System.Drawing.Size(387, 229);
            this.waiterButton.TabIndex = 3;
            this.waiterButton.TabStop = false;
            this.waiterButton.Text = "Employee";
            this.waiterButton.UseVisualStyleBackColor = false;
            this.waiterButton.Click += new System.EventHandler(this.waiterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lucky client or proud employee?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(0, -5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1896, 58);
            this.textBox1.TabIndex = 7;
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
            this.btn_minimize.Location = new System.Drawing.Point(914, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(36, 40);
            this.btn_minimize.TabIndex = 10;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
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
            this.btn_maximize.Location = new System.Drawing.Point(970, 12);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(36, 40);
            this.btn_maximize.TabIndex = 11;
            this.btn_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1031, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 663);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1079, 28);
            this.MainMenu.TabIndex = 14;
            this.MainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // employee_usercontrol1
            // 
            this.employee_usercontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.employee_usercontrol1.Location = new System.Drawing.Point(549, 156);
            this.employee_usercontrol1.Name = "employee_usercontrol1";
            this.employee_usercontrol1.Size = new System.Drawing.Size(417, 339);
            this.employee_usercontrol1.TabIndex = 13;
            this.employee_usercontrol1.Load += new System.EventHandler(this.employee_usercontrol1_Load_1);
            // 
            // clientlogin_usercontrol1
            // 
            this.clientlogin_usercontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.clientlogin_usercontrol1.Location = new System.Drawing.Point(549, 156);
            this.clientlogin_usercontrol1.Name = "clientlogin_usercontrol1";
            this.clientlogin_usercontrol1.Size = new System.Drawing.Size(401, 353);
            this.clientlogin_usercontrol1.TabIndex = 5;
            this.clientlogin_usercontrol1.Load += new System.EventHandler(this.clientlogin_usercontrol1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.employee_usercontrol1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.clientlogin_usercontrol1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waiterButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button waiterButton;
        private System.Windows.Forms.Label label1;
        private clientlogin_usercontrol clientlogin_usercontrol1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button button1;
        private employee_usercontrol employee_usercontrol1;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
    }
}

