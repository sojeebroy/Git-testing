﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    interface RadioPlayerInterface
    {
        void Switch(bool on);
        void retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();

    }
}
