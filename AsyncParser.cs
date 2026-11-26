using System;

namespace App
{
    public class LocalCache
    {
        private int _state;

        public LocalCache(int seed) => _state = seed;

        public int flush(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 46) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new LocalCache(46);
            Console.WriteLine(obj.flush(46));
        }
    }
}
