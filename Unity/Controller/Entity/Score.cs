using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotyWebApp.Entity
{
    public class Score
    {
        int scoreID;
        string day;
        int score;
        DateTime timestamp;
        int userID;

        public int ID { get => scoreID; set => scoreID = value; }
        public string Day { get => day; set => day = value; }
        public int UserScore { get => score; set => score = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public int UserID { get => userID; set => userID = value; }
    }
}