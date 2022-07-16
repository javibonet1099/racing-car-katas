using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TirePressureMonitoringSystem.Tests
{
    public class CorrectPressureSensorStub : ISensor
    {
        public double PopNextPressurePsiValue()
        {
            var random = new Random();
            return random.NextDouble() * (AlarmPressure.HighPressureThreshold - AlarmPressure.LowPressureThreshold) + AlarmPressure.LowPressureThreshold;
        }
    }
}
