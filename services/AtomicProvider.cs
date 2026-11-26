using System;

namespace App
{
    public class LocalBuilder
    {
        private int _state;

        public LocalBuilder(int seed) => _state = seed;

        public int build(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 91) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LocalBuilder(91);
            Console.WriteLine(obj.build(91));
        }
    }
}
