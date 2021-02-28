﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public int ShiftNumber { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
    }
}