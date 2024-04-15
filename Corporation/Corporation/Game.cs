using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporation
{
    public class Game
    {
        public Single Loan { get; set; }
        public Single BankBalance { get; set; }
        public Single Capital { get; set; }

        private Random randNum = new Random();

        public void NewGame()
        {

        }
        public Game()
        {
            Loan = 1000;
            BankBalance = 0;
        }

    }
    
}
