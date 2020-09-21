﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MLForecastModel.Models
{
    class ModelOutput
    {
        public float[] ForecastedRentals { get; set; }
        public float[] LowerBoundRentals { get; set; }
        public float[] UpperBoundRentals { get; set; }

    }
}
