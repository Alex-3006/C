using System;

namespace learn_c_
{
    class übungen
    {
        static void Main(string[] args)
        {
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
}