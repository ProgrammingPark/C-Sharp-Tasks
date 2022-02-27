using System;

namespace Task_3.Models
{
    public class User
    {
        public User(int id, string userName, DateTime createDate)
        {
            Id = id;
            Email = userName;
            CreateDate = createDate;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
