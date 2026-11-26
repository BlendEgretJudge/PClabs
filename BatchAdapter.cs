using System;

namespace App
{
    public class AtomicDispatcher
    {
        private int _state;

        public AtomicDispatcher(int seed) => _state = seed;

        public int run(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 91) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AtomicDispatcher(91);
            Console.WriteLine(obj.run(91));
        }
    }
}
