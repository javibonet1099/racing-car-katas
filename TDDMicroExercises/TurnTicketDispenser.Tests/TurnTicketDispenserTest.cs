using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDMicroExercises.TurnTicketDispenser.Tests
{
    public class TurnTicketDispenserTest
    {
        [Fact]
        public void Customer_Takes_Two_Ticket()
        {
            // Arrange
            var sequence = new TurnNumberSequence();
            var ticketDispenser = new TicketDispenser(sequence);

            // Act
            var firstTurnTicket = ticketDispenser.GetTurnTicket();

            var secondTurnTicket = ticketDispenser.GetTurnTicket();

            // Assert
            Assert.NotEqual(secondTurnTicket.TurnNumber, firstTurnTicket.TurnNumber);
        }

        [Fact]
        public void Different_Customers_Take_Ticket_At_The_Same_Time()
        {
            // Arrange
            var sequence = new TurnNumberSequence();
            var firstTicketDispenser = new TicketDispenser(sequence);

            // Act
            var firstTurnTicket = firstTicketDispenser.GetTurnTicket();

            var secondTicketDispenser = new TicketDispenser(sequence);

            var secondTurnTicket = secondTicketDispenser.GetTurnTicket();

            // Assert
            Assert.NotEqual(secondTurnTicket.TurnNumber, firstTurnTicket.TurnNumber);
        }
    }
}
