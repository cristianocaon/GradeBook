using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int Count;

        public Stats()
        {
            this.Sum = 0.0;
            this.Count = 0;
            this.High = double.MinValue;
            this.Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            this.High = Math.Max(number, High);
            this.Low = Math.Min(number, Low);
        }
    }
}