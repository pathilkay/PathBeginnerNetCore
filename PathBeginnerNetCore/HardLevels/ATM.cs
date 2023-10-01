using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PathBeginnerNetCore.HardLevels.Voting;

namespace PathBeginnerNetCore.HardLevels
{
    public static class ATM
    {
        //public static void Main()
        //{
        //    Dictionary<string, double> accounts = new Dictionary<string, double>();
        //    accounts.Add("1000", 1341);
        //    accounts.Add("1500", 7152);
        //    accounts.Add("2500", 1235);

        //    string userId = SignIn(accounts);

        //    if (userId != null)
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
        //            Console.WriteLine("1 - Para Çekme");
        //            Console.WriteLine("2 - Para Yatırma");
        //            Console.WriteLine("3 - Ödeme Yapma");
        //            Console.WriteLine("4 - Çıkış Yap");
        //            Console.WriteLine("5 - Gün Sonu İşlemi");

        //            int selection = Convert.ToInt32(Console.ReadLine());

        //            switch (selection)
        //            {
        //                case 1:
        //                    Withdraw(userId, accounts);
        //                    break;
        //                case 2:
        //                    Deposit(userId, accounts);
        //                    break;
        //                case 3:
        //                    Pay(userId, accounts);
        //                    break;
        //                case 4:
        //                    LogOut();
        //                    break;
        //                case 5:
        //                    EndOfDay(accounts);
        //                    break;
        //                default:
        //                    Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
        //                    break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş, çıkış yapılıyor...");
        //    }
        //}
        public static string SignIn(Dictionary<string, double> accounts)
        {
            Console.WriteLine("Kullanıcı adı : ");
            string userName = Console.ReadLine();

            Console.WriteLine("Parola : ");
            double password;

            if (!double.TryParse(Console.ReadLine(), out password))
            {
                Console.WriteLine("Uygun format değil");
                return null;
            }

            double id;
            if(accounts.TryGetValue(userName, out id) && password == id)
            {
                Console.WriteLine("Tebrikler, giriş başarılı");
                return userName;
            }

            Console.WriteLine("Kullanıcı adı veya şifre yanlıştır");
            return null;
        }
        
        public static void Withdraw(string id,Dictionary<string, double> accounts)
        {
            Console.WriteLine("Çekilecek para miktarı : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < accounts[id])
            {
                accounts[id] -= amount;
                Console.WriteLine("Yeni bakiye: {0}", accounts[id]);
            }
            else
            {
                Console.WriteLine("Bakiye yetersi<");
            }
        }
    
        public static void Deposit(string id, Dictionary<string, double> accounts)
        {
            Console.WriteLine("Yatırılacak tutar : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            accounts[id] += amount;
            Console.WriteLine("Yeni bakiye: {0}", accounts[id]);
        }
   
        public static void Pay(string id, Dictionary<string, double> accounts)
        {
            Console.Write("Lütfen ödemek istediğiniz tutarı girin: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount < accounts[id])
            {
                accounts[id] -= amount;
                Console.WriteLine("Ödeme yapıldı. Yeni bakiye: {0}", accounts[id]);
                
            }
            else
            {
                Console.WriteLine("Hesapta yeterli bakiye yok.");
            }
        }
        
        public static void LogOut()
        {
            Console.WriteLine("Çıkış yapılıyor lütfen bekleyin");
            Environment.Exit(0);
        }
        public static void EndOfDay(Dictionary<string, double> accounts)
        {
            string log = "Transaction Log\n\n";

            foreach (KeyValuePair<string, double> account in accounts)
            {
                log += String.Format("{0}: {1}\n", account.Key, account.Value);
            }

            string errorLog = "Error Log\n\n";
            errorLog += "Hatalı giriş denemeleri logları burada yer alacak.";

            Console.WriteLine(log);
            Console.WriteLine(errorLog);

            string filePath = @"C:\Users\sekii\OneDrive\Masaüstü\Old\Notes" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
            File.WriteAllText(filePath, log + errorLog);
        }
    }
}
