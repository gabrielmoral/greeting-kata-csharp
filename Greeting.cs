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

        public static string greet(params string[] names)
        {
            if (isShouting(names))
            {
                return shout(names[0]);
            }
            else
            {
                return hey(names);
            }
        }

        private static bool isShouting(params string[] names)
        {
            return names != null && names[0].Equals(names[0].ToUpper());
        }

        private static string hey(params string[] names)
        {
            return hello + comma + space + composeNames(names) + point;
        }

        private static string composeNames(params string[] names)
        {
            if (names == null)
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

        private static string manyNames(params string[] names)
        {
            string output = "";
            for (int i = 0; i < names.Length - 1; i++)
            {
                output = output + names[i] + comma + space;
            }

            return output + and + space + names[names.Length - 1];
        }

        private static string twoNames(params string[] names)
        {
            return names[0] + space + and + space + names[1];
        }

        private static string oneName(params string[] names)
        {
            return names[0];
        }

        private static string noNames()
        {
            return "my friend";
        }

        private static string shout(string name)
        {
            return hello.ToUpper() + space + name + exclamation;
        }
    }
}