﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumSharp.Core.Extensions
{
    public static partial class NDArrayExtensions
    {
        public static int Sum<TData>(this NDArrayGeneric<TData> np, NDArrayGeneric<TData> np2)
        {
            int result = 0;
            for(int i = 0; i < np.Size; i++)
            {
                if(np[i].Equals(np2[i]))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
