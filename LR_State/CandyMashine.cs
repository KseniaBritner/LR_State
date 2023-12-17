using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_State
{
    public partial class CandyMashine
    {
        public int CandyLeft { get; private set; }
        private IState _state;
        public CandyMashine(int сandyCount)
        {
            CandyLeft = сandyCount;
            _state = CandyLeft > 0 ? new No_quarters(this) : (IState)new Sold_out(this);
        }
        private void SetState(IState state)
        {
            _state = state;
        }
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            Dispense();
        }
        private void Dispense()
        {
            _state.Dispense();
        }
    }
}
