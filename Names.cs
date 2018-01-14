using System;

namespace greeting_kata_csharp
{
    public class Names
    {
        private static string comma = ",";
        private static string space = " ";
        private static string and = "and";

        private readonly string[] _names;

        public Names(params string[] names)
        {   
            _names = names;
        }

        public string Compose()
        {
            if (IsEmpty())
            {
                return NoNames();
            }

            if (_names.Length == 2)
            {
                return TwoNames();
            }

            if (_names.Length > 2)
            {
                return ManyNames();
            }

            return FirstName();
        }

        public bool IsFirstUpperCase()
        {
            return  !IsEmpty() && FirstName().Equals(FirstName().ToUpper());
        }

        private  string ManyNames()
        {
            string output = "";
            for (int i = 0; i < _names.Length - 1; i++)
            {
                output = output + _names[i] + comma + space;
            }

            return output + and + space + _names[_names.Length - 1];
        }

        private string TwoNames()
        {
            return FirstName() + space + and + space + SecondName();
        }

        private string NoNames()
        {
            return "my friend";
        }

        private string FirstName()
        {
            return _names[0];
        }

        private string SecondName()
        {
            return _names[1];
        }

        private bool IsEmpty()
        {
            return _names == null;
        }
    }
}