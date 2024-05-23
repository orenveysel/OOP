using System.Threading.Channels;

namespace _22_ActionDelegate
{
    internal class Program
    {
        public delegate void TestDel();
        static void Main(string[] args)
        {
              
             TestDel test = new TestDel(EkranaYaz2);
            //Generic Olmayan Action tipi , Herhangi bir parametre almayan ve geri donusu olmayan bir delegate tipidir
            //Action delegate kullandigimizda farkidaysaniz delegeta tanimlamasina gerek yoktur.

            Action message = () => Console.WriteLine("Action Delegate ornegi");
            message.Invoke();
            Console.WriteLine("*************");
            message();
            #region Generic Action tipi
            //Generic Action Delegate geri donus degeri olmayan en fazla 16 parametre alabilen bir delegate tipidir
            Action<string> EkranaYaz= str=>Console.WriteLine(str);
            Action<int, int> toplaAction = (a, b) => Console.WriteLine("Toplam :" + (a + b));
            Action<int, int> toplaAction2 = ToplamAction;
            toplaAction(3, 5);
            #endregion


            Console.WriteLine("Hello, World!");
        }
        public static void ToplamAction(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void EkranaYaz3(string str)
        {
            Console.WriteLine(str);
        }
        public static void EkranaYaz2()
        {
            Console.WriteLine("Ekrana yaz calisti");
        }
    }
}
