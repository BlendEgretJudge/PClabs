using System;

namespace App
{
    public class StreamLoader
    {
        private int _state;

        public StreamLoader(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 29) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamLoader(29);
            Console.WriteLine(obj.dispatch(29));
        }
    }
}
