using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldTest
{
    public class Day
    {
        public string TodayIs(int day)
        {
            string currentday;
            switch (day)
            {
                case 1:
                    currentday = "Mon";
                    break;
                case 2:
                    currentday = "Tues";
                    break;
                case 3:
                    currentday = "Wed";
                    break;
                case 4:
                    currentday = "Thus";
                    break;
                case 5:
                    currentday = "Fri";
                    break;
                case 6:
                    currentday = "Sat";
                    break;
                case 7:
                    currentday = "Sun";
                    break;

                default:
                    currentday = "NA";
                    break;
            }

            return currentday;

        }

    }
}
