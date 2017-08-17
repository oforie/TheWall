using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TheWall.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public List<Message> Messages { get; set; }
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public User()
        {
            Messages = new List<Message>();
        }
    }
}