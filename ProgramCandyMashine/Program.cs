using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR_State;

namespace ProgramCandyMashine
{
    internal class Program
    {
        static void Main()
        {
            CandyMashine candyMashine = new CandyMashine(5);
            candyMashine.InsertQuarter();
            candyMashine.TurnCrank();

            candyMashine.InsertQuarter();
            candyMashine.TurnCrank();

            candyMashine.InsertQuarter();

            Console.WriteLine($"Оставшееся количество конфет: {candyMashine.CandyLeft}");
            Console.ReadLine();
        }
    }
}
