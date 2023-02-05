using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TeofilTravel
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string ime = TextBox1.Text;
            string email = TextBox2.Text;
            string mesto= TextBox3.Text;
            string hotel= TextBox4.Text;
            if (ime!="" && email !="" && mesto !="" && hotel !="")
            {
                Insert(connection, ime, email, mesto, hotel);
                Label5.Text = "";
            }
            else
            {
                Label5.Text = "MORATE UNETI SVE PODATKE!";
            }
        }
        void Insert(SqlConnection connection, string ime, string email, string mesto, string hotel)
        {
            try
            {
                connection.Open();
                SqlParameter p = new SqlParameter();
                SqlParameter p1 = new SqlParameter();
                SqlParameter p2 = new SqlParameter();
                SqlParameter p3 = new SqlParameter();

                p.Value=ime;
                p1.Value=email;
                p2.Value=mesto;
                p3.Value=hotel;

                p.ParameterName = "@ime";
                p1.ParameterName = "@email";
                p2.ParameterName = "@mesto";
                p3.ParameterName = "@hotel";

                string upit = "INSERT INTO Rezervacija (Ime,Email,Mesto,Hotel) VALUES(@ime,@email,@mesto,@hotel)";
                SqlCommand command=new SqlCommand(upit,connection);

                command.Parameters.Add(p);
                command.Parameters.Add(p1);
                command.Parameters.Add(p2);
                command.Parameters.Add(p3);

                command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Label5.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
                TextBox1.Text = TextBox2.Text =TextBox3.Text=TextBox4.Text= "";
            }
        }
    }
}