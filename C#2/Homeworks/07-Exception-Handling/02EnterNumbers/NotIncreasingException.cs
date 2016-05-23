using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NotIncreasingException : Exception
    {
        private string message;

        public NotIncreasingException()
        {
            //message = "Numbers are not increasing";

            //for the condition for bgcoder it has to print : Exception
            message = "Exception";
        }

        public override string Message
        {
            get { return message; }
        }
}