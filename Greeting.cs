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
            return names.IsFirstUpperCase();
        }

        private static string hey(Names names)
        {
            return hello + comma + space + names.Compose() + point;
        }
        
        private static string shout(Names names)
        {
            return hello.ToUpper() + space + names.Compose() + exclamation;
        }
    }
}