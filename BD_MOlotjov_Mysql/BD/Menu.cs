using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BD_MOlotjov_Mysql.BD
{
    public partial class Menu : Form
    {
        Point LastPoint;
        public Menu(Register register)
        {
            InitializeComponent();
            listfio.Text = register.User.FIONepolnoe;
            ReverseLabel(listfio);
            comboBox1.Items.Add("Пользователи");
            comboBox1.Items.Add("Мероприятия");
            comboBox1.Items.Add("Артист");
            comboBox1.Items.Add("Сооружение");
            comboBox1.Items.Add("Организатор");
            comboBox1.Items.Add("Тип");
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            ONE.Visible = false;
            TWO.Visible = false;
            THREE.Visible = false;
            FOUR.Visible = false;
            FIVE.Visible = false;
            SIX.Visible = false;
            SEVEN.Visible = false;
            ONEBOX.Visible = false;
            TWOBOX.Visible = false;
            THREEBOX.Visible = false;
            FOURBOX.Visible = false;
            CREATE.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            FULL1.Visible = false;
            FULL2.Visible = false;
            FULL3.Visible = false;
            FULL4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem as String == "Пользователи")
            {
                FilDT.DataSource = Database.DR();
                FilDT.Columns[0].Visible = true;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = true;
                SIX.Visible = true;
                SEVEN.Visible = true;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Мероприятия")
            {
                FilDT.DataSource = Database.VB();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = true;
                THREEBOX.Visible = true;
                FOURBOX.Visible = true;
                TWO.Visible = true;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = true;
                FULL3.Visible = true;
                FULL4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Text = "Тип";
                label3.Text = "Организатор";
                label4.Text = "Артист";
                label5.Text = "Сооружение";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tipbuild", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Tipbuild";
                ONEBOX.ValueMember = "ID_Tipbuild";
                ////////////////////////////////////////////
                MySqlConnection con2 = new MySqlConnection
              ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From organizator", con2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TWOBOX.DataSource = dt2;
                TWOBOX.DisplayMember = "FIO";
                TWOBOX.ValueMember = "ID_Organizator";
                ////////////////////////////////////////////
                MySqlConnection con3 = new MySqlConnection
                ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da3 = new MySqlDataAdapter
                    ("Select * From artist", con3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                THREEBOX.DataSource = dt3;
                THREEBOX.DisplayMember = "FIO";
                THREEBOX.ValueMember = "ID_Artist";
                ////////////////////////////////////////////
                MySqlConnection con4 = new MySqlConnection
               ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da4 = new MySqlDataAdapter
                    ("Select * From build", con4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                FOURBOX.DataSource = dt4;
                FOURBOX.DisplayMember = "Naim";
                FOURBOX.ValueMember = "ID_Build";
            }
            if (comboBox1.SelectedItem as String == "Артист")
            {
                FilDT.DataSource = Database.BN();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

            }
            if (comboBox1.SelectedItem as String == "Сооружение")
            {
                FilDT.DataSource = Database.BM();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Text = "Тип";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tipbuild", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Tipbuild";
                ONEBOX.ValueMember = "ID_Tipbuild";
            }
            if (comboBox1.SelectedItem as String == "Организатор")
            {
                FilDT.DataSource = Database.ORGANIZATOR();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String  == "Тип")
            {
                FilDT.DataSource = Database.TIP();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void ReverseLabel(Label label)
        {
            int witdh = label.Width;
            label.Location = new Point(label.Location.X - witdh, label.Location.Y);
            label.TextAlign = ContentAlignment.MiddleRight;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {

            LastPoint = new Point(e.X, e.Y);
        }
        int idd;
        private void SECDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
            if (comboBox1.Text == "Пользователи")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From sec " +
                    "where ID_SEC=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
                FOUR.Text = dt1.Rows[0][4].ToString();
                FIVE.Text = dt1.Rows[0][5].ToString();
                SIX.Text = dt1.Rows[0][6].ToString();
                SEVEN.Text = dt1.Rows[0][7].ToString();
            }
            if (comboBox1.Text == "Мероприятия")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From meropriatie " +
                    "where meropriatie.ID_Meropriatie=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWOBOX.SelectedValue = dt1.Rows[0][3].ToString();
                THREEBOX.SelectedValue = dt1.Rows[0][4].ToString();
                FOURBOX.SelectedValue = dt1.Rows[0][5].ToString();
                TWO.Text = dt1.Rows[0][6].ToString();
            }
            if (comboBox1.Text == "Артист")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From artist " +
                    "where artist.ID_Artist=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();


            }
            
            if (comboBox1.Text == "Сооружение")
            {

                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From build " +
                    "where build.ID_Build=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWO.Text = dt1.Rows[0][3].ToString();
                THREE.Text = dt1.Rows[0][4].ToString();
            }
            if (comboBox1.Text == "Организатор")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From organizator " +
                    "where organizator.ID_Organizator=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();


            }
            if (comboBox1.Text == "Тип")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server= 127.0.0.1;database=filormonia; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tipbuild " +
                    "where tipbuild.ID_Tipbuild=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }    

        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"Insert into security.sec(FIO,FIONepolnoe,Dolg,Login,Password,level,Mesto)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}', '{FOUR.Text}', '{FIVE.Text}', {SIX.Text}, '{SEVEN.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Мероприятия")
            {
                var q = $"Insert into filormonia.meropriatie(Naim,ID_Tip,ID_Organizator,ID_Artist,ID_Build,Price)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}', '{TWOBOX.SelectedValue}', '{THREEBOX.SelectedValue}', '{FOURBOX.SelectedValue}', '{TWO.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Артист")
            {
                var q = $"Insert into filormonia.artist(FIO,Kontakt)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BN();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Сооружение")
            {
                var q = $"Insert into filormonia.build(Naim,ID_Tipbuild,Address,Kolvo)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}', '{TWO.Text}', '{THREE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BM();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Организатор")
            {
                var q = $"Insert into filormonia.organizator(FIO,Kontakt)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.ORGANIZATOR();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"Insert into filormonia.tipbuild(Tipbuild)\n" +
                    $"values ('{ONE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"UPDATE `sec` SET `FIO`='{ONE.Text}',`FIONepolnoe`='{TWO.Text}',`Dolg`='{THREE.Text}',`Login`='{FOUR.Text}',`Password`='{FIVE.Text}',`level`='{SIX.Text}',`Mesto`='{SEVEN.Text}' WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Мероприятия")
            {
               var q = $"UPDATE `meropriatie` SET `Naim`='{ONE.Text}',`ID_Tip`='{ONEBOX.SelectedValue}',`ID_Organizator`='{TWOBOX.SelectedValue}',`ID_Artist`='{THREEBOX.SelectedValue}',`ID_Build`='{FOURBOX.SelectedValue}', `Price`='{TWO.Text}' WHERE ID_Meropriatie = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Артист")
            {

                var q = $"UPDATE `artist` SET `FIO`='{ONE.Text}',`Kontakt`='{TWO.Text}' WHERE ID_Artist = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BN();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Сооружение")
            {
                var q = $"UPDATE `build` SET `Naim`='{ONE.Text}',`ID_Tipbuild`='{ONEBOX.SelectedValue}',`Address`='{TWO.Text}',`Kolvo`='{THREE.Text}' WHERE ID_Build = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BM();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Организатор")
            {
                var q = $"UPDATE `organizator` SET `FIO`='{ONE.Text}',`Kontakt`='{TWO.Text}' WHERE ID_Organizator = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.ORGANIZATOR();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"UPDATE `tipbuild` SET `Tipbuild`='{ONE.Text}' WHERE ID_Tipbuild = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"DELETE FROM `sec` WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.DR();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Мероприятия")
            {
                var q = $"DELETE FROM `meropriatie` WHERE ID_Meropriatie = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.VB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Артист")
            {

                var q = $"DELETE FROM `artist` WHERE ID_Artist = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BN();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Сооружение")
            {
                var q = $"DELETE FROM `build` WHERE ID_Build = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.BM();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Организатор")
            {
                var q = $"DELETE FROM `organizator` WHERE ID_Organizator = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.ORGANIZATOR();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"DELETE FROM `tipbuild` WHERE ID_Tipbuild = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
        }
    }
}