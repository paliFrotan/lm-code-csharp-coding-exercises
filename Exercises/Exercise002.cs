using System;
using System.Drawing;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {

        public bool IsFromManchester(Person person) => (person==null) ? false : person.City == "Manchester";
        
        public bool CanWatchFilm(Person person, int ageLimit) => person.Age >= ageLimit;
        
    }
}
