﻿using System;
namespace Moment
{
    public interface IinstrumentCalculator
    {
        void addElement(double num);
        double firstMomentAbout(double moment);
    }
}
