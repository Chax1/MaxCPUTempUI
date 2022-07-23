﻿namespace MaxCPUTempUI
{
    public static class Data
    {
        private static object _lock = new object();
        private static int _cpuTemperature;
        private static int _enteredTemperature;
        private static int _enteredTime;
        private static int _gpuTemperature;
        public static bool monitorMode;

        public static int ShutdownTemp
        {
            get
            {
                lock (_lock)
                {
                    return _enteredTemperature;
                }
            }
        }

        public static int ShutdownTime
        {
            get
            {
                lock (_lock)
                {
                    return _enteredTime;
                }
            }
        }

        public static int CPUTemperature
        {
            get
            {
                lock (_lock)
                {
                    return _cpuTemperature;
                }
            }
        }

        public static int GPUTemperature
        {
            get
            {
                lock (_lock)
                {
                    return _gpuTemperature;
                }
            }
        }

        public static void SetShutdownTemp(int Temp)
        {
            lock (_lock)
            {
                _enteredTemperature = Temp;
            }
        }

        public static void SetShutdownTime(int Time)
        {
            lock (_lock)
            {
                _enteredTime = Time;
            }
        }

        public static void SetCPUTemperature(int newTemp)
        {
            lock (_lock)
            {
                _cpuTemperature = newTemp;
            }
        }

        public static void SetGPUTemperature(int newTemp)
        {
            lock (_lock)
            {
                _gpuTemperature = newTemp;
            }
        }
    }
}