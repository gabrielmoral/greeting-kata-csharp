using System;
using System.Linq;

namespace greeting_kata_csharp
{
    internal class Shout : Greeter
    {
        public Shout(string[] names)
        {
            if (names == null)
            {
                names = new string[] { };
            }
            this.names = names.Where(isShouting).ToArray();
        }

        internal override string greet()
        {
            string greetComposition = "";

            if (names.Length == 1)
            {
                greetComposition = hello + space + nameComposer(names) + exclamation;
            }
            
            if (names.Length >= 2)
            {
                greetComposition = hello + comma + space + nameComposer(names) + exclamation;
            }

            return greetComposition.ToUpper();

        }

    }
}