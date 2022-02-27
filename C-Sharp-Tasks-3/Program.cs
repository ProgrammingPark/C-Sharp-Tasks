using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Contstant;
using Task_3.Models;
using Task_3.ViewModels;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> enabledUsers = new List<User>
            {
                new User(1, "andews@gmail.com", new DateTime(2019,2,5)),
                new User(2, "kosten24@gmail.com", new DateTime(2020,10,15)),
                new User(3, "simonsq@gmail.com", new DateTime(2021,8,21))
            };

            List<User> disabledUsers = new List<User>
            {
                new User(4, "vikatop@gmail.com", new DateTime(2020,4,3)),
                new User(5, "ihone.luxx@gmail.com", new DateTime(2022,9,15)),
                new User(6, "today.sia@gmail.com", new DateTime(2022,1,1))
            };

            ActionsWithUsers(disabledUsers);
        }

        private static void ActionsWithUsers(List<User> users)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            IMapper mapper = config.CreateMapper();

            var mappedUsers = mapper.Map<List<UserViewModel>>(users, opt => opt.Items.Add("Status", UserStatus.Enabled));

            foreach (var user in mappedUsers)
                Console.WriteLine(user.ToString());

            Console.ReadKey();
        }
    }
}
