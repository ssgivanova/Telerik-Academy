namespace RangeExceptions
{
    using System;

    //Define a class  InvalidRangeException<T>  that holds information about an error condition related
    //to invalid range. It should hold error message and a range definition [ start … end ].

    public class InvalidRangeException<T> : ApplicationException
    {
        public T StartRange { get;set;}
        public T EndRange{ get;set;}

        public InvalidRangeException(string message, T start, T end, Exception innerException) 
            : base(message, innerException)
        {
            this.StartRange = start;
            this.EndRange = end;
        }

        public InvalidRangeException(string message, T start, T end) 
            : base(message) { }

    }
}
