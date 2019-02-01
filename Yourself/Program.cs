using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yourself {
    public abstract class Super {
        public abstract void Method1();
        public virtual void Method2() { }

        //静的メンバーをorverride,virtual,abstractすることはできない

        public static void Method4() { }
    }

    public class sub : Super {
        public override void Method1() {
            
        }

        public new void Method2() { }

        //newキーワードによる隠蔽は可能...
        public new static void Method4() { }
    }

    public class Hoge {
        private int piyo = 1;   //non-static
        private static int piyo2;   //static

        //non-staticなメソッドはstatic/non-staticのフィールドにアクセスできる
        public void Fuga1(int i) {
            piyo = 2;
            piyo2 = 3;
        }

        //staticなメソッドはstaticのフィールドのみアクセスできる
        public static void Fuga2(int i) {
            //piyo = 2;     //アクセスできない
            piyo2 = 3;
        }
    }

    class Program {
        public int TotalProducts(params int[] values) {
            int result = 1;
            foreach(var value in values) {
                result *= value;
            }
            return result;
        }

        static void Main(string[] args) {
            var v = new Program();
            Console.WriteLine(v.TotalProducts(12, 14, -2));
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2));

            //何かのキー入力で終了する
            Console.ReadKey();
        }
    }
}
