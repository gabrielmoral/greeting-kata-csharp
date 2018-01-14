namespace greeting_kata_csharp
{
    public class Names
    {
        private readonly string[] _names;

        public Names(params string[] names)
        {   
            _names = names;
        }

        public int Length { get{ return _names.Length;} }

        public string GetFirst()
        {
            return _names[0];
        }

        public string GetSecond()
        {
             return _names[1];
        }

        internal string Get(int i)
        {
            return _names[i];
         }

        internal bool IsEmpty()
        {
            return _names == null;
        }
    }
}