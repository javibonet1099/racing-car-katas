using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TurnNumberSequence : ITurnNumberSequence
    {
        // Removed static
        private int _turnNumber = 0;

        // Removed static
        public int GetNextTurnNumber()
        {
            return _turnNumber++;
        }
    }
}
