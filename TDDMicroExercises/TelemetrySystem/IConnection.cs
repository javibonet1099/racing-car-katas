using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TelemetrySystem
{
    /// <summary>
    /// The database connection.
    /// </summary>
    public interface IConnection
    {
        bool OnlineStatus { get; }

        /// <summary>
        /// Connects to database.
        /// </summary>
        /// <param name="connection">Connetion string</param>
        void Connect(string connection);

        /// <summary>
        /// Disconnects the connection.
        /// </summary>
        void Disconnect();
    }
}
