﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Polje
    {
        public Polje(int redak, int stupac)
        {
            Redak = redak;
            Stupac = stupac;
        }

        public readonly int Redak;
        public readonly int Stupac;
    }
}
