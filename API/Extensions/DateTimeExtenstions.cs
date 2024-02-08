using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class DateTimeExtenstions
    {
        public static int CalculateAge(this DateOnly dbo)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            var age = today.Year - dbo.Year;
            if (dbo > today.AddYears(-age)) age--;
            return age;
        }
    }
}