using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yourself {
    class Person {
        public string firstName;
        public string lastName;

        //引数greeting/titleに規定値を設定
        public void Show(string greeting = "こんにちは", string title = "さん") {
            Console.WriteLine($"{greeting},{this.lastName}{this.firstName}{title}");
        }

        public void DemoProc(string name = "default name", int age = 0) {
            Console.WriteLine($"{name}{age}");
        }
    }

    class Program {
        static void Main(string[] args) {
            var p = new Person() {
                lastName = "山田", firstName = "taro"
            };
            p.DemoProc();
            p.DemoProc("tomita", 20);
            p.DemoProc("tomita");
            p.DemoProc(age: 20);
            p.DemoProc(name: "tomita");
            p.DemoProc(name: "tomita", age: 20);
            p.DemoProc(age: 20, name: "tomita");
            //p.DemoProc(20);   !error
            //何かのキー入力で終了する
            Console.ReadKey();
        }
    }
}
