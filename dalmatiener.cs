using System;

namespace learn_c_
{
    class dalmatiener : dog
    {
        public dalmatiener(string name1 = "", int Feet = 4) : base(name1, Feet)
        {

        }
        public string printMe()
        {
            string ret = "";
            ret += name;
            ret += " ";
            ret += numFeet;
            return ret;
        }
    }
}