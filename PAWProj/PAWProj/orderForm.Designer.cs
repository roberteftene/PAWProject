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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.orderInputP = new System.Windows.Forms.Panel();
            this.drinkChoice = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuChoice = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.ListView();
            this.foodColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.seeOrder = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.orderInputP.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderInputP
            // 
            this.orderInputP.Controls.Add(this.drinkChoice);
            this.orderInputP.Controls.Add(this.textBox12);
            this.orderInputP.Controls.Add(this.textBox2);
            this.orderInputP.Controls.Add(this.menuChoice);
            this.orderInputP.Controls.Add(this.address);
            this.orderInputP.Controls.Add(this.textBox9);
            this.orderInputP.Controls.Add(this.discount);
            this.orderInputP.Controls.Add(this.textBox7);
            this.orderInputP.Controls.Add(this.submitOrderBtn);
            this.orderInputP.Location = new System.Drawing.Point(344, 14);
            this.orderInputP.Name = "orderInputP";
            this.orderInputP.Size = new System.Drawing.Size(421, 677);
            this.orderInputP.TabIndex = 2;
            this.orderInputP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // drinkChoice
            // 
            this.drinkChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.drinkChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkChoice.ForeColor = System.Drawing.Color.White;
            this.drinkChoice.FormattingEnabled = true;
            this.drinkChoice.Items.AddRange(new object[] {
            "Water",
            "Cola",
            "Beer",
            "OrangeJuice"});
            this.drinkChoice.Location = new System.Drawing.Point(33, 188);
            this.drinkChoice.Name = "drinkChoice";
            this.drinkChoice.Size = new System.Drawing.Size(340, 31);
            this.drinkChoice.TabIndex = 24;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(33, 157);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(340, 25);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "Something to drink?";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(33, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 25);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Select your choice";
            // 
            // menuChoice
            // 
            this.menuChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.menuChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuChoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChoice.ForeColor = System.Drawing.Color.White;
            this.menuChoice.FormattingEnabled = true;
            this.menuChoice.Items.AddRange(new object[] {
            "Chicken Burger",
            "Pizza",
            "Soup",
            "Donuts"});
            this.menuChoice.Location = new System.Drawing.Point(33, 88);
            this.menuChoice.Name = "menuChoice";
            this.menuChoice.Size = new System.Drawing.Size(340, 31);
            this.menuChoice.TabIndex = 22;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(33, 255);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(340, 25);
            this.address.TabIndex = 19;
            this.address.Text = "Enter an address";
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Location = new System.Drawing.Point(33, 286);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(340, 1);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "Enter an address";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discount.ForeColor = System.Drawing.Color.White;
            this.discount.Location = new System.Drawing.Point(33, 337);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(340, 25);
            this.discount.TabIndex = 15;
            this.discount.Text = "Discount Code";
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Location = new System.Drawing.Point(33, 368);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 1);
            this.textBox7.TabIndex = 14;
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(94)))), ((int)(((byte)(113)))));
            this.submitOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitOrderBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitOrderBtn.ForeColor = System.Drawing.Color.White;
            this.submitOrderBtn.Location = new System.Drawing.Point(33, 422);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(177, 44);
            this.submitOrderBtn.TabIndex = 0;
            this.submitOrderBtn.Text = "Order Now";
            this.submitOrderBtn.UseVisualStyleBackColor = false;
            this.submitOrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderListView
            // 
            this.orderListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.orderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodColumn,
            this.drinkColumn,
            this.addressColumn,
            this.discountColumn});
            this.orderListView.ContextMenuStrip = this.contextMenuStrip1;
            this.orderListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderListView.ForeColor = System.Drawing.Color.White;
            this.orderListView.FullRowSelect = true;
            this.orderListView.HideSelection = false;
            this.orderListView.Location = new System.Drawing.Point(218, -1);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(670, 135);
            this.orderListView.TabIndex = 4;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.SelectedIndexChanged += new System.EventHandler(this.orderListView_SelectedIndexChanged);
            // 
            // foodColumn
            // 
            this.foodColumn.Text = "Food";
            this.foodColumn.Width = 109;
            // 
            // drinkColumn
            // 
            this.drinkColumn.Text = "Drink";
            this.drinkColumn.Width = 114;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.Width = 148;
            // 
            // discountColumn
            // 
            this.discountColumn.Text = "Discount";
            this.discountColumn.Width = 189;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.deleteOrderToolStripMenuItem.Text = "Delete Order";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
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
            // seeOrder
            // 
            this.seeOrder.FlatAppearance.BorderSize = 0;
            this.seeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeOrder.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seeOrder.ForeColor = System.Drawing.Color.White;
            this.seeOrder.Image = ((System.Drawing.Image)(resources.GetObject("seeOrder.Image")));
            this.seeOrder.Location = new System.Drawing.Point(1, 351);
            this.seeOrder.Name = "seeOrder";
            this.seeOrder.Size = new System.Drawing.Size(196, 156);
            this.seeOrder.TabIndex = 3;
            this.seeOrder.Text = "View Order";
            this.seeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.seeOrder.UseMnemonic = false;
            this.seeOrder.UseVisualStyleBackColor = false;
            this.seeOrder.Click += new System.EventHandler(this.seeOrder_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(922, 703);
            this.Controls.Add(this.orderListView);
            this.Controls.Add(this.seeOrder);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.orderInputP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.orderInputP.ResumeLayout(false);
            this.orderInputP.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Panel orderInputP;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox menuChoice;
        private System.Windows.Forms.ComboBox drinkChoice;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader foodColumn;
        private System.Windows.Forms.ColumnHeader drinkColumn;
        private System.Windows.Forms.ColumnHeader addressColumn;
        private System.Windows.Forms.ColumnHeader discountColumn;
        private System.Windows.Forms.Button seeOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}