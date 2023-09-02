using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FlightBookingSystem
{
    public partial class Form2 : Form
    {
        //database driver for access
        OleDbConnection con;
        Myconnection cnn = new Myconnection();
        OleDbDataAdapter adp1, adp2;
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        int r = 0;
        //Sample change

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = System.DateTime.Today;
            TextBox8.Text = Convert.ToString(d);
            //open connection
            try
            {
                con = cnn.opencnn();
                MessageBox.Show("success");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("invalid connection string");
            }
            //seatno logic
            adp2 = new OleDbDataAdapter("select * from booking", con);
            adp2.Fill(ds, "tab2");
            dt2 = ds.Tables["tab2"];
            r = dt2.Rows.Count - 1;
            if (dt2.Rows.Count == 0)
                TextBox1.Text = "1";
            else
            {
                int n = Convert.ToInt16(dt2.Rows[r][2]);
                TextBox1.Text = Convert.ToString(n + 1);
            }
                //to fill combo using connected
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from flightmaster";
                OleDbDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ComboBox1.Items.Add(dr[0]);
                }
                dr.Close();
         }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to display flight details according to flight code from flightmaster table
            int s;
            s = Convert.ToInt16(ComboBox1.Text);
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from flightmaster where flightcode = " + s + "";
            dr = cmd.ExecuteReader();
            dr.Read();
            TextBox2.Text = Convert.ToString(dr[1]);
            TextBox3.Text = Convert.ToString(dr[2]);
            TextBox4.Text = Convert.ToString(dr[3]);
            TextBox5.Text = Convert.ToString(dr[5]);
            dr.Close();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         ds.Clear();
         int s;
         s = Convert.ToInt16(ComboBox1.Text);
         adp1 = new OleDbDataAdapter("select * from flightmaster where  flightcode = " + s + "", con);
         adp1.Fill(ds, "tab1");
         dt1 = ds.Tables["tab1"];
         if (ComboBox2.SelectedIndex == 0) 
            TextBox7.Text = Convert.ToString(dt1.Rows[0][6]);
            else
            if(ComboBox2.SelectedIndex == 1)
            TextBox7.Text = Convert.ToString(dt1.Rows[0][7]);
         }

        private void Button1_Click(object sender, EventArgs e)
        {
         int tno;
         tno = Convert.ToInt16(TextBox1.Text);
        //to save into booking
        OleDbCommand myinsert = new OleDbCommand();
        myinsert.Connection = con;
        myinsert.CommandText = "INSERT INTO booking  (flightcode,fdate,seatno,fclass,passenger,fare) VALUES   (" + ComboBox1.SelectedItem + ", '" + TextBox8.Text + "', " + TextBox1.Text + ",'" + ComboBox2.SelectedItem + "' , '" + TextBox6.Text + "', " + TextBox7.Text + ")";
        myinsert.ExecuteNonQuery();
        MessageBox.Show("booking saved");
        //update master
        OleDbCommand myupdate =  new OleDbCommand();
        myupdate.Connection = con;
        myupdate.CommandText = "Update flightmaster set  seats =  seats - 1 where flightcode = " + ComboBox1.SelectedItem + " ";
        myupdate.ExecuteNonQuery();
        MessageBox.Show("seats updated");
        TextBox1.Text = Convert.ToString(tno + 1);//to increase seatno
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         ds.Clear();
        OleDbDataAdapter adp1 = new OleDbDataAdapter("select * from flightmaster", con);
        OleDbDataAdapter adp2 = new OleDbDataAdapter("select * from booking", con);
        adp1.Fill(ds, "tab1");
        adp2.Fill(ds, "tab2");
        DataGrid1.DataSource = ds.Tables["tab1"];
        DataGrid2.DataSource = ds.Tables["tab2"];
        DataGrid1.Show();
        DataGrid2.Show();
        }

    }
}


