using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_l001

    
{
    public partial class full_users : UserControl
    {
        string nameserver = "";
        public full_users(string nameservers)
        {
            nameserver = nameservers;
            InitializeComponent();
        }
        void zapoln_table()
        {
            using (SqlConnection con = new SqlConnection(@"Data source="+nameserver+";Initial Catalog=crud_l001;Integrated Security=True;"))
            {
                try
                {
                    data_users.Rows.Clear();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    //заполнение данных
                    cmd.CommandText = "select * from [users]";

                    SqlDataReader reader = cmd.ExecuteReader();
                    int j = 0;
                    while (reader.Read())
                    {
                        data_users.Rows.Add();
                        data_users.Rows[j].Cells[0].Value = Convert.ToString(String.Format("{0}", reader[0]));
                        data_users.Rows[j].Cells[1].Value = Convert.ToString(String.Format("{0}", reader[1]));
                        data_users.Rows[j].Cells[2].Value = Convert.ToString(String.Format("{0}", reader[2]));
                        data_users.Rows[j].Cells[3].Value = Convert.ToString(String.Format("{0}", reader[3]));
                        // data_users.Rows[j].Cells[4].Value = "Изменить";
                        j++;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                finally
                {
                    con.Close();
                }



            }
        }
        private void full_users_Load(object sender, EventArgs e)
        {
            zapoln_table();
        }

        private void data_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //изменить
            if (e.ColumnIndex == 4)
            {
                String id = Convert.ToString(data_users.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                updates uc = new updates(nameserver,id);
                Point t = new Point(0, 0);
                uc.Location = t;
                Application.OpenForms[0].Controls.Add(uc);
                this.Parent.Controls.Remove(this);
            }
            //удалить
            if (e.ColumnIndex == 5)
            {
                String id = Convert.ToString(data_users.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                using (SqlConnection con = new SqlConnection(@"Data source=" + nameserver + ";Initial Catalog=crud_l001;Integrated Security=True;"))
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "DELETE users where id="+id;
                        cmd.ExecuteScalar();
                        con.Close();
                        zapoln_table();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                }

            }
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            new_users uc = new new_users(nameserver);
            Point t = new Point(0, 0);
            uc.Location = t;
            Application.OpenForms[0].Controls.Add(uc);
            this.Parent.Controls.Remove(this);
        }

        private void data_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //информация о пользователе
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                String id = Convert.ToString(data_users.Rows[Convert.ToInt32(e.RowIndex.ToString())].Cells[0].Value);

                read_users uc = new read_users(nameserver, id);
                Point t = new Point(0, 0);
                uc.Location = t;
                Application.OpenForms[0].Controls.Add(uc);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
