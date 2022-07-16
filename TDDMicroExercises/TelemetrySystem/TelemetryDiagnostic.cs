using System;
using System.Collections.Generic;
using System.Text;
using TDDMicroExercises.TelemetrySystem.Shared;

namespace TDDMicroExercises.TelemetrySystem
{
    public class TelemetryDiagnostic : IDiagnostic
    {
        private bool _isDiagnosticDefaultMessage = false;

        private readonly Random _messageLenghtSimulator = new Random();

        public void Send(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException();
            }

            _isDiagnosticDefaultMessage = message == DiagnosticMessages.DefaultMessage;
        }

        public string Receive()
        {
            string message;

            if (_isDiagnosticDefaultMessage)
            {
                message = "LAST TX rate................ 100 MBPS\r\n"
                  + "HIGHEST TX rate............. 100 MBPS\r\n"
                  + "LAST RX rate................ 100 MBPS\r\n"
                  + "HIGHEST RX rate............. 100 MBPS\r\n"
                  + "BIT RATE.................... 100000000\r\n"
                  + "WORD LEN.................... 16\r\n"
                  + "WORD/FRAME.................. 511\r\n"
                  + "BITS/FRAME.................. 8192\r\n"
                  + "MODULATION TYPE............. PCM/FM\r\n"
                  + "TX Digital Los.............. 0.75\r\n"
                  + "RX Digital Los.............. 0.10\r\n"
                  + "BEP Test.................... -5\r\n"
                  + "Local Rtrn Count............ 00\r\n"
                  + "Remote Rtrn Count........... 00";
            }
            else
            {
                // simulate a received message
                message = string.Empty;

                int messageLenght = _messageLenghtSimulator.Next(50, 110);

                for (int i = messageLenght; i >= 0; --i)
                {
                    message += (char)_messageLenghtSimulator.Next(40, 126);
                }
            }

            return message;
        }
    }
}
