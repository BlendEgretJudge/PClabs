using System;

namespace App
{
    public class LocalHandler
    {
        private int _state;

        public LocalHandler(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 12) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LocalHandler(12);
            Console.WriteLine(obj.handle(12));
        }
    }
}
