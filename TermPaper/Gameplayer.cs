using System;
using BLL;

namespace TermPaper
{
    public class Entity
    {
        private string _info;

        public Entity() {  }
        public Entity(string info) => _info = info;

   
        public void WriteInfo()
        {
            System.Console.WriteLine(_info);
        }
    }
   public class Gameplayer : Entity
    {
        private static object txtplayerfname;
        private static object txtplayerlname;
        private static object txtdob;
        private static object txtstatus;
        private static object txtsalary;
        private static object txtdate;
        private static object txtvenue;
        private static object txtviews;
        private static object txtplayer;
        public static object DataSource { get; private set; }

        static void Main(string[] args)
        {
            
            PlayerData objLogic;

            void Player_load(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                Gameplayer.DataSource = objLogic.LoadPlayer();
                Gameplayer.DataBind();
            }

            void Player_Add(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField1.Value == "")
                {
                    objLogic.AddNewPlayer(txtplayerfname, txtplayerlname, txtdob, txtstatus, txtsalary);
                }
                Console.WriteLine("Player Added");
            }

            void Player_Update(object sender, EventArgs e)
            { 
                objLogic = new PlayerData();
                if (HiddenField1.Value == "")
                {
                    objLogic.AddNewPlayer(txtplayerfname, txtplayerlname, txtdob, txtstatus, txtsalary);
                }
                Console.WriteLine("Player Updated");
            }

            void Player_Remove(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField1.Value != "")
                {
                    objLogic.DeletePlayer(txtplayerfname, txtplayerlname, txtdob, txtstatus, txtsalary);
                }
                Console.WriteLine("Player Deleted");
            }

            void Game_Add(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField2.Data == "")
                {
                    objLogic.AddNewGame(txtdate, txtvenue, txtviews, txtplayer);
                }
                Console.WriteLine("Game Added");
            }

            void Game_Update(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField2.Data == "")
                {
                    objLogic.AddNewGame(txtdate, txtvenue, txtviews, txtplayer);
                }
                Console.WriteLine("Game Updated");
            }

            void Game_player(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField2.Data !="")
                {
                    objLogic.DeletePlayer(txtplayerfname, txtplayerlname, txtdob, txtstatus, txtsalary);
                }
                Console.WriteLine("player removed from game");
            }
            void Game_Remove(object sender, EventArgs e)
            {
                objLogic = new PlayerData();
                if (HiddenField2.Data == "")
                {
                    objLogic.AddNewGame(txtdate, txtvenue, txtviews, txtplayer);
                }
                Console.WriteLine("Game Deleted");
            }

        }

        private static void DataBind()
        {
            throw new NotImplementedException();
        }

        private class HiddenField1
        {
            public static string Value { get; internal set; }
        }
        private class HiddenField2
        {
            public static string Data { get; internal set; }
        }
    }
}
