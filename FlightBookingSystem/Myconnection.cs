using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FlightBookingSystem
{
    class Myconnection
    {
        static String dbpath =  Application.StartupPath + "\\flight.mdb";
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + dbpath + "");

        public OleDbConnection  opencnn()
        {
            try
            {
                con.Open();
                MessageBox.Show("success");
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (con);
       }

        public void closecnn()
        {
            con.Close();
        }
    }
}
