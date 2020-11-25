﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();
    }
}
