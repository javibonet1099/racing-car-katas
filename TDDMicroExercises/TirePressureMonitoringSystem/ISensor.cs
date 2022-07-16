using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    // Interface to follow Interface Segreagation Principable
    // Implementation of Sensor.
    public interface ISensor
    {
        double PopNextPressurePsiValue();
    }
}
