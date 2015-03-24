namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeException<T> : ApplicationException
    {
        public T StartValue { get; set; }
        public T EndValue { get; set; }

        public InvalidRangeException(string message, T start, T end, Exception e)
            : base("Parameters out of range.")
        {
            this.StartValue = start;
            this.EndValue = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) 
        {
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

    }
}
