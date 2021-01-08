using System;
using System.Collections.Generic;
using System.Text;

namespace interface_3_
{
    interface MusicPlayerInterface
    {
        void Switch(Boolean on);
        void play(Boolean on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();

    }
}
