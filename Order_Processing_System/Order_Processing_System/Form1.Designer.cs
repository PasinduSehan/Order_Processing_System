
namespace Order_Processing_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3_name = new System.Windows.Forms.TextBox();
            this.textBox4_telephone = new System.Windows.Forms.TextBox();
            this.textBox5_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1_qty = new System.Windows.Forms.NumericUpDown();
            this.comboBox1_Iteam_name = new System.Windows.Forms.ComboBox();
            this.textBox6_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_orderId = new System.Windows.Forms.TextBox();
            this.button1_add_to_order = new System.Windows.Forms.Button();
            this.button2_remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1_date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2_Total = new System.Windows.Forms.TextBox();
            this.button3_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4_save = new System.Windows.Forms.Button();
            this.Order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.textBox3_name);
            this.groupBox1.Controls.Add(this.textBox4_telephone);
            this.groupBox1.Controls.Add(this.textBox5_Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(73, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Data";
            // 
            // textBox3_name
            // 
            this.textBox3_name.Location = new System.Drawing.Point(138, 50);
            this.textBox3_name.Name = "textBox3_name";
            this.textBox3_name.Size = new System.Drawing.Size(202, 22);
            this.textBox3_name.TabIndex = 20;
            // 
            // textBox4_telephone
            // 
            this.textBox4_telephone.Location = new System.Drawing.Point(138, 101);
            this.textBox4_telephone.Name = "textBox4_telephone";
            this.textBox4_telephone.Size = new System.Drawing.Size(202, 22);
            this.textBox4_telephone.TabIndex = 21;
            // 
            // textBox5_Email
            // 
            this.textBox5_Email.Location = new System.Drawing.Point(138, 154);
            this.textBox5_Email.Name = "textBox5_Email";
            this.textBox5_Email.Size = new System.Drawing.Size(202, 22);
            this.textBox5_Email.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Yellow;
            this.groupBox2.Controls.Add(this.numericUpDown1_qty);
            this.groupBox2.Controls.Add(this.comboBox1_Iteam_name);
            this.groupBox2.Controls.Add(this.textBox6_Price);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(73, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 211);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iteam Data";
            // 
            // numericUpDown1_qty
            // 
            this.numericUpDown1_qty.Location = new System.Drawing.Point(138, 160);
            this.numericUpDown1_qty.Name = "numericUpDown1_qty";
            this.numericUpDown1_qty.Size = new System.Drawing.Size(202, 22);
            this.numericUpDown1_qty.TabIndex = 21;
            this.numericUpDown1_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1_Iteam_name
            // 
            this.comboBox1_Iteam_name.FormattingEnabled = true;
            this.comboBox1_Iteam_name.Items.AddRange(new object[] {
            "Book",
            "Pencil",
            "Pen",
            "Bottle",
            "Stiker",
            "Eresar"});
            this.comboBox1_Iteam_name.Location = new System.Drawing.Point(138, 46);
            this.comboBox1_Iteam_name.Name = "comboBox1_Iteam_name";
            this.comboBox1_Iteam_name.Size = new System.Drawing.Size(202, 24);
            this.comboBox1_Iteam_name.TabIndex = 20;
            this.comboBox1_Iteam_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Iteam_name_SelectedIndexChanged);
            // 
            // textBox6_Price
            // 
            this.textBox6_Price.Location = new System.Drawing.Point(138, 100);
            this.textBox6_Price.Name = "textBox6_Price";
            this.textBox6_Price.Size = new System.Drawing.Size(202, 22);
            this.textBox6_Price.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Iteam Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Id";
            // 
            // textBox1_orderId
            // 
            this.textBox1_orderId.Location = new System.Drawing.Point(165, 64);
            this.textBox1_orderId.Name = "textBox1_orderId";
            this.textBox1_orderId.Size = new System.Drawing.Size(179, 22);
            this.textBox1_orderId.TabIndex = 3;
            this.textBox1_orderId.TextChanged += new System.EventHandler(this.textBox1_orderId_TextChanged);
            // 
            // button1_add_to_order
            // 
            this.button1_add_to_order.BackColor = System.Drawing.Color.Black;
            this.button1_add_to_order.ForeColor = System.Drawing.Color.White;
            this.button1_add_to_order.Location = new System.Drawing.Point(125, 636);
            this.button1_add_to_order.Name = "button1_add_to_order";
            this.button1_add_to_order.Size = new System.Drawing.Size(135, 35);
            this.button1_add_to_order.TabIndex = 4;
            this.button1_add_to_order.Text = "Add To Order";
            this.button1_add_to_order.UseVisualStyleBackColor = false;
            this.button1_add_to_order.Click += new System.EventHandler(this.button1_add_to_order_Click);
            // 
            // button2_remove
            // 
            this.button2_remove.BackColor = System.Drawing.Color.Black;
            this.button2_remove.ForeColor = System.Drawing.Color.White;
            this.button2_remove.Location = new System.Drawing.Point(316, 636);
            this.button2_remove.Name = "button2_remove";
            this.button2_remove.Size = new System.Drawing.Size(87, 35);
            this.button2_remove.TabIndex = 5;
            this.button2_remove.Text = "Remove";
            this.button2_remove.UseVisualStyleBackColor = false;
            this.button2_remove.Click += new System.EventHandler(this.button2_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1_date
            // 
            this.dateTimePicker1_date.Location = new System.Drawing.Point(684, 64);
            this.dateTimePicker1_date.Name = "dateTimePicker1_date";
            this.dateTimePicker1_date.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1_date.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_id,
            this.Price,
            this.Qty,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(562, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 211);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // textBox2_Total
            // 
            this.textBox2_Total.Location = new System.Drawing.Point(710, 378);
            this.textBox2_Total.Name = "textBox2_Total";
            this.textBox2_Total.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Total.TabIndex = 10;
            // 
            // button3_print
            // 
            this.button3_print.BackColor = System.Drawing.Color.Black;
            this.button3_print.ForeColor = System.Drawing.Color.White;
            this.button3_print.Location = new System.Drawing.Point(775, 424);
            this.button3_print.Name = "button3_print";
            this.button3_print.Size = new System.Drawing.Size(95, 35);
            this.button3_print.TabIndex = 11;
            this.button3_print.Text = "Print Total";
            this.button3_print.UseVisualStyleBackColor = false;
            this.button3_print.Click += new System.EventHandler(this.button3_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button4_save
            // 
            this.button4_save.BackColor = System.Drawing.Color.Black;
            this.button4_save.ForeColor = System.Drawing.Color.White;
            this.button4_save.Location = new System.Drawing.Point(634, 424);
            this.button4_save.Name = "button4_save";
            this.button4_save.Size = new System.Drawing.Size(84, 35);
            this.button4_save.TabIndex = 13;
            this.button4_save.Text = "Save";
            this.button4_save.UseVisualStyleBackColor = false;
            this.button4_save.Click += new System.EventHandler(this.button4_save_Click);
            // 
            // Order_id
            // 
            this.Order_id.HeaderText = "Order_id";
            this.Order_id.Name = "Order_id";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 697);
            this.Controls.Add(this.button4_save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3_print);
            this.Controls.Add(this.textBox2_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_remove);
            this.Controls.Add(this.button1_add_to_order);
            this.Controls.Add(this.textBox1_orderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iteam Order ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_orderId;
        private System.Windows.Forms.Button button1_add_to_order;
        private System.Windows.Forms.Button button2_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_Total;
        private System.Windows.Forms.Button button3_print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4_save;
        private System.Windows.Forms.TextBox textBox3_name;
        private System.Windows.Forms.TextBox textBox4_telephone;
        private System.Windows.Forms.TextBox textBox5_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1_qty;
        private System.Windows.Forms.ComboBox comboBox1_Iteam_name;
        private System.Windows.Forms.TextBox textBox6_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

