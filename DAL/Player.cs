using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using System.Xml.Serialization;
using System.IO;

namespace DAL
{
    [Serializable()]
    public class Player : ISerializable
    {

        private string conn = ConfigurationManager.ConnectionStrings["TermPaper"].ToString();
        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();

        }
        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }

        public void AddNewPlayer(string playerfname, string playerlname, string dateofbirth, string status, string salary)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Player (playerfname, playerlname, dateofbirth, status, salary) VALUES ('" + playerfname + "','" + playerlname + "','" + dateofbirth + "','" + status + "','" + salary + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdatePlayerData(string playerfname, string playerlname, string dateofbirth, string status, string salary, string gameday)
        {
            DataSet ds = new DataSet();
            string sql = "Update Player Data.. First_Name='" + playerfname + "',Last_Name = '" + playerlname + "',DateOfBirht= '" + dateofbirth + "',Player_status = '" + status + "',Player_salary = '" + salary + "' Where playerdata = '" + gameday + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeletePlayer(string playerfname, string playerlname, string dateofbirth, string status, string salary)
        {
            DataSet ds = new DataSet();
            string sql = "Delete Player = '" + playerfname + "',' " + playerlname + "','" +  dateofbirth + "','" + status + "','" + salary + "','";
            InsertUpdateDeleteSQLString(sql);
        }
        public object LoadPlayer()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * player";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        public void AddNewGame(string date, string venue, string views, string players)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Game (game_date, game_venue, game_views, game_players) VALUES ('" + date + "','" + venue + "','" + views + "','" + players +  "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateGame(string date, string venue, string views, string players)
        {
            DataSet ds = new DataSet();
            string sql = "Update Game ='" + date + "',customer_address = '" + venue + "',customer_country= '" + views + "',customer_city = '" + players + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteGame(string date, string venue, string views, string players)
        {
            DataSet ds = new DataSet();
            string sql = "Delete Game = '" + date + "','" + venue + "', '" + views + "' , '" + players + "','";
            InsertUpdateDeleteSQLString(sql);
        }
        public object LoadGame()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * Game..";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        public string Name { get; set; }
        public string Dob { get; set; }
        public string Status { get; set; }
        public int Salary { get; set; }
        public bool isplayer { get; set; }


        public Player() { }

        public Player(string name = "blank",
            string dob = "blank", string status = "blank", int salary = 0)
        {
            Name = name;
            Dob = dob;
            Status = status;
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0} was born on the {1} and he is currently {2} therefore earning {3}",
                Name, Dob, Status, Salary);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Dob", Dob);
            info.AddValue("Status", Status);
            info.AddValue("Salary", Salary);
        }

        Player frenchie = new Player("Frenchie", "3/5/96", "active", 48888);
        Stream stream = File.Open("Playerdata.dat", FileMode.Create);

        XmlSerializer serializer = new XmlSerializer(typeof(Player));

        TextWriter tw = new StreamWriter(@"C:\Users\princessntomo\C#Data\player.xml"))
            {
              serializer.Serialize(TextWriter, Player);
            }
        XmlNode Singlenode = PlayerDocument.SelectSingleNode(@"C:\Users\princessntomo\C#Data\player.xml");

        string PlayerData = .InnerText;
  }



     
