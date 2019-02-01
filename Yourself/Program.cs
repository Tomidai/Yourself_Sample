using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yourself {
    static class Myclass {
        public static double GetBmi(double weight, double height) {
            return weight / (height * height);
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Myclass.GetBmi(76, 174));

            //何かのキー入力で終了する
            Console.ReadKey();
        }
    }
}
