// #define DEBUG
// #define DEBUG2
// #undef DEBUG

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections;

namespace learn_c_
{
    // #region 
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World!
            // Console.WriteLine("Hello World!");


            // Variablen!
            // int num1;
            // // Int16 num1_2;
            // // Int32 num1_3;
            // // Int64 num1_4;
            // // num1_4 = 10;
            // num1 = 5;
            // num1 = 5 + 6;
            // num1 = num1 + 7;
            // num1 = num1 - 7;
            // num1 = num1 / 7;
            // num1 = num1 * 7;
            // num1 = num1 % 7;
            // num1 += 8;
            // Console.WriteLine(num1);
            // int num2 = 1;
            // Console.WriteLine(num2);

            // double gleitkom1 = 5.4321f;
            // float gleitkom2 = 5.6f;
            // Console.WriteLine(gleitkom1);
            // Console.WriteLine(gleitkom2);

            // // bool truvalue = false;
            // bool value = true;
            // Console.WriteLine(value);

            // char letter = 't';
            // string bigletter = "Hello World";
            // string added = "hello" + "world";
            // added += "!";
            // Console.WriteLine(letter);
            // Console.WriteLine(bigletter);
            // Console.WriteLine(added);


            // If Statment!
            // bool a = true;
            // bool b = false;
            // bool c = true;
            // bool and = a && b;
            // bool or = a || b;
            // bool not = (a && c) || b;
            // if (not)
            // {
            //     Console.WriteLine("Hallo");
            //     if (or)
            //     {
            //         Console.WriteLine("Test");
            //         // one of it is true
            //     }
            // }
            // else if (and)
            // {
            //     Console.WriteLine("Good");
            // }
            // else
            // {
            //     Console.WriteLine("bye!");
            // }


            // Switch Case!
            // int i = 5;
            // switch(i)
            // {
            //     case 0:
            //         Console.WriteLine("0");
            //         break;
            //     case 1:
            //         Console.WriteLine("1");
            //         break;
            //     case 3:
            //         Console.WriteLine("3");
            //         break;
            //     case 5:
            //         Console.WriteLine("5");
            //         break;
            //     default:
            //         Console.WriteLine("unknown");
            //         break;
            // }


            // Schleifen!
            // int condition = 0;
            // while (condition < 20)
            // {
            //     Console.WriteLine(condition);
            //     condition++;
            // }
            // // oder
            // for (int i = 0; i < 20; i++)
            // {
            //     if (i == 10)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }

            // do
            // {
            //     Console.WriteLine(condition);
            //     condition++;
            // } while (condition < 20);


            // Arrays!
            // int[] manyNumbers = new int[42];
            // manyNumbers[0] = 42;
            // double[] darray = new double[] { 5.5, 42, 1234 };
            // for (int i = 0; i < manyNumbers.Length; i++)
            // {
            //     if (i == 0)
            //     {
            //         continue;
            //     }
            //     manyNumbers[i] += manyNumbers[i-1];
            //     Console.WriteLine(i);
            // }

            // int[,] manyNumbers1 = new int[3, 2] {
            //     {1, 42},
            //     {5, 1337},
            //     {10, 0}
            // };
            // for (int i = 0; i < manyNumbers1.GetLength(0); i++)
            // {
            //     for (int y = 0; y < manyNumbers1.GetLength(1); y++)
            //     {
            //         manyNumbers1[i,y] += 5;
            //         Console.WriteLine(manyNumbers1[i,y]);
            //     }
            // }


            // Methoden
            // int x = 42;
            // int y = 1;
            // int number = Program.Method(x, y);
            // Console.WriteLine(Program.Method(5, 10));

            // Console.WriteLine(Program.fakul(6));

            // Program.foo("hallo welt", 42);


            // Klassen
            // dog pfifi = new dog("pfifi, 3");
            // int x = pfifi.numFeet = 4;
            // Console.WriteLine(pfifi.NumFeet);
            // Console.WriteLine(dog.hero);
            // dog.hero = "bello";
            // dalmatiener tim = new dalmatiener("Tim", 3);
            // Console.WriteLine(tim.printMe());
            // dog bello = new dog("bello");


