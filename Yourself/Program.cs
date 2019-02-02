using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yourself {
    class Program {
        public static (double addition, double subtraction) AddSubtract(double x, double y) {
            return (x + y, x - y);
        }        
        static void Main(string[] args) {
            var t = AddSubtract(4, 5);
            Console.WriteLine(t.addition);
            Console.WriteLine(t.subtraction);
            //何かのキー入力で終了する
            Console.ReadKey();
        }
    }
}
