﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo
    {
        public DateTime StartupTime { get; init; }
        public Demo()
        {
            StartupTime = DateTime.Now;
        }
    }
}