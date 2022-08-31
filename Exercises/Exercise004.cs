using System;
namespace Exercises
{
    public class Exercise004
    {
        const int gigaSeconds = 1000000000;
        public static DateTime AddGigaSecond(DateTime dateTime) => dateTime.AddSeconds(gigaSeconds);
        
    }
}
