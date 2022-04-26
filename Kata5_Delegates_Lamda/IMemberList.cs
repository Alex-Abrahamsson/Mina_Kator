﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata5_Delegates_Lamda
{
    interface IMemberList
    {
        public IMember this[int idx] { get; }  
        
        int Count();
        int Count(int year);
        void Sort();
    }
}
