using System;

namespace App
{
    public class LocalProvider
    {
        private int _state;

        public LocalProvider(int seed) => _state = seed;

        public int load(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 42) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new LocalProvider(42);
            Console.WriteLine(obj.load(42));
        }
    }
}
