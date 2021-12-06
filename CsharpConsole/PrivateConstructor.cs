using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConsole
{
    class PrivateConstructor
    {
        private PrivateConstructor() // Private Constructor
        {

        }
        public static string GetCalled() // Display Private Constructor Method Called
        {
            return "Private Constructor => Private Constructor Called";
        }
    }
}