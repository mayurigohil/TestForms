using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectWP.Mayuri.Model
{
    public class DataFile
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Phone;
        public string AL1;
        public string AL2;
        public string City;
        public string State;
        public string Zipcode;
        public string Comments;
        //Define all the variables required in one file
        public DataFile(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10)
        {
            this.FirstName = v1;
            this.LastName = v2;
            this.Email = v3;
            this.Phone = v4;
            this.AL1 = v5;
            this.AL2 = v6;
            this.City = v7;
            this.State = v8;
            this.Zipcode = v9;
            this.Comments = v10;
        }
    }

   }
