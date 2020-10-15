using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T Value;
        public Box(T value)
        {
            Value = value;
        }

       
        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
