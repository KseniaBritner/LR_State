using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_State
{
    public partial class CandyMashine
    {
        protected class Sold_out : IState
        {
            private CandyMashine _mashine;
            public Sold_out(CandyMashine candy)
            {
                _mashine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Монета возвращена");
            }
            public void InsertQuarter()
            {
                EjectQuarter();
            }
            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло");
            }
            public void Dispense()
            {
                Console.WriteLine("Ничего не произошло");
            }
        }
    }
}
