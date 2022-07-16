using System;
using TDDMicroExercises.TelemetrySystem.Shared;

namespace TDDMicroExercises.TelemetrySystem
{
    public class TelemetryDiagnosticControls
    {
        private const string DiagnosticChannelConnectionString = "*111#";

        private readonly IConnection _connection;
        private readonly IDiagnostic _diagnostic;

        private string _diagnosticInfo = string.Empty;

        public TelemetryDiagnosticControls(IConnection connection, IDiagnostic diagnostic)
        {
            this._connection = connection;
            this._diagnostic = diagnostic;
        }

        public TelemetryDiagnosticControls() 
            : this(new Connection(), new TelemetryDiagnostic())
        { }

        public string DiagnosticInfo
        {
            get { return _diagnosticInfo; }
            set { _diagnosticInfo = value; }
        }

        public void CheckTransmission()
        {
            _diagnosticInfo = string.Empty;

            this._connection.Disconnect();

            int retryLeft = 3;

            while (this._connection.OnlineStatus == false && retryLeft > 0)
            {
                this._connection.Connect(DiagnosticChannelConnectionString);
                retryLeft -= 1;
            }

            if (this._connection.OnlineStatus == false)
            {
                throw new Exception("Unable to connect.");
            }

            this._diagnostic.Send(DiagnosticMessages.DefaultMessage);
            _diagnosticInfo = this._diagnostic.Receive();
        }
    }
}
