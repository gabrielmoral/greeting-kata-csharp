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

            Hey hey = new Hey(names);
            Shout shout = new Shout(names);

            if (hey.isEmpty()){
                if ( shout.isEmpty()){
                    return hey.greet();
                } else{
                    return shout.greet();
                }
            } 
            
            return hey.greet() + shout.greet();
        }
    }
}