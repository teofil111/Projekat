using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;

namespace TeofilTravel
{
    public partial class Ponuda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                Select(connection);
                SelectGradovi(connection);
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }
        void Select(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string upit = "SELECT * FROM Hoteli";
                SqlCommand command= new SqlCommand(upit, connection);
                SqlDataReader reader = command.ExecuteReader();

                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            catch (Exception x)
            {
                Label1.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
        void SelectGradovi(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string upit = "SELECT * FROM Gradovi";
                SqlCommand command = new SqlCommand(upit, connection);
                SqlDataReader reader = command.ExecuteReader();

                GridView2.DataSource = reader;
                GridView2.DataBind();
            }
            catch (Exception x)
            {
                Label1.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}