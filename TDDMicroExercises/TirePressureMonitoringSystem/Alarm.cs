namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        // Removed and moved to another file to be able
        // to use them in other files.
        //private const double LowPressureThreshold = 17;
        //private const double HighPressureThreshold = 21;

        // 1. Allow different types of Sensor
        //Sensor _sensor = new Sensor();
        // Changed to 
        private readonly ISensor _sensor;

        bool _alarmOn = false;
        //private long _alarmCount = 0;

        // 2. Created a constructor to allow DIP
        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < AlarmPressure.LowPressureThreshold || AlarmPressure.HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
                // Removed due to it's not necessary
                //_alarmCount += 1;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
