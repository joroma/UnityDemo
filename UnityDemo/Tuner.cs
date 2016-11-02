﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public class Tuner : ITuner
    {
        public string Manufacturer()
        {
            return "Tesla Labs";
        }

        public int TunedFrequence()
        {
            return (int)99.8;
        }

        public bool SelfCheck()
        {
            return true;
        }

        public string SerialNumber()
        {
            return "095345890";
        }
    }
}