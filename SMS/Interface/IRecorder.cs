using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IRecorder
    {
        string StartRecording();
        string StopRecording();
        string ScreenCapture();
        string Mic();
        string VCamera();
        string AVolume();

        string AudioSource();
    }
}
