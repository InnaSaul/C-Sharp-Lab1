using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxSequence = 0;
            int CurrentSequence;
            int MaxSequenceNumber = 0;
            int CurrentSequenceNumber;
            int FinalSequenceNumber = 1000000;
            for (var i = 2; i <= FinalSequenceNumber; i++)
            {
                CurrentSequenceNumber = i;
                CurrentSequence = 0;
                while (CurrentSequenceNumber != 1)
                {
                    if (CurrentSequenceNumber % 2 == 0)
                    {
                        CurrentSequenceNumber = CurrentSequenceNumber/2;
                    }
                    else
                    {
                        CurrentSequenceNumber = ((3 * CurrentSequenceNumber) + 1) / 2;
                    }
                    CurrentSequence++;
                }
                    if (CurrentSequence > MaxSequence)
                    {
                        MaxSequence = CurrentSequence;
                        MaxSequenceNumber = i;
                    }
            }
            Console.WriteLine("Наибольшую последовательность Коллатца =" + MaxSequence + "\n" + "Имеет число = " + MaxSequenceNumber);
        }
    }
}
