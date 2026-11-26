using System;

namespace App
{
    public class SecureWorker
    {
        private int _state;

        public SecureWorker(int seed) => _state = seed;

        public int build(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 82) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SecureWorker(82);
            Console.WriteLine(obj.build(82));
        }
    }
}
