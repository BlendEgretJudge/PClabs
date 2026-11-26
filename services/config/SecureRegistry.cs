using System;

namespace App
{
    public class CoreWorker
    {
        private int _state;

        public CoreWorker(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 90) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new CoreWorker(90);
            Console.WriteLine(obj.parse(90));
        }
    }
}
