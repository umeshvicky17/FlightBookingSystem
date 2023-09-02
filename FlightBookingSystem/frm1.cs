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
    public partial class frm1 : Form
    {
        //open connection from class
        Myconnection cnn = new Myconnection();
        OleDbConnection con=null;
        OleDbDataAdapter adp=null;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int r = 0;

        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection open
            TextBox1.Enabled = false;
            try
            {
                con = cnn.opencnn();
                MessageBox.Show("Press addnew for flight entry");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // save method1 by using substitutor
            try
            {
                OleDbCommand myinsert = new OleDbCommand();
                myinsert.Connection = con;
                myinsert.CommandType = CommandType.Text;
                myinsert.CommandText = "INSERT INTO flightmaster  VALUES (" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox4.Text + "','" + TextBox5.Text + "' ," + TextBox6.Text + " ," + TextBox7.Text + ", " + TextBox8.Text + ") ";
                myinsert.ExecuteNonQuery();
                myinsert.Dispose();
                MessageBox.Show("inserted");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("invalid query");
                MessageBox.Show(ex.Message);
            }
        }

     

        private void button14_Click(object sender, EventArgs e)
        {
            //save by using paramter with query
            try
            {
                OleDbCommand myinsert = new OleDbCommand();
                myinsert.Connection = con;
                myinsert.CommandType = CommandType.Text;
                //myinsert.CommandText = "insert into flightmaster (flightcode) values (@t1)";
               //myinsert.CommandText = "insert into flightmaster (flightcode, fname, source, destination, dtime, seats, ecofare, exefare) values (@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8)";
               myinsert.CommandText = "insert into flightmaster values (@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8)";
               myinsert.Parameters.AddWithValue("@t1", TextBox1.Text);
               myinsert.Parameters.AddWithValue("@t2", TextBox2.Text);
               myinsert.Parameters.AddWithValue("@t3", TextBox3.Text);
               myinsert.Parameters.AddWithValue("@t4", TextBox4.Text);
               myinsert.Parameters.AddWithValue("@t5", TextBox5.Text);
               myinsert.Parameters.AddWithValue("@t6", TextBox6.Text);
               myinsert.Parameters.AddWithValue("@t7", TextBox7.Text);
               myinsert.Parameters.AddWithValue("@t8", TextBox8.Text);
               myinsert.ExecuteNonQuery();
               MessageBox.Show("record inserted");
               myinsert.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message +"invalid query");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // next record navigation
            ds.Clear();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from flightmaster", con);
            adp.Fill(ds, "flightmaster");
            dt = ds.Tables["flightmaster"];
            if (r > dt.Rows.Count - 1)
            {
                MessageBox.Show("last record");
                r = dt.Rows.Count - 1;
            }
            else
            {
                showrec();
                r = r + 1;
            }
        }

        public void clear()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
         }

        public void showrec()
        {
            TextBox1.Text = Convert.ToString(dt.Rows[r][0]);
            TextBox2.Text = Convert.ToString(dt.Rows[r][1]);
            TextBox3.Text = Convert.ToString(dt.Rows[r][2]);
            TextBox4.Text = Convert.ToString(dt.Rows[r][3]);
            TextBox5.Text = Convert.ToString(dt.Rows[r][4]);
            TextBox6.Text = Convert.ToString(dt.Rows[r][5]);
            TextBox7.Text = Convert.ToString(dt.Rows[r][6]);
            TextBox8.Text = Convert.ToString(dt.Rows[r][7]);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // previous record navigation
            ds.Clear();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from flightmaster", con);
            adp.Fill(ds, "flightmaster");
            dt = ds.Tables["flightmaster"];
            if (r < 0)
            {
                MessageBox.Show("First record");
                r = 0;
            }
            else
            {
                showrec();
                r = r - 1;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // first record display
            r = 0;
            showrec();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // last record display
            r = dt.Rows.Count - 1;
            showrec();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            //addnew
            //auto number creation
            TextBox2.Focus();
            clear();
            ds.Clear();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from flightmaster", con);
            adp.Fill(ds, "flightmaster");

            dt = ds.Tables["flightmaster"];
            int n = dt.Rows.Count;
            if (n == 0)
                TextBox1.Text = "1";
            else
            {
                int no = Convert.ToInt16(dt.Rows[n - 1][0]);
                TextBox1.Text = Convert.ToString(no + 1);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            OleDbCommand mysearch = new OleDbCommand();
            mysearch.Connection = con;
            mysearch.CommandText = "select * from flightmaster where flightcode = " + textBox9.Text + "";
            OleDbDataReader dr = mysearch.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                TextBox1.Text = dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
                TextBox5.Text = dr[4].ToString();
                TextBox6.Text = dr[5].ToString();
                TextBox7.Text = dr[6].ToString();
                TextBox8.Text = dr[7].ToString();
                
            }
            else
                MessageBox.Show("not found");
            dr.Close();
         }

        private void Button8_Click(object sender, EventArgs e)
        {
        //update record
        OleDbCommand myupdate = new OleDbCommand();
        try
        {
            myupdate.Connection = con;
            myupdate.CommandType = CommandType.Text;
            myupdate.CommandText = "update flightmaster set dtime = '" + TextBox5.Text + "', ecofare = " + TextBox7.Text + ", exefare = " + TextBox8.Text + "  where flightcode = "+ TextBox1.Text + "";
            myupdate.ExecuteNonQuery();
            MessageBox.Show("record changed");
        }
        catch(OleDbException ex)
        {
            MessageBox.Show("invalid query");
        }
        myupdate.Dispose();
       }

        private void Button7_Click(object sender, EventArgs e)
        {
        //delete record
        OleDbCommand mydel = new OleDbCommand();
        try
        {
            mydel.Connection = con;
            mydel.CommandType = CommandType.Text;
            mydel.CommandText = "delete from flightmaster where flightcode = " + TextBox1.Text + " ";
            mydel.ExecuteNonQuery();
            MessageBox.Show("record deleted");
            clear();
            mydel.Dispose();
        }
        catch(OleDbException ex)
        {
            MessageBox.Show("invalid query");
        }
      }

        private void Button10_Click(object sender, EventArgs e)
        {
         ds.Clear();
        OleDbDataAdapter adp = new OleDbDataAdapter("select * from flightmaster", con);
        adp.Fill(ds, "flightmaster");
        //to display table details
        DataGrid1.DataSource = ds.Tables["flightmaster"];
        DataGrid1.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }


        private void TextBox7_Leave(object sender, EventArgs e)
        {
            Double t=Convert.ToDouble(TextBox7.Text)  + Convert.ToDouble(TextBox7.Text) * .30;
            TextBox8.Text = t.ToString();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            //delete all record
            OleDbCommand mydel = new OleDbCommand();
            try
            {
                mydel.Connection = con;
                mydel.CommandType = CommandType.Text;
                mydel.CommandText = "delete from flightmaster";
                mydel.ExecuteNonQuery();
                MessageBox.Show("All record deleted");
                mydel.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("invalid query");
            }
        }

       

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
    
