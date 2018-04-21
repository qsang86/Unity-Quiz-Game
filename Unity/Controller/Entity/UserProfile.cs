using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CotyWebApp.Entity
{
    public class UserProfile
    {
        int id;
        string name;
        DateTime dob;
        string position;
        string division;
        string mobileno;
        string hobbies;
        string interest;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Position { get => position; set => position = value; }
        public string Division { get => division; set => division = value; }
        public string Mobileno { get => mobileno; set => mobileno = value; }
        public string Hobbies { get => hobbies; set => hobbies = value; }
        public string Interest { get => interest; set => interest = value; }
    }
}