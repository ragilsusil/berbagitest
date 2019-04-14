using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harga
{
    public class Program
    {
        static void Main(string[] args) {
            var transact = new Transaction();
            Process.GetInstance.WriteFile(transact);
            transact.sales();
            transact.PreSales();
            transact.ChangeDue();

            Process.GetInstance.ReadFile(ref transact);
            Console.ReadKey();
            Console.ReadLine();
            ConsoleKeyInfo();
        }
    }
}
