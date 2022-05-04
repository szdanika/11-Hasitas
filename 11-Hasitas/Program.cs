using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11_Hasitas
{
    
    internal class Program
    {
        public static void kiiro(double amount)
        {
            Console.WriteLine("Vegeredmeny : " + amount);
        }
        public static void test1(string txt)
        {
            string[] txts = File.ReadAllLines(txt);
            bool megvan = false;int i = 0;
            while(megvan == false)
            {
                if (txts[i] == "")
                    megvan = true;
                else
                    i++;
            }
            Bank b = new Bank(i, null);
            for(int x = 0; x < i; x ++)
            {
                b.RegisterAccount(txts[x].Split(',')[0], Convert.ToDouble(txts[x].Split(',')[1]));
            }
            b.kuldes += kiiro;
            for (int x = i+1; x < txts.Length-1; x++)
            {
                b.Transaction(txts[x].Split(',')[0], txts[x].Split(',')[1], Convert.ToDouble(txts[x].Split(',')[2]));
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            test1("bank_log.txt");
        }
    }
}
