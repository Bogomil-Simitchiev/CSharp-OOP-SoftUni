using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int maxValue;
        private int minValue;
        public MyRangeAttribute(int minValue,int maxValue)
        {
            this.maxValue = maxValue;
            this.minValue = minValue;
        }

        public override bool IsValid(object obj)
        {
            int inputInt = (int)obj;
            if (inputInt<minValue||inputInt>maxValue)
            {
                return false;
            }

            return true;
        }
    }
}
