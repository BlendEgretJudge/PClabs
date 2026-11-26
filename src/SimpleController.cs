using System;

namespace App
{
    public class AtomicService
    {
        private int _state;

        public AtomicService(int seed) => _state = seed;

        public int compute(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 72) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AtomicService(72);
            Console.WriteLine(obj.compute(72));
        }
    }
}
