namespace greeting_kata_csharp
{
    public class Greeting
    {
        private static string space = " ";
        private static string and = "and";

        public static string greet(params string[] names)
        {

            Hey hey = new Hey(names);
            Shout shout = new Shout(names);

            if (hey.isEmpty())
            {
                if (shout.isEmpty())
                {
                    return hey.greet();
                }
                else
                {
                    return shout.greet();
                }
            }
            else
            {
                if (!shout.isEmpty())
                {
                    return hey.greet() + space + and.ToUpper() + space + shout.greet();
                }
            }

            return hey.greet() + shout.greet();
        }
    }
}