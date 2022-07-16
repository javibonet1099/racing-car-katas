using TDDMicroExercises.TelemetrySystem.Shared;
using Xunit;

namespace TDDMicroExercises.TelemetrySystem.Tests
{
    public class TelemetryDiagnosticControlsTest
    {
        [Fact]
        public void It_should_checkTransmission_send_a_diagnostic_message_and_receive_a_status_message_response()
        {
            //Arrange
            var telemetryDiagnostic = new TelemetryDiagnosticControls();

            //Act
            telemetryDiagnostic.CheckTransmission();

            //Assert
            Assert.Equal(DiagnosticMessages.DefaultMessage, telemetryDiagnostic.DiagnosticInfo);
        }
    }
}
