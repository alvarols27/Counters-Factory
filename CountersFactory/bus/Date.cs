using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CountersFactory.bus
{
    [Serializable]
    public struct Date
    {
        //1 Fields
        private int day;
        private int month;
        private int year;

        //2 Properties
        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        //3 Methods
        public Date()
        {
            this.day = 0;
            this.month = 0;
            this.year = 0;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string GetDateState()
        {
            string state;
            state = this.day + "/" + this.month + "/" + this.year;
            return state;
        }
    }
}
