using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TirePressureMonitoringSystem.Tests
{
    public class LowPressureSensorStub : ISensor
    {
        private double pressure = AlarmPressure.LowPressureThreshold;
        public double PopNextPressurePsiValue()
        {
            var random = new Random();
            return random.NextDouble() * pressure;
        }
    }
}
