using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxSequence = 0;
            int CurrentSequence=0;
            int MaxSequenceNumber = 0;
            long CurrentSequenceNumber;
            int FinalSequenceNumber = 27;
            for (var i = 2; i <= FinalSequenceNumber; i++)
            {
                CurrentSequenceNumber = i;
                
                while (CurrentSequenceNumber != 1)
                {
                    CurrentSequence++;
                    if (CurrentSequenceNumber % 2 == 0)
                    {
                        CurrentSequenceNumber = CurrentSequenceNumber/2;
                    }
                    else
                    {
                        CurrentSequenceNumber = (3 * CurrentSequenceNumber + 1) ;
                    }
                    //CurrentSequence++;
                }
                    if (CurrentSequence > MaxSequence)
                    {
                        MaxSequence = CurrentSequence;
                        MaxSequenceNumber = i;
                    }
                CurrentSequence = 0;
            }
            Console.WriteLine("Наибольшую последовательность Коллатца = " + MaxSequence + " Имеет число = " + MaxSequenceNumber);
        }
    }
}
