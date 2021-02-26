using System;

namespace learn_c_
{
    class dog
    {
        public int numFeet = 4;

        public static string hero = "Lassie";

        static int abc = 2;

        public int NumFeet
        {
            get
            {
                return numFeet;
            }
            set
            {
                if(value >= 0 && value <= 4) 
                {
                    numFeet = value;
                    Console.WriteLine(abc);
                }
            }
        }
        public string name;

        public dog(string name1 = "", int Feet = 4)
        {
            name = name1;
            NumFeet = Feet;
        }

        public void go(int direction = 1)
        {
            NumFeet++;
            if (direction == 1)
            {

            }
            speak();
        }
        private string speak()
        {
            return "Wuff";
        }

        internal string sleep()
        {
            return "ZZZZZZZZZZ";
        }
    }
}