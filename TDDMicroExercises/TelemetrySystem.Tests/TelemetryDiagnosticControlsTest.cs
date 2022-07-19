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
            var connection = new ConnectionStub();
            connection.setConnectionStubStatus(true);

            var mockTelemetryDataChannel = new DiagnosticMock();
            mockTelemetryDataChannel.SetExpectedCallToSend(DiagnosticMessages.DefaultMessage);
            mockTelemetryDataChannel.SetExpectedCallToReceive("status report");

            var target = new TelemetryDiagnosticControls(connection, mockTelemetryDataChannel);

            //Act
            target.CheckTransmission();

            //Assert
            mockTelemetryDataChannel.Verify();
            Assert.Equal("status report", target.DiagnosticInfo);
        }
    }
}
