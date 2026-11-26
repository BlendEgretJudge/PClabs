using System;

namespace App
{
    public class RemoteBuilder
    {
        private int _state;

        public RemoteBuilder(int seed) => _state = seed;

        public int collect(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 54) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new RemoteBuilder(54);
            Console.WriteLine(obj.collect(54));
        }
    }
}
