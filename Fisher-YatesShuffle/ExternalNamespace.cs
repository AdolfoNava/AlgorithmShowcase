﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?','!' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
