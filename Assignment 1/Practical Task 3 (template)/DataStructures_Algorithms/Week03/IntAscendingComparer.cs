﻿using System;
using System.Collections.Generic;

namespace DataStructures_Algorithms.Week03
{
    public class IntAscendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y) return -1;
            else if (x > y) return 1;
            else return 0;
        }
    }
}
