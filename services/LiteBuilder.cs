using System;

namespace App
{
    public class FastEngine
    {
        private int _state;

        public FastEngine(int seed) => _state = seed;

        public int build(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 23) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new FastEngine(23);
            Console.WriteLine(obj.build(23));
        }
    }
}
