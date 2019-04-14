using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harga {
    public class Transaction {
        public string Invoice { get; set; }
        public string CurrDate { get; set; }
        public Dishes Dish { get; set; }

        public Transaction() {
            Dish = new Dishes();
            Invoice = "NO1/2019/0001";
            CurrDate = Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yy");

        }
        public void sales() {
            var sales = $"invoice: {Invoice}; CurrDate: {CurrDate}; ";
            Console.WriteLine(sales);
        }
        public void PreSales() {
            Console.WriteLine(Dish.Info());
        }
        public void ChangeDue() {
            if (Dish == null) return;
            Console.WriteLine(PlusPPn());
        }
        public double PlusPPn() {
            var tax = 1.1;
            tax *= Dish.Price;
            return tax;
        }
    }
}
