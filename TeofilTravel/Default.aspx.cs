using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeofilTravel
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string ime = TextBox1.Text;
            string email = TextBox2.Text;
            if (ime != "" && email != "")
            {
                Insert(connection, ime, email);
                Label3.Text = "";
            }
            else
            {
                Label3.Text = "MORATE UNETI SVE PODATKE!";
            }
        }
        void Insert(SqlConnection connection, string ime, string email)
        {
            try
            {
                connection.Open();
                SqlParameter p = new SqlParameter();
                SqlParameter p1 = new SqlParameter();

                p.Value = ime;
                p1.Value = email;

                p.ParameterName = "@ime";
                p1.ParameterName = "@email";

                string upit = "INSERT INTO Newsletter (Ime,Email) VALUES(@ime,@email)";
                SqlCommand command = new SqlCommand(upit, connection);

                command.Parameters.Add(p);
                command.Parameters.Add(p1);

                command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                Label3.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
                TextBox1.Text = TextBox2.Text = "";
            }
        }
    }
}