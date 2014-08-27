﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.Maps;


namespace XamFormsGPSDependency.DependencySvcGps
{
    public interface IGeoLocation
    {
        Position GetCurrentPosition();

        void InitLocationService();

        void StopLocationService();

    }
}
