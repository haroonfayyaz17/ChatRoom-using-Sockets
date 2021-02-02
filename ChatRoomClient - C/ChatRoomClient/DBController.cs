using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoomClient
{
    class DBController
    {
        SQL_Conn obj;
        SqlConnection con;
        public DBController()
        {
            obj = new SQL_Conn();
            con = obj.con;
        }
        public void insertIP(String ip, String portNo, String name=" ", String directory=" ")
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "insert into IPs values('" + name + "','" + ip + "','" + portNo + "','" + directory + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadIPs(List<String> ipaddress, List<String> ports, List<String> names, List<String> directory)
        {
            //Dictionary<String, String> IPs = new Dictionary<string, string>();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "Select * from IPs";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                ipaddress.Clear();
                ports.Clear();
                names.Clear();
                directory.Clear();
                while (reader.Read())
                {
                    ipaddress.Add(reader["ipaddress"].ToString());
                    ports.Add(reader["portNo"].ToString());
                    names.Add(reader["name"].ToString());
                    directory.Add(reader["directory"].ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateStatus(String ipaddress)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "update IPs set status='assign' where ipaddress='" + ipaddress + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteIP(String IP)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "delete from IPs where ipaddress='"+IP+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
