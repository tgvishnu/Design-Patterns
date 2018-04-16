﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vishnu.Patterns.Behavioural.AdapterPattern
{
    public class BirdAdapter : IToyDuck
    {
        IBird _bird = null;

        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        public string Squeak()
        {
            return _bird.MakeSound();
        }
    }
}
