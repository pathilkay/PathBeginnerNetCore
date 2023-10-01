using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathBeginnerNetCore.HardLevels
{
    public class Voting
    {
        public class Category
        {
            public string Name { get; set; }
            public int Votes { get; set; }

            public Category(string name)
            {
                Name = name;
                Votes = 0;
            }
        }

        public class User
        {
            public static List<User> Users = new List<User>();

            public string Username { get; set; }

            public User(string username)
            {
                Username = username;
            }

            public static User GetUserByUsername(string username)
            {
                foreach (User user in Users)
                {
                    if (user.Username == username)
                    {
                        return user;
                    }
                }

                return null;
            }
        }
        //public static void Main(string[] args)
        //{
        //    List<Category> categories = new List<Category>();
        //    categories.Add(new Category("Film Kategorileri"));
        //    categories.Add(new Category("Tech Stack Kategorileri"));
        //    categories.Add(new Category("Spor Kategorileri"));

        //    Console.Write("Kullanıcı adınız: ");
        //    string username = Console.ReadLine();

        //    User user = User.GetUserByUsername(username);
        //    if (user == null)
        //    {
        //        user = new User(username);
        //        User.Users.Add(user);
        //        Console.WriteLine("Yeni kullanıcı kaydedildi.");
        //    }

        //    Console.WriteLine("Aşağıdaki kategorilerden birini seçin:");

        //    for (int i = 0; i < categories.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {categories[i].Name}");
        //    }

        //    Console.Write("Seçiminiz (1-3): ");
        //    int choice = int.Parse(Console.ReadLine());

        //    categories[choice - 1].Votes++;
        //    Console.WriteLine($"Teşekkürler, {username}. Oyunuz kaydedildi.");

        //    int totalVotes = 0;
        //    foreach (Category category in categories)
        //    {
        //        totalVotes += category.Votes;
        //    }

        //    Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t\t OY ORANI");
        //    foreach (Category category in categories)
        //    {
        //        double votePercentage = (double)category.Votes / totalVotes * 100;
        //        Console.WriteLine($"{category.Name,-40} {category.Votes,-20} {votePercentage,5:N2}%");
        //    }

        //    Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
        //    Console.ReadLine();
        //}
    }
}
