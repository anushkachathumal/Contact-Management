using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace econ.econnClasess
{
    class connClass
    {
        public int contactid {get; set;}
        public String firstname { get; set;}
        public String lastname { get; set; }
        public String contact { get; set;  }
        public String address { get; set; }
        public String gender { get; set; }

        static String myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //select data

        public DataTable Select()
        {

            //database connection

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql ="Select * FROM contb1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        //insert data 

        public bool Insert (connClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO contb1(fname,lname,contact,address,gender) VALUES (@firstname,@lastname,@contact,@address,@gender)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@firstname", c.firstname );
                cmd.Parameters.AddWithValue("@lastname", c.lastname);
                cmd.Parameters.AddWithValue("@contact", c.contact);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@gender", c.gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }



            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return isSuccess; 

        }




            }
}
