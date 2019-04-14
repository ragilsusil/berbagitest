using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harga {
    public class Process {
        private string _path;
        private static Process _instance = new Process();
        public static Process GetInstance {
            get {
                if(_instance == null) {
                    _instance = new Process();
                }
                return _instance;
            }
        }

        private Process() {
            _path = @"D:\Test.txt";

        }

        public bool WriteFile(Transaction invoice) {
            try {
                File.Delete(_path);
                string[] lines = {
                    "invoice: "+invoice.Invoice + "",

                };

                using (var outputFile = new StreamWriter(_path)) {
                    foreach (string line in lines) {
                        outputFile.WriteLine(line);
                    }
                }
                return true;
            }catch {
                return false;
            }
        }

        public bool ReadFile(ref Transaction invoice) {
            try {
                if (!File.Exists(_path)) {
                    return false;
                }

                var srin = File.OpenText(_path);
                var scanout = "";
                var i = 0;

                while ((scanout = srin.ReadLine()) != null) {
                    switch (i) {
                        case 0:
                            invoice.Invoice = scanout.ToString().Substring(9);
                            break;
                     
                    }
                    i++;
                }
                return true;
            }catch {
                return false;
            }
        }
    }
}