            // Interfaces!
            //     IAnimal[] animal = new IAnimal[3];
            //     animal[0] = new Meow();
            //     animal[1] = new Wau();
            //     animal[2] = new Meow();

            //     foreach (IAnimal t in animal)
            //     {
            //         t.laufen();
            //     }
            // }

            // Animal[] animal = new Animal[3];
            // animal[0] = new Meow();
            // animal[1] = new Wau();
            // animal[2] = new Meow();

            // foreach (Animal t in animal)
            // {
            //     t.go();
            // }


            // Operatoren Überladen!
            // Vector a = new Vector();
            // a.a = 2;
            // a.b = 3;

            // Vector b = new Vector();
            // b.a = 12;
            // b.b = 13;

            // Vector c = a + b;


            // Listen implementieren
            // List l = new List();
            // l.add("abc");
            // l.add("xyz");
            // Console.WriteLine(l.get(1));
            // l.delete("abc");
            // Console.WriteLine(l.get(0));
            // List<string> list = new List<string>();

            // Enums!
            // Gefahr g = Gefahr.High;
            // Console.WriteLine(g < Gefahr.Extreme);


            // Lambda!
            // List<int> list = new List<int>() {10, 15, 20, 42, 1337};
            // foreach (var e in list.OrderByDescending(x => x))
            // {
            //     Console.WriteLine(e);
            // }
            // Func<int, int> f1 = x => 2*x;
            // Console.WriteLine(f1.Invoke(4));
            // Action f2 = () => Console.WriteLine("hi");
            // f2.Invoke();


            // Typen!
            // A a = new A { a = 10, b = 42};
            // var pet = new {age = 42, name = "rex"};
            // List<A> list = new List<A>() {a};
            // var aes = from x in list
            //             select new { x.a};
            // Console.WriteLine(aes.First().a);
            // Console.WriteLine(aes.ElementAt(1).a);


            // Events!
            // ListChanged list = new ListChanged();
            // Listener listener = new Listener(list);
            // list.Add("element");


            // Direktiven
            // #if(DEBUG && DEBUG2)
            //             Console.WriteLine("Debugging enabled");
            // #elif (DEBUG)
            //             Console.WriteLine("No interes");
            // #else
            //             Console.WriteLine("Debugging disabled");
            // #endif
            // #error "Have forgot it"
            // #warning Make this


            // Dictonaries
            // Dictionary<int, String> dict = new Dictionary<int, string>();

            // dict.Add(42, "The answer");
            // dict.Add(1337, "Leet");
            // string abc;

            // Console.WriteLine(dict.TryGetValue(42, out abc));
            // foreach (var pair in dict)
            // {
            //     Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            // }
            // Console.WriteLine(dict.ContainsKey(42));
            // dict.Remove(42);


