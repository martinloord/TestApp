using System;

namespace TestApp.API.Models
{
    public class Photo
    {
        public int  Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public User User { get; set; }
                                            // cascade delete, om vi tar bort en användare tar vi också bort PhotoICollection
        public int UserId { get; set; }     // om vi har med User tabellen och deras id som sambandstabell 
    }
}