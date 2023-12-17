using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_State
{
    public partial class CandyMashine
    {
        protected class Sold : IState
        {
            protected CandyMashine _mashine;
            public Sold(CandyMashine candy)
            {
                _mashine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }
            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло");
            }
            public void Dispense()
            {
                Console.WriteLine("Конфета выдана");
                if (_mashine.CandyLeft > 0)
                {
                    _mashine.SetState(new No_quarters(_mashine));
                }
                else
                {
                    _mashine.SetState(new Sold_out(_mashine));
                }
            }
        }
    }
}
