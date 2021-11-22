using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_9___Exercicio_Resolvido.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        //Constructor
        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            ValuePerHour = valueperhour;
            Hours = hours;
        }


        //Método
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
