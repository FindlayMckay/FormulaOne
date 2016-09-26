/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * FormulaOne by Craig McKay <craig@southesk.com>
 * 
 * Who      When         Issue          Description
 * craig    26-Sep-2016  #              File created
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;

namespace FormulaOne.Model
{
    /// <summary>
    /// Driver represents the driver of car, with his time and points.
    /// </summary>
    public class Driver
    {
        private string name;
        private TimeSpan time;
        private int points;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

 
        public Driver()
        {

        }

        public Driver(string name)
        {
            this.name = name;
        }
    }

    /// <summary>
    /// Collection of Drivers, implementing the BubbleSort alogrithm.
    /// </summary>
    public class Drivers : List<Driver>
    {
        public void Score()
        {
            this.Sort();
            if (this.Count >= 1) this[0].Points = 3;
            if (this.Count >= 2) this[1].Points = 2;
            if (this.Count >= 3) this[2].Points = 1;
        }

        protected new void Sort()
        {
            Driver temp;
            bool swaps = true;
            while (swaps)
            {
                swaps = false;
                for (int i=0; i<this.Count-1;i++)
                {
                    if (this[i].Time > this[i + 1].Time)
                    {
                        temp = this[i];
                        this[i] = this[i+1];
                        this[i+1] = temp;
                        swaps = true;
                    }
                }
            }
        }
    }
}
