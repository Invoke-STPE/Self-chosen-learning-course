﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
