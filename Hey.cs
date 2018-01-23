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

            string greet = "";
      
            if (!names.Any())
            {
                greet =  hello + comma + space + "my friend" + point;
            }

            if (names.Length >= 1)
            {
                greet = hello + comma + space + nameComposer(names) + point;
            }

            return greet;
        }

    }
}