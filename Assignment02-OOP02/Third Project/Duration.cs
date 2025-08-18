using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_OOP02.Third_Project
{
    internal class Duration : IEquatable<Duration>
    {
        #region Q1 And Q2 

        #region Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        public Duration(int h, int m, int s)
        {
            this.Hours = h;
            this.Minutes = m;
            this.Seconds = s;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours},Minutes: {Minutes},Seconds: {Seconds}";
            else
                return $"Minutes: {Minutes},Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return this.Hours == other.Hours &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }
            return false;
        }


        public bool Equals(Duration? other)
        {
            if (other is null) return false;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        #endregion

        #region Operators overloading

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.ToSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.ToSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.ToSeconds() - d2.ToSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.ToSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2) => d1.ToSeconds() > d2.ToSeconds();
        public static bool operator <(Duration d1, Duration d2) => d1.ToSeconds() < d2.ToSeconds();
        public static bool operator >=(Duration d1, Duration d2) => d1.ToSeconds() >= d2.ToSeconds();
        public static bool operator <=(Duration d1, Duration d2) => d1.ToSeconds() <= d2.ToSeconds();

        public static bool operator true(Duration d) => d.ToSeconds() > 0;
        public static bool operator false(Duration d) => d.ToSeconds() <= 0;

        public static explicit operator DateTime(Duration d)
        {
            TimeSpan ts = new TimeSpan(d.Hours, d.Minutes, d.Seconds);
            return DateTime.Today.Add(ts);
        }


        private int ToSeconds() => Hours * 3600 + Minutes * 60 + Seconds;

        #endregion

        #endregion

    }
}
