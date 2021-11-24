using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao_WF_.Entities
{
    class Vitorias
    {
        public int Amount { get; set; }
        public int TentativesAmount { get; set; }

        public DateTime Date = DateTime.Now;

        public Vitorias()
        {
        }

        public Vitorias(int amount, int tentativesAmount)
        {
            Amount = amount;
            TentativesAmount = tentativesAmount;
            
        }
    }
}
