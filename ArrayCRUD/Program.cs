using System;

namespace ArrayCRUD
{
    public class Program
    {
        private const int Index2 = 1;
        private const int LimitArray = 4;

        static void Main()
        {
            var sut = new SortedIntArray();
            var intArr = new[] { 2, 3, 4 };
            for (int i = 0; i < LimitArray; i++)
            {
                sut.Add(i);
                Console.WriteLine(sut[i]);
            }

            sut.Add(Index2);
            for (int i = 0; i < LimitArray + 1; i++)
            {
                Console.WriteLine(sut[i]);
            }

            Console.Read();
        }
    }
}
