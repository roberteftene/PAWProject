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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addWaiterBtn = new System.Windows.Forms.Button();
            this.exportWaiterBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.importCVBtn = new System.Windows.Forms.Button();
            this.waiterInputP = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.experienceInput = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.clock = new System.Windows.Forms.ToolStripLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.waiterInputP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 707);
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
            this.textBox1.Location = new System.Drawing.Point(-14, 701);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1896, 58);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label2.Location = new System.Drawing.Point(15, 55);
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
            this.addWaiterBtn.Location = new System.Drawing.Point(-3, 109);
            this.addWaiterBtn.Name = "addWaiterBtn";
            this.addWaiterBtn.Size = new System.Drawing.Size(263, 117);
            this.addWaiterBtn.TabIndex = 20;
            this.addWaiterBtn.Text = "Add waiter";
            this.addWaiterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addWaiterBtn.UseVisualStyleBackColor = false;
            this.addWaiterBtn.Click += new System.EventHandler(this.addWaiterBtn_Click);
            // 
            // exportWaiterBtn
            // 
            this.exportWaiterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.exportWaiterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.exportWaiterBtn.FlatAppearance.BorderSize = 0;
            this.exportWaiterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.exportWaiterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.exportWaiterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportWaiterBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportWaiterBtn.ForeColor = System.Drawing.Color.White;
            this.exportWaiterBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportWaiterBtn.Image")));
            this.exportWaiterBtn.Location = new System.Drawing.Point(-3, 232);
            this.exportWaiterBtn.Name = "exportWaiterBtn";
            this.exportWaiterBtn.Size = new System.Drawing.Size(263, 144);
            this.exportWaiterBtn.TabIndex = 21;
            this.exportWaiterBtn.Text = "View Waiter CV";
            this.exportWaiterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exportWaiterBtn.UseVisualStyleBackColor = false;
            this.exportWaiterBtn.Click += new System.EventHandler(this.viewOrdersBtn_Click);
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
            this.logoutBtn.Location = new System.Drawing.Point(1077, 701);
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
            this.button4.Location = new System.Drawing.Point(1240, 701);
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
            this.btn_maximize.Location = new System.Drawing.Point(1189, 701);
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
            this.btn_minimize.Location = new System.Drawing.Point(1131, 701);
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
            // importCVBtn
            // 
            this.importCVBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.importCVBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.importCVBtn.FlatAppearance.BorderSize = 0;
            this.importCVBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.importCVBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.importCVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCVBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCVBtn.ForeColor = System.Drawing.Color.White;
            this.importCVBtn.Image = ((System.Drawing.Image)(resources.GetObject("importCVBtn.Image")));
            this.importCVBtn.Location = new System.Drawing.Point(-3, 382);
            this.importCVBtn.Name = "importCVBtn";
            this.importCVBtn.Size = new System.Drawing.Size(259, 145);
            this.importCVBtn.TabIndex = 22;
            this.importCVBtn.Text = "Import Waiter CV";
            this.importCVBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.importCVBtn.UseVisualStyleBackColor = false;
            this.importCVBtn.Click += new System.EventHandler(this.importCVBtn_Click);
            // 
            // waiterInputP
            // 
            this.waiterInputP.Controls.Add(this.textBox3);
            this.waiterInputP.Controls.Add(this.experienceInput);
            this.waiterInputP.Controls.Add(this.textBox5);
            this.waiterInputP.Controls.Add(this.textBox4);
            this.waiterInputP.Controls.Add(this.ageInput);
            this.waiterInputP.Controls.Add(this.textBox6);
            this.waiterInputP.Controls.Add(this.text);
            this.waiterInputP.Controls.Add(this.lNameInput);
            this.waiterInputP.Controls.Add(this.textBox7);
            this.waiterInputP.Controls.Add(this.textBox8);
            this.waiterInputP.Controls.Add(this.fNameInput);
            this.waiterInputP.Controls.Add(this.textBox9);
            this.waiterInputP.Controls.Add(this.button1);
            this.waiterInputP.Location = new System.Drawing.Point(563, 93);
            this.waiterInputP.Name = "waiterInputP";
            this.waiterInputP.Size = new System.Drawing.Size(415, 522);
            this.waiterInputP.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(33, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 25);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "Enter the experience";
            // 
            // experienceInput
            // 
            this.experienceInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.experienceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.experienceInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.experienceInput.ForeColor = System.Drawing.Color.White;
            this.experienceInput.Location = new System.Drawing.Point(33, 332);
            this.experienceInput.Name = "experienceInput";
            this.experienceInput.Size = new System.Drawing.Size(340, 25);
            this.experienceInput.TabIndex = 28;
            this.experienceInput.Validating += new System.ComponentModel.CancelEventHandler(this.experienceInput_Validating);
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(33, 363);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 1);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Enter an address";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(33, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 25);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "Enter the age";
            // 
            // ageInput
            // 
            this.ageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageInput.ForeColor = System.Drawing.Color.White;
            this.ageInput.Location = new System.Drawing.Point(33, 247);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(340, 25);
            this.ageInput.TabIndex = 25;
            this.ageInput.Validating += new System.ComponentModel.CancelEventHandler(this.ageInput_Validating);
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Location = new System.Drawing.Point(33, 278);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(340, 1);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Enter an address";
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(33, 134);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(185, 25);
            this.text.TabIndex = 23;
            this.text.Text = "Enter last name";
            // 
            // lNameInput
            // 
            this.lNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.lNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lNameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNameInput.ForeColor = System.Drawing.Color.White;
            this.lNameInput.Location = new System.Drawing.Point(33, 165);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(340, 25);
            this.lNameInput.TabIndex = 22;
            this.lNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.lNameInput_Validating);
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Location = new System.Drawing.Point(33, 196);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 1);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "Enter an address";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(33, 43);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(185, 25);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "Enter first name";
            // 
            // fNameInput
            // 
            this.fNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.fNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fNameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fNameInput.ForeColor = System.Drawing.Color.White;
            this.fNameInput.Location = new System.Drawing.Point(33, 74);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(340, 25);
            this.fNameInput.TabIndex = 19;
            this.fNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.fNameInput_Validating);
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Location = new System.Drawing.Point(33, 105);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(340, 1);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "Enter an address";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Waiter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-3, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 144);
            this.button2.TabIndex = 29;
            this.button2.Text = "Export Waiter CV";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Age,
            this.Experience});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(313, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 97);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 126;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 126;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // Experience
            // 
            this.Experience.Text = "Experience";
            this.Experience.Width = 177;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.clock});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1282, 40);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(184, 37);
            this.toolStripLabel1.Text = "Hello, Chef!";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCVToolStripMenuItem,
            this.exportCVToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 37);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // importCVToolStripMenuItem
            // 
            this.importCVToolStripMenuItem.Name = "importCVToolStripMenuItem";
            this.importCVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.importCVToolStripMenuItem.Text = "Import CV";
            // 
            // exportCVToolStripMenuItem
            // 
            this.exportCVToolStripMenuItem.Name = "exportCVToolStripMenuItem";
            this.exportCVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exportCVToolStripMenuItem.Text = "Export CV";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 37);
            this.toolStripButton1.Text = "Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // clock
            // 
            this.clock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(65, 37);
            this.clock.Text = "00:00:00";
            this.clock.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.waiterInputP);
            this.Controls.Add(this.importCVBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.exportWaiterBtn);
            this.Controls.Add(this.addWaiterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Employee_KeyDown);
            this.waiterInputP.ResumeLayout(false);
            this.waiterInputP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addWaiterBtn;
        private System.Windows.Forms.Button exportWaiterBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button importCVBtn;
        private System.Windows.Forms.Panel waiterInputP;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox experienceInput;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Experience;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem importCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel clock;
        private System.Windows.Forms.Timer timer2;
    }
}