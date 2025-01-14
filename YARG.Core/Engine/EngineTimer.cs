using System;

namespace YARG.Core.Engine
{
    public struct EngineTimer
    {
        private double _startTime;
        private double _timeThreshold;

        public EngineTimer(double threshold)
        {
            _startTime = double.MaxValue;
            _timeThreshold = threshold;
        }

        public void Start(double currentTime)
            => Start(ref _startTime, currentTime);

        public void StartWithOffset(double currentTime, double offset)
            => StartWithOffset(ref _startTime, currentTime, _timeThreshold, offset);

        public void Reset()
            => Reset(ref _startTime);

        public readonly bool IsActive(double currentTime)
            => IsActive(_startTime, currentTime, _timeThreshold);

        public readonly bool IsExpired(double currentTime)
            => IsExpired(_startTime, currentTime, _timeThreshold);

        public static void Start(ref double startTime, double currentTime)
        {
            startTime = currentTime;
        }

        public static void StartWithOffset(ref double startTime, double currentTime, double threshold, double offset)
        {
            double diff = Math.Abs(threshold - offset);
            startTime = currentTime - diff;
        }

        public static void Reset(ref double startTime)
        {
            startTime = double.MaxValue;
        }

        public static bool IsActive(double startTime, double currentTime, double threshold)
        {
            double elapsed = currentTime - startTime;
            return elapsed < threshold && elapsed >= 0;
        }

        public static bool IsExpired(double startTime, double currentTime, double threshold)
        {
            return currentTime - startTime >= threshold;
        }
    }
}