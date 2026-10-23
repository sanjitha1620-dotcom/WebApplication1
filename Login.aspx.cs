using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
         protected void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = WebConfigurationManager
                .ConnectionStrings["MyConnection"]
                .ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT COUNT(*) FROM Users " +
                    "WHERE Username=@username AND Password=@password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@username", txtUsername.Text);

                cmd.Parameters.AddWithValue(
                    "@password", txtPassword.Text);

                con.Open();

                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    lblMessage.Text = "Login Successful!";
                }
                else
                {
                    lblMessage.Text = "Invalid username or password!";
                }
            }
        }
    }
    }



