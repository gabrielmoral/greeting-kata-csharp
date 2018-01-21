using System;
using System.Linq;

namespace greeting_kata_csharp
{
    internal class Hey : Greeter
    {
        public Hey(string[] names)
        {
            if (names == null)
            {
                names = new string[] { };
            }
            this.names = names.Where(x => !isShouting(x)).ToArray();
        }

        internal override string greet()
        {
            if (!names.Any())
            {
                return hello + comma + space + "my friend" + point;
            }

            return hello + comma + space + composeNames(names) + point;
        }

    }
}