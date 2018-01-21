using System;
using System.Linq;

namespace greeting_kata_csharp
{
    internal abstract class Greeter
    {
        protected static string hello = "Hello";
        protected static string comma = ",";
        protected static string space = " ";
        protected static string point = ".";
        protected static string exclamation = "!";
        protected static string and = "and";

        protected string[] names;
        protected bool empty;

        public bool isEmpty()
        {
            return !names.Any();
        }

        internal abstract string greet();

        protected static bool isShouting(string name)
        {
            return name != null && name.Equals(name.ToUpper());
        }

        protected static string composeNames(params string[] names)
        {
            if (names.Length == 2)
            {
                return twoNames(names);
            }

            if (names.Length > 2)
            {
                return manyNames(names);
            }

            return oneName(names);
        }

        protected static string manyNames(params string[] names)
        {
            string output = "";
            for (int i = 0; i < names.Length - 1; i++)
            {
                output = output + names[i] + comma + space;
            }

            return output + and + space + names[names.Length - 1];
        }

        protected static string twoNames(params string[] names)
        {
            return names[0] + space + and + space + names[1];
        }

        protected static string oneName(params string[] names)
        {
            return names[0];
        }
    }
}