﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSVModeling
{
    public interface IGenerator
    {
        double Next();
        void Refresh();
    }
}
