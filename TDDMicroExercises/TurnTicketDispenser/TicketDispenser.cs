using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TicketDispenser
    {
        private readonly ITurnNumberSequence _sequence;

        // Added dependency injection
        public TicketDispenser(ITurnNumberSequence sequence)
        {
            this._sequence = sequence;
        }

        public TurnTicket GetTurnTicket()
        {
            int newTurnNumber = this._sequence.GetNextTurnNumber();
            TurnTicket newTurnTicket = new TurnTicket(newTurnNumber);

            return newTurnTicket;
        }
    }
}
