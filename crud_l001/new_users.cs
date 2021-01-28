using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_l001
{
    public partial class new_users : UserControl
    {
        string nameserver = "";
        public new_users(string nameservers)
        {
            nameserver = nameservers;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void news_Click(object sender, EventArgs e)
        {
            string logins = login.Text;
            string passwords = password.Text;
            string namess = names.Text;

            if (logins != "" && passwords != "" && namess != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data source=" + nameserver + ";Initial Catalog=crud_l001;Integrated Security=True;"))
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT users (login, password, name) VALUES ('" + logins + "','" + passwords + "','" + namess + "')";
                        cmd.ExecuteScalar();
                        con.Close();

                        full_users uc = new full_users(nameserver);
                        Point t = new Point(0, 0);
                        uc.Location = t;
                        Application.OpenForms[0].Controls.Add(uc);
                        this.Parent.Controls.Remove(this);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                }
            }
        }

        private void otmena_Click(object sender, EventArgs e)
        {
            full_users uc = new full_users(nameserver);
            Point t = new Point(0, 0);
            uc.Location = t;
            Application.OpenForms[0].Controls.Add(uc);
            this.Parent.Controls.Remove(this);
        }
    }
}
