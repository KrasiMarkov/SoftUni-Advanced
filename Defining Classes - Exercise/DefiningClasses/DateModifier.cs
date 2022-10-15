using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
       

        public void CalculateDiffOfDays(string firstDate, string secondDate)
        {
            DateTime firstDateTime = DateTime.Parse(firstDate);

            DateTime secondDateTime = DateTime.Parse(secondDate);

            double diff = Math.Abs((firstDateTime - secondDateTime).TotalDays);

            Console.WriteLine(diff);

        }


    }
}
