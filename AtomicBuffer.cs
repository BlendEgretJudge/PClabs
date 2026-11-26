using System;

namespace App
{
    public class SmartHandler
    {
        private int _state;

        public SmartHandler(int seed) => _state = seed;

        public int sync(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 20) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SmartHandler(20);
            Console.WriteLine(obj.sync(20));
        }
    }
}
