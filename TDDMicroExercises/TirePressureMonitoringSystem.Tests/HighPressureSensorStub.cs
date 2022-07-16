using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TirePressureMonitoringSystem.Tests
{
    public class HighPressureSensorStub : ISensor
    {
        private double pressure = AlarmPressure.HighPressureThreshold;

        public double PopNextPressurePsiValue()
        {
            var random = new Random();
            return random.NextDouble() * (50.0 - pressure) + pressure;
        }
    }
}
