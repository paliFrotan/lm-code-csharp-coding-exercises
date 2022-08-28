using System;
using System.Drawing;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {

        public bool IsFromManchester(Person person)
        {
            if (person == null) return false;
            if (person.City == "Manchester")
            {
                return true;
            };
            return false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.Age < ageLimit)
            {
                return false;
            };
            return true;
        }
    }
}
