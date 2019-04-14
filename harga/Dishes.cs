using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harga {
    public class Dishes {
        private List<string> _item;

        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

        public Dishes() {
            Code = 1;
            Name = "Burger";
            Description = "Roti Double Stack";
            Price = 13000.0;
            Status = true;

            _item = new List<string>() {
                "001; Burger; Roti Double Stack; 13000; true;",
                "002; Pizza; Pan Medium; 20000; true;",
                "003; Spageti; Bolognese sauce; 15000; true;",
            };
        }
        public string Info() {
            var info = $"code: {Code}; Name: {Name};" +
                $"Description: {Description};" + 
                $"Price:{Price}; Status: {Status}";
            return info;
        }
        public void Create(string item) {
            _item.Add(item);
        }
        public List<string> Read() {
            return _item;
        }
        public void Update (string item) {
            _item.Remove(item);
            _item.Add(item);
        }

        public void Delete (string item) {
            _item.Remove(item);
        }
    }
}
