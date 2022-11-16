using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PlayerData
    {
        public Player objDataLayer = new Player();

        public void AddNewPlayer(string playerfname, string playerlname, string dateofbirth, string status, string salary)
        {
            objDataLayer.AddNewPlayer(playerfname, playerlname, dateofbirth, status, salary);
        }

        public void UpdatePlayerData(string playerfname, string playerlname, string dateofbirth, string status, string salary, string gameday)
        {
            objDataLayer.UpdatePlayerData(playerfname, playerlname, dateofbirth, status, salary, gameday);
        }

        public void UpdatePlayerData(Player player) { }

        public void DeletePlayer(Player player) { }

        public void DeletePlayer(string playerfname, string playerlname, string dateofbirth, string status, string salary)
        {
            objDataLayer.DeletePlayer(playerfname, playerlname, dateofbirth, status, salary);
        }

        public void AddNewGame(Player player) { }
    
        public void AddNewPlayer(object text) { }

        public void DeleteGame(Player player) { }
 
        public void AddNewPlayer(object txtplayerfname, object txtplayerlname, object txtdob, object txtstatus, object txtsalary) { }

        public object LoadPlayer()
        {
            return objDataLayer.LoadPlayer();
        }

        public void AddNewGame(string date, string venue, string views, string players)
        {
            objDataLayer.AddNewGame(date, venue, views, players);
        }

        public void UpdateGame(string date, string venue, string views, string players )
        {
            objDataLayer.UpdateGame(date, venue, views, players);
        }

        public void DeletePlayer(object txtplayerfname, object txtplayerlname, object txtdob, object txtstatus, object txtsalary) { }
 
        public void DeleteGame(string date, string venue, string views, string players)
        {
            objDataLayer.DeleteGame(date, venue, views, players);
        }

        public object LoadGame()
        {
            return objDataLayer.LoadGame();
        }

        public void AddNewGame(object txtdate, object txtplayerlname, object txtdob, object txtstatus, object txtsalary) { }
     
        public void AddNewGame(object txtdate, object txtvenue, object txtviews, object txtplayer) { }
        
    }
}
