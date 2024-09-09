using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Order_Processing_System
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_remove_Click(object sender, EventArgs e)
        {



            this.textBox1_orderId.Text = "";
            this.textBox2_Total.Text = "";
            this.textBox3_name.Text = "";
            this.textBox4_telephone.Text = "";
            this.textBox5_Email.Text = "";
            this.textBox6_Price.Text = "";


            this.comboBox1_Iteam_name.Text = "";
            numericUpDown1_qty.Value = 1;



        }

        private void comboBox1_Iteam_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            //connect

            String cs = "Data Source=DESKTOP-EKS8RT5;Initial Catalog=Order_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();//open

            //create a command

            String sql = "SELECT * FROM Iteam WHERE Name = @name";
            SqlCommand com = new SqlCommand(sql,con );
            com.Parameters.AddWithValue(  "@name", this.comboBox1_Iteam_name.Text);


            //access data

            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {

                //get price
                this.textBox1_orderId.Text = dr.GetValue(0).ToString();
                this.textBox6_Price.Text = dr.GetValue(2).ToString();
            }

            //disconnect from the server

            con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_add_to_order_Click(object sender, EventArgs e)
        {
            //add data
            String Order_Id = textBox1_orderId.Text;
            double Price = Convert.ToDouble(textBox6_Price.Text);
            int Qty = Convert.ToInt32(numericUpDown1_qty.Value);


            double total = Price * Qty;//calculate

            //display datagridview

            dataGridView1.Rows.Add(Order_Id, Price, Qty, total);


            //next clear the data in textbox

            this.textBox1_orderId.Text = "";
            this.textBox6_Price.Text = "";
            this.numericUpDown1_qty.Value = 1;
            this.comboBox1_Iteam_name.Text = "";

        }

        private void button3_print_Click(object sender, EventArgs e)
        {


            double Price, Qty;
            double Total=0;



            Price = Convert.ToDouble(this.textBox6_Price.Text);
            Qty = Convert.ToDouble(this.numericUpDown1_qty.Value);

            //total
            //dataGridView1.Rows[3].Count[Total];
            Total = Total + Price * Qty;
            textBox2_Total.Text = Total.ToString();


        }

        private void textBox1_orderId_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_save_Click(object sender, EventArgs e)
        {
            //connect

            String cs = "Data Source=DESKTOP-EKS8RT5;Initial Catalog=Order_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();//open

            //create a command

            String sql = "INSERT INTO customer_details (Name,Telephone,Email,Total) VALUES (@N,@T,@E,@To)";
            SqlCommand com = new SqlCommand(sql, con);

            //insert value in data base
            com.Parameters.AddWithValue("@N", this.textBox3_name.Text);
            com.Parameters.AddWithValue("@T", this.textBox4_telephone.Text);
            com.Parameters.AddWithValue("@E", this.textBox5_Email.Text);
            com.Parameters.AddWithValue("@To", this.textBox2_Total.Text);

            int r = com.ExecuteNonQuery();


            //message box
            MessageBox.Show("Data Add" + r, "Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            con.Close();



        }
    }
}
