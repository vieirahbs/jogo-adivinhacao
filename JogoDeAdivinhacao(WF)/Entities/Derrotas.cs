using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao_WF_.Entities
{
    class Derrotas
    {
        public int Amount { get; set; }

        public DateTime Date = DateTime.Now;

        public Derrotas()
        {
        }

        public Derrotas(int amount)
        {
            Amount = amount;
        }
    }
}
