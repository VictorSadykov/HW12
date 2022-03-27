using System;
using System.Threading;

namespace HW12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userWithPremium = new User()
            {
                Login = "qwerty",
                Name = "Alex",
                IsPremium = true
            };

            var userWithoutPremium = new User()
            {
                Login = "qwerty",
                Name = "Peter",
                IsPremium = false
            };

            GreetUser(userWithPremium);
            GreetUser(userWithoutPremium);
        }

        static void GreetUser(User user)
        {
            if (user.IsPremium == false)
            {
                ShowAd();
            }
            Console.WriteLine("Hello " + user.Name);
        }

        static void ShowAd()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }

        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }
    }
}
