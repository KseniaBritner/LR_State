using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_State
{
    public partial class CandyMashine
    {
        protected class Has_quarters : IState
        {
            private CandyMashine _mashine;
            public Has_quarters(CandyMashine candy)
            {
                _mashine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Монетка возвращена");
                _mashine.SetState(new No_quarters(_mashine));
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Монетка уже вставлена");
                _mashine.SetState(new Sold(_mashine));
            }
            public void TurnCrank()
            {
                _mashine.Dispense();
                _mashine.SetState(new Sold(_mashine));
            }
            public void Dispense()
            {
                Console.WriteLine("Ничего не произошло");
            }
        }
    }
}
