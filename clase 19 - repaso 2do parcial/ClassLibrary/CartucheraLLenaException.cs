﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CartucheraLLenaException : Exception
    {
          public CartucheraLLenaException()
            :base("Cartuchera Llena")
        { }


    }
}
