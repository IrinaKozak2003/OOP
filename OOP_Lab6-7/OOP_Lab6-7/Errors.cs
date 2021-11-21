using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{

        public class Error: Exception
        {
                private int value;

                public Error(string massesge, int value):base(massesge)
                {
                    this.value = value;
                }
        }
}