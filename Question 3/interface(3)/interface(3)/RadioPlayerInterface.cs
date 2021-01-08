using System;
using System.Collections.Generic;
using System.Text;

namespace interface_3_
{
    interface RadioPlayerInterface
    {
        void Switch(Boolean on);
        void Return(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}
