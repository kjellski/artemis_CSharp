﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artemis;
using Artemis.Attributes;

namespace ConsoleApplication1
{
    [ArtemisComponentPool(InitialSize=10,Resizes=false)]
    public class Power : ComponentPoolable
    {
        public int POWER;

        [ArtemisComponentCreate]
        public static Power CreateInstance(Type type)
        {
            return new Power();            
        }

        #region ComponentPoolable Members

        public void Initialize()
        {            
        }

        public void Cleanup()
        {
        }

        #endregion
    }
}
