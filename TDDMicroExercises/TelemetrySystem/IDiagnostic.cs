using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TelemetrySystem
{
    /// <summary>
    /// Diagnostics
    /// </summary>
    public interface IDiagnostic
    {
        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Send(string message);

        /// <summary>
        /// Sends a status message.
        /// </summary>
        /// <returns>A message.</returns>
        string Receive();
    }
}
