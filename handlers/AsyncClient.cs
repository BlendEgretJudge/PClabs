using System;

namespace App
{
    public class SecureProvider
    {
        private int _state;

        public SecureProvider(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 55) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SecureProvider(55);
            Console.WriteLine(obj.dispatch(55));
        }
    }
}
