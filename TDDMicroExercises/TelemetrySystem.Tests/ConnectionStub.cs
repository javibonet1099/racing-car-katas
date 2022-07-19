using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TelemetrySystem.Tests
{
    public class ConnectionStub : IConnection
    {
        private bool _onlineStatus;

        public bool OnlineStatus
        {
            get { return _onlineStatus; } 
        }

        public void Connect(string connection)
        {
            return;
        }

        public void Disconnect()
        {
            return;
        }

        public void setConnectionStubStatus (bool status)
        {
            this._onlineStatus = status;
        }
    }
}
