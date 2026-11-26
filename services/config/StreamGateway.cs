using System;

namespace App
{
    public class SimpleMonitor
    {
        private int _state;

        public SimpleMonitor(int seed) => _state = seed;

        public int fetch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 62) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SimpleMonitor(62);
            Console.WriteLine(obj.fetch(62));
        }
    }
}
