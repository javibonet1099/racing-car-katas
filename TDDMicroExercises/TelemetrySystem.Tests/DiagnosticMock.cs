using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TelemetrySystem.Tests
{
    public class DiagnosticMock : IDiagnostic
    {
        private string _expectedSendMessage;
        private string _actualSendMessage;
        private int _sendCallsCount = 0;

        private string _receiveReturnValue;
        private int _receiveCallsCount = 0;

        public void SetExpectedCallToSend(string extectedSendMessage)
        {
            _expectedSendMessage = extectedSendMessage;
        }

        public void SetExpectedCallToReceive(string returnValue)
        {
            _receiveReturnValue = returnValue;
        }

        public void Verify()
        {
            if (_sendCallsCount != 1)
            {
                throw new ArgumentOutOfRangeException("Send calls count", _sendCallsCount, "expected 1.");
            }

            if (_expectedSendMessage != _actualSendMessage)
            {
                throw new ArgumentOutOfRangeException("Send argument", _actualSendMessage, "expected '" + _extectedSendMessage + "'.");
            }

            if (_receiveCallsCount != 1)
            {
                throw new ArgumentOutOfRangeException("Receive calls count", _receiveCallsCount, "expected 1.");
            }
        }

        public void Send(string message)
        {
            _sendCallsCount += 1;
            _actualSendMessage = message;
        }

        public string Receive()
        {
            _receiveCallsCount += 1;
            return _receiveReturnValue;
        }
    }
}
