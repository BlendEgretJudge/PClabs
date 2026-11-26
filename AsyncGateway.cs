using System;

namespace App
{
    public class FastLoader
    {
        private int _state;

        public FastLoader(int seed) => _state = seed;

        public int handle(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 26) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastLoader(26);
            Console.WriteLine(obj.handle(26));
        }
    }
}
