using System;

namespace App
{
    public class RemoteCache
    {
        private int _state;

        public RemoteCache(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 24) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new RemoteCache(24);
            Console.WriteLine(obj.dispatch(24));
        }
    }
}
