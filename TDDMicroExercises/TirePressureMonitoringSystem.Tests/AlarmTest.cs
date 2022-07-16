using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem.Tests
{
    public class AlarmTest
    {
        [Fact]
        public void Pressure_Is_Lower()
        {
            // arrange
            var sensor = new LowPressureSensorStub();
            var alarm = new Alarm(sensor);
            
            // act
            alarm.Check();

            // assert
            Assert.True(alarm.AlarmOn);
        }

        [Fact]
        public void Pressure_Is_Higher()
        {
            // arrange
            var sensor = new HighPressureSensorStub();
            var alarm = new Alarm(sensor);

            // act
            alarm.Check();
            
            // assert
            Assert.True(alarm.AlarmOn);
        }

        [Fact]
        public void Pressure_Is_Correct()
        {
            // arrange
            var sensor = new CorrectPressureSensorStub();
            var alarm = new Alarm(sensor);

            // act
            alarm.Check();

            // assert
            Assert.False(alarm.AlarmOn);
        }
    }
}
