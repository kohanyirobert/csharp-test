using System;

namespace IndexerTest
{
    class LotteryTicket
    {
        private int[] numbers = new int[5];

        internal LotteryTicket(int first, int second, int third, int fourth, int fifth)
        {
            numbers[0] = first;
            numbers[1] = second;
            numbers[2] = third;
            numbers[3] = fourth;
            numbers[4] = fifth;
        }

        internal int this[int i]
        {
            get { return numbers[i - 1];  }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            LotteryTicket ticket = new LotteryTicket(23, 34, 45, 56, 67);
            Console.WriteLine("The third number is {0}", ticket[3]);
            Console.ReadKey();
        }
    }
}