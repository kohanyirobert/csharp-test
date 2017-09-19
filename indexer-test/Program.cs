using System;
using System.Runtime.CompilerServices;

namespace IndexerTest
{
    enum LotteryTicketNumberIndex
    {
        FIRST,
        SECOND,
        THIRD,
        FOURTH,
        FIFTH
    }

    class LotteryTicket
    {
        readonly int[] numbers = new int[5];

        public LotteryTicket(int first, int second, int third, int fourth, int fifth)
        {
            numbers[0] = first;
            numbers[1] = second;
            numbers[2] = third;
            numbers[3] = fourth;
            numbers[4] = fifth;
        }

        public int this[LotteryTicketNumberIndex i]
        {
            get { return numbers[(int)i]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LotteryTicket t = new LotteryTicket(12, 44, 54, 22, 23);
            Console.WriteLine("The first number is {0}", t[LotteryTicketNumberIndex.FIRST]);
            Console.WriteLine("The second number is {0}", t[LotteryTicketNumberIndex.SECOND]);
            Console.WriteLine("The third number is {0}", t[LotteryTicketNumberIndex.THIRD]);
            Console.WriteLine("The fourth number is {0}", t[LotteryTicketNumberIndex.FOURTH]);
            Console.WriteLine("The fifth number is {0}", t[LotteryTicketNumberIndex.FIFTH]);
            Console.ReadKey();
        }
    }
}