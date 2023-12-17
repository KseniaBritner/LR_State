using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_State
{
    public partial class CandyMashine
    {
        protected class No_quarters : IState
        {
            private CandyMashine _mashine;
            public No_quarters(CandyMashine candy)
            {
                _mashine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Нет монетки");
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Монетка вставлена");
                _mashine.SetState(new Has_quarters(_mashine));
            }
            public void TurnCrank()
            {
                Console.WriteLine("Конфета не выдана, не вставлена монетка");
            }
            public void Dispense()
            {
                Console.WriteLine("Ничего не произошло");
            }
        }
    }
}
