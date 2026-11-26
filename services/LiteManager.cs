using System;

namespace App
{
    public class DynamicRouter
    {
        private int _state;

        public DynamicRouter(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 84) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new DynamicRouter(84);
            Console.WriteLine(obj.handle(84));
        }
    }
}
