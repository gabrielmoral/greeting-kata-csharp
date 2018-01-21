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
            if (!names.Any()) return "";

            string composition;
            if (names.Length == 1)
            {
                composition = hello + space + composeNames(names) + exclamation;
            }
            else
            {
                composition = hello + comma + space + composeNames(names) + exclamation;
            }

            return composition.ToUpper();
        }

    }
}