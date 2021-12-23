using MySql.Data.MySqlClient;
using System.Data;


namespace BD_MOlotjov_Mysql
{
    
   static class Database
    {
        static MySqlConnection connectionSec = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
        static MySqlConnection connectionFil = new MySqlConnection("server=127.0.0.1;database=filormonia; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");

        /// <summary>
        /// Sec table
        /// </summary>
        /// <returns></returns>
        public static DataTable DR()
        {
         
            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_SEC`, `FIO` AS `ФИО`, `FIONepolnoe` AS `Сокращено` , `Dolg` AS `Должность` , `Login` AS `Логин`, `Password` AS `Пароль` , `level` AS `Уровень` FROM `sec`"
          , connectionSec);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

        /// <summary>
        /// Мероприятия table
        /// </summary>
        /// <returns></returns>
        public static DataTable VB()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT meropriatie.ID_Meropriatie, meropriatie.Naim AS `Название` , tipbuild.Tipbuild AS `Тип сооружения` , organizator.FIO AS `Организатор` , artist.FIO AS `Артист` , build.Naim AS `Здание`, meropriatie.Price AS `Цена` FROM meropriatie INNER JOIN tipbuild ON meropriatie.ID_Tip = tipbuild.ID_Tipbuild INNER JOIN organizator ON meropriatie.ID_Organizator = organizator.ID_Organizator INNER JOIN artist ON meropriatie.ID_Artist = artist.ID_Artist INNER JOIN build ON meropriatie.ID_Build = build.ID_Build", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable BN()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT artist.ID_Artist , artist.FIO AS `ФИО` , artist.Kontakt AS `Контакты` FROM `artist`", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);
     
            DataTable zx = new DataTable();
           bc.Fill(zx);

            return zx;
        }
        public static DataTable BM()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT build.ID_Build , build.Naim AS `Название` , tipbuild.Tipbuild AS `Тип`,build.Address AS `Адрес`, build.Kolvo AS `Количество` FROM build INNER JOIN tipbuild ON build.ID_Tipbuild = tipbuild.ID_Tipbuild", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable ORGANIZATOR()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT organizator.ID_Organizator, organizator.FIO AS `ФИО` , organizator.Kontakt AS `Контакт` FROM `organizator`", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable TIP()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT tipbuild.ID_Tipbuild,tipbuild.Tipbuild AS `Тип` FROM `tipbuild` ", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

    }
}
