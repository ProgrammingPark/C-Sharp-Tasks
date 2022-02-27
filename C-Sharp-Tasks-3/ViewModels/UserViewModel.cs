using System;
using Task_3.Contstant;

namespace Task_3.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string CreateDate { get; set; }
        public UserStatus UserStatus { get; set; }

        public override string ToString()
        {
            return $"Id: {UserId}\nEmail: {UserEmail}\nCreate Date: {CreateDate}\nStatus: {Enum.GetName(typeof(UserStatus), UserStatus)}\n\n";
        }
    }
}
