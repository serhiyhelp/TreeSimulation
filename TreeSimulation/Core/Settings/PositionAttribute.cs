﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSimulation.Core.Settings
{
    [AttributeUsage(AttributeTargets.Property)]
    class PositionAttribute : Attribute
    {
        public PositionAttribute(int order)
        {
            Order = order;
        }

        public int Order { get; }
    }
}