using System;

namespace greeting_kata_csharp
{
    public class Greeting
    {
        private static string hello = "Hello";
        private static string comma = ",";
        private static string space = " ";
        private static string point = ".";
        private static string exclamation = "!";
        private static string and = "and";

        public static string greet(params string[] namesList)
        {
            var names = new Names(namesList);

            if (isShouting(names))
            {
                return shout(names);
            }
            else
            {
                return hey(names);
            }
        }

        private static bool isShouting(Names names)
        {
            return !names.IsEmpty() && names.GetFirst().Equals(names.GetFirst().ToUpper());
        }

        private static string hey(Names names)
        {
            return hello + comma + space + composeNames(names) + point;
        }

        private static string composeNames(Names names)
        {
            if (names.IsEmpty())
            {
                return noNames();
            }

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

        private static string manyNames(Names names)
        {
            string output = "";
            for (int i = 0; i < names.Length - 1; i++)
            {
                output = output + names.Get(i) + comma + space;
            }

            return output + and + space + names.Get(names.Length - 1);
        }

        private static string twoNames(Names names)
        {
            return names.GetFirst() + space + and + space + names.GetSecond();
        }

        private static string oneName(Names names)
        {
            return names.GetFirst();
        }

        private static string noNames()
        {
            return "my friend";
        }

        private static string shout(Names names)
        {
            return hello.ToUpper() + space + names.GetFirst() + exclamation;
        }
    }
}