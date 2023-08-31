using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;

namespace SWE_Project
{
    public partial class dashboard : Form
    {
        string user_name;
        public dashboard(string user)
        {
            InitializeComponent();
            user_name = user;
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;

            }
            slide_pic.ImageLocation = string.Format(@"Images\{0}.png", imageNumber);
            imageNumber++;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Watchlist_btn_Click(object sender, EventArgs e)
        {
            //3awzin ngib count w nhoto fl for loop
            //3awzin ngib swr el aflam
            string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(distinct(film_id)) from watchlist where user_name=:username";

            cmd.Parameters.Add("username", user_name);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select title, film_photo from film,watchlist where film.film_id=watchlist.film_id and watchlist.user_name=:username";
            cmd2.Parameters.Add("username", user_name);
            OracleDataReader dr = cmd2.ExecuteReader();

            int top = 10;
            int left = 10;
            int cnt = 0;
            int x = 10;

            for (int i = 0; i < count; i++)
            {

                Button button = new Button();
                button.Height = 230;
                button.Width = 190;
                button.Left = left;
                button.Top = top;
                //button.Margin = new Padding();
                watchlist_pl.Controls.Add(button);
                if (dr.Read())
                {
                    byte[] photoData = (byte[])dr["film_photo"];
                    MemoryStream ms = new MemoryStream(photoData);
                    button.BackgroundImage = Image.FromStream(ms);

                }
                button.Name = dr["title"].ToString();
                //button.BackgroundImage = Image.FromFile(@"E:\SWE proj\SWE proj3\photos\Userpng.png");
                button.BackgroundImageLayout = ImageLayout.Stretch;
                
                button.Font = new Font(button.Font.FontFamily, 1);
                left += button.Width + 10;
                cnt++;
                if (cnt == 4)
                {
                    left = 10;
                    x += 10;
                    cnt = 0;
                    top += button.Height + x;
                }
                button.Click += show_trailer;
                watchlist_pl.BringToFront();

            }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select count(*) from film";
            cmd2.CommandType = CommandType.Text;
            int films = int.Parse(cmd2.ExecuteScalar().ToString());


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from film";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
       
           
            Browse_pl.BringToFront();
            int top = 50;
            int left = 50;
            int cnt = 0;
            int x = 10;

            for (int i = 0; i < films; i++)
            {

                Button button = new Button();
                button.Height = 230;
                button.Width = 190;
                button.Left = left;
                button.Top = top;
                //button.Margin = new Padding();
                movies_pl.Controls.Add(button);
                if (dr.Read())
                {
                    byte[] photoData = (byte[]) dr["film_photo"];
                    MemoryStream ms = new MemoryStream(photoData);
                    button.BackgroundImage = Image.FromStream(ms);

                }
                button.Name = dr["title"].ToString();
                //button.BackgroundImage = Image.FromFile(@"E:\SWE proj\SWE proj3\photos\Userpng.png");
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Text = dr["film_category"].ToString();
                button.Font = new Font(button.Font.FontFamily, 1);
                left += button.Width + 40;
                cnt++;
                if (cnt == 3)
                {
                    left = 10;
                    x += 10;
                    cnt = 0;
                    top += button.Height + x;
                }
                button.Click += show_trailer;

            }
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "select distinct film_category from Film";
            cmd3.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd3.ExecuteReader();
                categories_cmb.Items.Add("All");
            while (dr2.Read())
            {
                categories_cmb.Items.Add(dr2[0]);
            }

        }

        private void show_trailer(object sender, EventArgs e)
        {
            string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select film_id from film where title=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":name", (sender as Button).Name.ToString());
            int film_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            Functions f = new Functions();
            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.Connection = conn;
            //cmd2.CommandText = "select avg(rate) from rate where film_id=:id";
            //cmd2.CommandType = CommandType.Text;
            //cmd2.Parameters.Add(":id", film_id);
            int rate=f.avg_rate(film_id.ToString());
           
            
            

            
            OracleCommand cmd5 = new OracleCommand();
            cmd5.Connection = conn;
            cmd5.CommandText = "select film_video from film where title=:name";
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.Add(":name", (sender as Button).Name.ToString());
            OracleDataReader dr5 =cmd5.ExecuteReader();

            if (dr5.Read())
            {
                byte[] videoData = (byte[])dr5["film_video"];

                FileStream fileStream = new FileStream("temp_video.mp4", FileMode.Create);
                fileStream.Write(videoData, 0, videoData.Length);
                fileStream.Close();
            }


            OracleCommand cmd6 = new OracleCommand();
            cmd6.Connection = conn;
            cmd6.CommandText = "select description from film where title=:name";
            cmd6.CommandType = CommandType.Text;
            cmd6.Parameters.Add(":name", (sender as Button).Name.ToString());
            string describe = cmd6.ExecuteScalar().ToString();



            OracleCommand cmd_id = new OracleCommand();
            cmd_id.Connection = conn;

            cmd_id.CommandText = "select film_id from Film where title=:filmname";
            cmd_id.Parameters.Add("FilmName", (sender as Button).Name.ToString());

            int fil_id =Convert.ToInt32( cmd_id.ExecuteScalar().ToString());

          

            
                OracleCommand cmd_ActorNames = new OracleCommand();
                cmd_ActorNames.Connection = conn;

                cmd_ActorNames.CommandText = "get_actor_name";
                cmd_ActorNames.CommandType = CommandType.StoredProcedure;
                cmd_ActorNames.Parameters.Add("id", fil_id);
                cmd_ActorNames.Parameters.Add("CRS", OracleDbType.RefCursor, ParameterDirection.Output);

                 OracleDataReader dr = cmd_ActorNames.ExecuteReader();

                Trailer1 t = new Trailer1(rate.ToString(), user_name, (sender as Button).Name.ToString(), "temp_video.mp4", describe,dr);
            t.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            foreach (Control c in movies_pl.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.ToString().ToLower() == search_txt.Text.ToString().ToLower())
                    {
                        c.Visible = true;
                    }
                    else if (search_txt.Text.ToString() == "")
                    {
                        c.Visible = true;
                    }
                    else
                    {
                        c.Visible = false;
                    }
                }

            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
           

            //foreach (Control c in browse_pl.Controls)
            //{
            //    if (c is Button)
            //    {
            //        if (c.Name.ToString() == search_txt.Text.ToString())
            //        {
            //            c.Visible = true;
            //        }
            //        else if (search_txt.Text.ToString() == "")
            //        {
            //            c.Visible = true;
            //        }
            //        else
            //        {
            //            c.Visible = false;
            //        }
            //    }

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void categories_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {




            foreach (Control c in movies_pl.Controls)
            {
                if (c is Button)
                {
                    if (c.Text.ToString().ToLower() == categories_cmb.Text.ToString().ToLower())
                    {
                        c.Visible = true;
                    }
                    else if (categories_cmb.Text.ToString() == "All")
                    {
                        c.Visible = true;
                    }
                    else
                    {
                        c.Visible = false;
                    }
                }

            }
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            Report r =new Report(user_name);
            r.Show();
            this.Close();
        }
    }

}
