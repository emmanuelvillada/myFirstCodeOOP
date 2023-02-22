using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Date
    {
        public int _year;
        public int _month;
        public int _day;

        public Date(int year, int month, int day)
        {
            this._year = year;
            this._month = Validate_month(month);
            this._day = Validate_day(day,month);
        }

        public override string ToString()
        {
            return $"year : {_year} month : {_month} day : {_day} ";
        }

        private int Validate_day(int day, int month)
        {
            if(month == 1 || month == 3 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 0 && day <= 31)
                {
                    return day;
                }
            }else if(month == 2)
            {
                if (day > 0 && day <= 28)
                {
                    return day;
                }

            }
            else
            {
                if (day > 0 && day <= 30)
                {
                    return day;
                }

            }
            throw new Exception("el dia no es valido");
        }

        private int Validate_month(int month)
        {
            if (_month > 0 && _month < 12)
            {
                return month;
            }
            throw new  MonthException("El mes ingresado no es el correcto");
        }

        private int Validate_year(int year)
        {
            if (_year >= 1900)
            {
                return year;
            }
            throw new YearException("El año ingresado no es valido");
        }
    }
}
