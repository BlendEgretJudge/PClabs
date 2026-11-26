using System;

namespace App
{
    public class RemoteCache
    {
        private int _state;

        public RemoteCache(int seed) => _state = seed;

        public int render(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 5) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new RemoteCache(5);
            Console.WriteLine(obj.render(5));
        }
    }
}
