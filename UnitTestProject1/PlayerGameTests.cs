using BLL;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace UnitTestProject1
{
    [TestClass]
    public class PlayerGameTests
    {
       
        [TestMethod]
        public void AddPlayer_isobjLogic_Add()
        {
            var add = new PlayerData();

           add.AddNewPlayer(new Player { isplayer = true });

           Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdatePlayer_isobjLogic_Update()
        {
            var add = new PlayerData();

            add.UpdatePlayerData(new Player { isplayer = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeletePlayer_isobjLogic_Delete()
        {
            var add = new PlayerData();

            add.DeletePlayer(new Player { isplayer = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddNewGame_isobjLogic_Add()
        {
            var add = new PlayerData();

            add.AddNewGame(new Player { isplayer = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteGame_isobjLogic_Game()
        {
            var add = new PlayerData();

            add.DeleteGame(new Player { isplayer = true });

            Assert.IsTrue(result);
        }
        bool result;
    }
}
