using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Production.Models
{
    public class VideoGameModel
    {
        private string id, nameGame, thematic;
        //private DateTime startDate, finishDate;
        private string startDate, finishDate;

        public string Id { get => id; set => id = value; }
        public string NameGame { get => nameGame; set => nameGame = value; }
        public string Thematic { get => thematic; set => thematic = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string FinishDate { get => finishDate; set => finishDate = value; }

        //public DateTime StartDate { get => startDate; set => startDate = value; }
        //public DateTime FinishDate { get => finishDate; set => finishDate = value; }



        public void AskInformation(string id, string nameGame, string thematic, string startDate, string finishDate)
        {
            this.id = id;
            this.nameGame = nameGame;
            this.thematic = thematic;
            this.startDate = startDate;
            this.finishDate = finishDate;
        }

        public VideoGameModel()
        {

        }
    }
}