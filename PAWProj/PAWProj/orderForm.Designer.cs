namespace PAWProj
{
    partial class orderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.menuBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.orderInputP = new System.Windows.Forms.Panel();
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.foodChoice = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.orderInputP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(1, -1);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(196, 170);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuBtn.UseMnemonic = false;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("placeOrderBtn.Image")));
            this.placeOrderBtn.Location = new System.Drawing.Point(1, 175);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(196, 170);
            this.placeOrderBtn.TabIndex = 1;
            this.placeOrderBtn.Text = "Place an order";
            this.placeOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.placeOrderBtn.UseMnemonic = false;
            this.placeOrderBtn.UseVisualStyleBackColor = false;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // orderInputP
            // 
            this.orderInputP.Controls.Add(this.comboBox1);
            this.orderInputP.Controls.Add(this.textBox10);
            this.orderInputP.Controls.Add(this.textBox11);
            this.orderInputP.Controls.Add(this.textBox8);
            this.orderInputP.Controls.Add(this.textBox9);
            this.orderInputP.Controls.Add(this.textBox1);
            this.orderInputP.Controls.Add(this.textBox5);
            this.orderInputP.Controls.Add(this.textBox6);
            this.orderInputP.Controls.Add(this.textBox7);
            this.orderInputP.Controls.Add(this.textBox3);
            this.orderInputP.Controls.Add(this.textBox4);
            this.orderInputP.Controls.Add(this.foodChoice);
            this.orderInputP.Controls.Add(this.textBox2);
            this.orderInputP.Controls.Add(this.submitOrderBtn);
            this.orderInputP.Location = new System.Drawing.Point(203, -1);
            this.orderInputP.Name = "orderInputP";
            this.orderInputP.Size = new System.Drawing.Size(721, 701);
            this.orderInputP.TabIndex = 2;
            this.orderInputP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.submitOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitOrderBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitOrderBtn.ForeColor = System.Drawing.Color.White;
            this.submitOrderBtn.Location = new System.Drawing.Point(208, 596);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(177, 44);
            this.submitOrderBtn.TabIndex = 0;
            this.submitOrderBtn.Text = "Order Now";
            this.submitOrderBtn.UseVisualStyleBackColor = false;
            this.submitOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(208, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 25);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Anything to drink?";
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(208, 172);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(340, 1);
            this.textBox4.TabIndex = 12;
            // 
            // foodChoice
            // 
            this.foodChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.foodChoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.foodChoice.ForeColor = System.Drawing.Color.White;
            this.foodChoice.Location = new System.Drawing.Point(208, 48);
            this.foodChoice.Name = "foodChoice";
            this.foodChoice.Size = new System.Drawing.Size(340, 25);
            this.foodChoice.TabIndex = 11;
            this.foodChoice.Text = "Enter your choice";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(208, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 1);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(208, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 25);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Anything to drink?";
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(208, 360);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 1);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(208, 503);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(340, 25);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Discount Code";
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Location = new System.Drawing.Point(208, 534);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 1);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(208, 421);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(340, 25);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "Enter an address";
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Location = new System.Drawing.Point(208, 452);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(340, 1);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "Enter an address";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(208, 239);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(340, 25);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "ASAP or specified time?";
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox11.Location = new System.Drawing.Point(208, 270);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(340, 1);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "Enter an address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(922, 703);
            this.Controls.Add(this.orderInputP);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.menuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.orderInputP.ResumeLayout(false);
            this.orderInputP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Panel orderInputP;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox foodChoice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}