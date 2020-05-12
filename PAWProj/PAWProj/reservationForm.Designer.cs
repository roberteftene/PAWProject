namespace PAWProj
{
    partial class reservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationForm));
            this.menuBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reservationContainer = new System.Windows.Forms.Panel();
            this.reservDateInput = new System.Windows.Forms.TextBox();
            this.submitReservationBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.reservTimeInput = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.noPersonInput = new System.Windows.Forms.TextBox();
            this.errorProviderReservation = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoPersonsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reservationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(2, -1);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(234, 156);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Text = "Make a reservation";
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuBtn.UseMnemonic = false;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 156);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete reservation";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservationContainer
            // 
            this.reservationContainer.Controls.Add(this.textBox7);
            this.reservationContainer.Controls.Add(this.textBox8);
            this.reservationContainer.Controls.Add(this.noPersonInput);
            this.reservationContainer.Controls.Add(this.textBox4);
            this.reservationContainer.Controls.Add(this.textBox5);
            this.reservationContainer.Controls.Add(this.reservTimeInput);
            this.reservationContainer.Controls.Add(this.textBox3);
            this.reservationContainer.Controls.Add(this.textBox1);
            this.reservationContainer.Controls.Add(this.reservDateInput);
            this.reservationContainer.Controls.Add(this.submitReservationBtn);
            this.reservationContainer.Location = new System.Drawing.Point(319, 30);
            this.reservationContainer.Name = "reservationContainer";
            this.reservationContainer.Size = new System.Drawing.Size(421, 393);
            this.reservationContainer.TabIndex = 3;
            this.reservationContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.reservationContainer_Paint);
            // 
            // reservDateInput
            // 
            this.reservDateInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.reservDateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservDateInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservDateInput.ForeColor = System.Drawing.Color.White;
            this.reservDateInput.Location = new System.Drawing.Point(33, 57);
            this.reservDateInput.Name = "reservDateInput";
            this.reservDateInput.Size = new System.Drawing.Size(340, 25);
            this.reservDateInput.TabIndex = 0;
            this.reservDateInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // submitReservationBtn
            // 
            this.submitReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.submitReservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitReservationBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitReservationBtn.ForeColor = System.Drawing.Color.White;
            this.submitReservationBtn.Location = new System.Drawing.Point(33, 334);
            this.submitReservationBtn.Name = "submitReservationBtn";
            this.submitReservationBtn.Size = new System.Drawing.Size(177, 44);
            this.submitReservationBtn.TabIndex = 0;
            this.submitReservationBtn.Text = "Reserve Now";
            this.submitReservationBtn.UseVisualStyleBackColor = false;
            this.submitReservationBtn.Click += new System.EventHandler(this.submitReservationBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(33, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 1);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Enter an address";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(33, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 25);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "Enter the date (dd/mm/yyyy)";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(33, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(340, 25);
            this.textBox4.TabIndex = 29;
            this.textBox4.Text = "Enter the time";
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(33, 187);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 1);
            this.textBox5.TabIndex = 28;
            this.textBox5.Text = "Enter an address";
            // 
            // reservTimeInput
            // 
            this.reservTimeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.reservTimeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservTimeInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reservTimeInput.ForeColor = System.Drawing.Color.White;
            this.reservTimeInput.Location = new System.Drawing.Point(33, 156);
            this.reservTimeInput.Name = "reservTimeInput";
            this.reservTimeInput.Size = new System.Drawing.Size(340, 25);
            this.reservTimeInput.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(33, 232);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 25);
            this.textBox7.TabIndex = 32;
            this.textBox7.Text = "Enter the number of persons";
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Location = new System.Drawing.Point(33, 294);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(340, 1);
            this.textBox8.TabIndex = 31;
            this.textBox8.Text = "Enter an address";
            // 
            // noPersonInput
            // 
            this.noPersonInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.noPersonInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noPersonInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noPersonInput.ForeColor = System.Drawing.Color.White;
            this.noPersonInput.Location = new System.Drawing.Point(33, 263);
            this.noPersonInput.Name = "noPersonInput";
            this.noPersonInput.Size = new System.Drawing.Size(340, 25);
            this.noPersonInput.TabIndex = 30;
            // 
            // errorProviderReservation
            // 
            this.errorProviderReservation.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateColumn,
            this.TimeColumn,
            this.NoPersonsColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 351);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 151);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 130;
            // 
            // TimeColumn
            // 
            this.TimeColumn.Text = "Time";
            this.TimeColumn.Width = 105;
            // 
            // NoPersonsColumn
            // 
            this.NoPersonsColumn.Text = "NoPersons";
            this.NoPersonsColumn.Width = 197;
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(789, 911);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.reservationContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "reservationForm";
            this.Text = "reservationForm";
            this.Load += new System.EventHandler(this.reservationForm_Load);
            this.reservationContainer.ResumeLayout(false);
            this.reservationContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel reservationContainer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox reservDateInput;
        private System.Windows.Forms.Button submitReservationBtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox noPersonInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox reservTimeInput;
        private System.Windows.Forms.ErrorProvider errorProviderReservation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader TimeColumn;
        private System.Windows.Forms.ColumnHeader NoPersonsColumn;
    }
}