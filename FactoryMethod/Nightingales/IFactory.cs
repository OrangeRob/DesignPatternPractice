﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Nightingales
{
    internal interface IFactory
    {
        Nightingle CreateNightingle();
    }
}