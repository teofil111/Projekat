using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeofilTravel.Admin
{
    public partial class Upravljanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                Select(connection);
                SelectGradovi(connection);
                connection.Open();
                if (!IsPostBack)
                {
                    string upit = "SELECT SifraGrada FROM Gradovi";
                    SqlCommand command = new SqlCommand(upit, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DropDownList1.Items.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
        //SELECT HOTEL
        void Select(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string upit = "SELECT * FROM Hoteli";
                SqlCommand command = new SqlCommand(upit, connection);
                SqlDataReader reader = command.ExecuteReader();

                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            catch (Exception x)
            {
                Label2.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }
        //SELECT GRAD
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

        //INSERT U HOTELI
        void Insert(SqlConnection connection, string naziv, int grad, int zvezdice, string opis)
        {
            try
            {
                connection.Open();
                SqlParameter p = new SqlParameter();
                SqlParameter p1 = new SqlParameter();
                SqlParameter p2 = new SqlParameter();
                SqlParameter p3 = new SqlParameter();

                p.Value = naziv;
                p1.Value = grad;
                p2.Value = zvezdice;
                p3.Value = opis;

                p.ParameterName = "@naziv";
                p1.ParameterName = "@grad";
                p2.ParameterName = "@zvezdice";
                p3.ParameterName = "@opis";

                string upit = "INSERT INTO Hoteli (Naziv,Grad,Zvezdice,Opis) VALUES(@naziv,@grad,@zvezdice,@opis)";
                SqlCommand command = new SqlCommand(upit, connection);

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
                TextBox3.Text = TextBox4.Text = TextBox5.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=RELJA;Initial Catalog=mare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string naziv = TextBox3.Text;
            int grad = int.Parse(DropDownList1.SelectedValue);
            int zvezdice = int.Parse(TextBox4.Text);
            string opis = TextBox5.Text;

            try
            {
                if (TextBox3.Text!="" && TextBox4.Text!="" && TextBox5.Text!="" && DropDownList1.SelectedValue!="")
                {
                    Insert(connection, naziv, grad, zvezdice, opis);
                } 
                else
                {
                    Label10.Text = "MORATE UNETI SVE PODATKE";
                }
            }
            catch (Exception x)
            {
                Label10.Text = "ERROR";
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
            finally
            {
                Select(connection);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}