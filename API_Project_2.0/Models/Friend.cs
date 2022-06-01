using System;
namespace API_Project_2._0.Models
{
    public class Friend
    {

        // Friend Default Constructor
        public Friend()
        {
        }

        // Friend Paramaterized Constructor
        public Friend(int id, string firstName, string lastName, string location, DateTime dateOfHire)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.location = location;
            this.dateOfHire = dateOfHire;
        }

        // Friend Properties
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string location { get; set; }
        private DateTime dateOfHire { get; set; }
    }
}