            // Handling
            // try
            // {
            //     int[] abc = new int[1];
            //     Console.WriteLine(abc[2]);
            //     throw new IndexOutOfRangeException();
            // }
            // catch (IndexOutOfRangeException e)
            // {
            //     Console.WriteLine("IOORE: ", e.Source);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.StackTrace);
            // }
            // finally
            // {
            //     Console.WriteLine("finally");
            // }
            // Console.WriteLine("It works");
            // try
            // { 
            //     fnc(); 
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
        }
        // public static int Method(int a, int b)
        // {
        //     return a + b;
        // }

        // public int fakul(int n)
        // {
        //     if (n==2)
        //     {
        //         return 2;
        //     }
        //     return n*fakul(n-1);
        // }

        // public static void foo(string i, int y = 1)
        // {
        //     for (int k = 0; k < y; k++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // enum Gefahr
        // {
        //     None, Low, Mid, High, Extreme,
        // };

        // class A
        // {
        //     public int a { get; set; }
        //     public int b { get; set; }
        // }

        // public static void func(string a, out string b, out string c)
        // {
        //     b=a;
        //     c=a;
        // }

        // public static void fnc()
        // {
        //     throw new DivideByZeroException();
        // int i =1
        // }
    }
    // public interface IAnimal
    // {
    //     void laufen();
    //     // int weight();
    // }

    // // public interface IWeight
    // // {
    // //     int weight();
    // // }
    // public class Wau : Animal // , IWeight
    // {
    //     public override void go()
    //     {
    //         Console.WriteLine("Go!");
    //     }

    //     // public sealed int weight()
    //     // {
    //     //     return 100;
    //     // }
    // }
    // public class Meow : Animal
    // {
    //     public override void go()
    //     {
    //         Console.WriteLine("Go! Now!");
    //     }
    // }

    // public abstract class Animal
    // {
    //     int abc = 5;
    //     public virtual void go()
    //     {
    //         Console.WriteLine("GOgogo!");
    //     }
    //     public abstract int weight();
    // }


    // public class Vector
    // {
    //     public int a = 0;
    //     public int b = 0;

    //     public static Vector operator +(Vector x, Vector y)
    //     {
    //         Vector ret = new Vector();
    //         ret.a = x.a + y.a;
    //         ret.b = x.b + y.b;

    //         return ret; 
    //     }
    // }
    // public class List
    // {
    //     public class Node
    //     {
    //         public string Inhalt;
    //         public Node next;
    //         internal string content;
    //     }
    //     private int size;
    //     public int Count
    //     {
    //         get { return size; }
    //     }
    //     private Node head;
    //     private Node current;
    //     public List()
    //     {
    //         size = 0;
    //         head = null;
    //     }
    //     public void add(string content)
    //     {
    //         size++;
    //         Node node = new Node();
    //         node.content = content;
    //         if (head == null)
    //         {
    //             head = node;
    //         }
    //         else
    //         {
    //             current = head;
    //             while(current.next != null)
    //             {
    //                 current = current.next;
    //             }
    //             current.next = node;
    //         }
    //     }
    //     public string get(int i)
    //     {
    //         if(i >= size)
    //         {
    //             return "";
    //         }
    //         current = head;
    //         for(int j = 0; j < i; j++)
    //         {
    //             current = current.next;
    //         }
    //         return current.content;
    //     }
    //     public void delete(string s)
    //     {
    //         if (head == null)
    //         {
    //             return;
    //         }
    //         if (head.content == s)
    //         {
    //             head = head.next;
    //         }
    //         current = head;
    //         while(current != null)
    //         {
    //             if(current.content == s)
    //             {
    //                 Node before = head;
    //                 while(before.next != current)
    //                 {
    //                     before = before.next;
    //                 }
    //                 before.next = current.next;
    //             }
    //             current = current.next;
    //         }
    //     }
    // }

    // class A
    // {
    //     public int a = 5;

    //     public void print()
    //     {
    //         Console.WriteLine(a);
    //     }
    // }
    // class B : A
    // {
    //     int b = 10;

    //     public void print2()
    //     {
    //         Console.WriteLine(a);
    //         Console.WriteLine(b);
    //     }
    // }

    // public delegate void ChangedEventHandler(object sender, EventArgs e);
    // public class ListChanged : ArrayList
    // {
    //     public event ChangedEventHandler changed;

    //     protected virtual void Onchanged(EventArgs e)
    //     {
    //         if (changed != null)
    //         {
    //             changed(this, e);
    //         }
    //     }
    //     public override int Add(object value)
    //     {
    //         Onchanged(EventArgs.Empty);
    //         return base.Add(value);
    //     }
    // }

    // class Listener
    // {
    //     public ListChanged list;

    //     public Listener(ListChanged list2)
    //     {
    //         list = list2;
    //         list.changed += new ChangedEventHandler(list_changed);
    //     }

    //     private void list_changed(object sender, EventArgs e)
    //     {
    //         Console.WriteLine("Element added");
    //     }
    // }
    // #endregion 
}