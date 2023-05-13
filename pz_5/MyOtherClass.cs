using System;
using System.Collections.Generic;
using System.Text;

namespace pz_5
{
    public class MyOtherClass : ICloneable
    {
        private string stringValue;

        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        public override string ToString()
        {
            return StringValue;
        }

        public object Clone()
        {
            MyOtherClass clone = new MyOtherClass();
            clone.StringValue = this.StringValue;
            return clone;
        }
    }

    public class MyClass : ICloneable, IComparable<MyClass>
    {
        private int intValue;
        private DateTime dateValue;
        private MyOtherClass myOtherClassValue;

        public int IntValue
        {
            get { return intValue; }
            set { intValue = value; }
        }

        public DateTime DateValue
        {
            get { return dateValue; }
            set { dateValue = value; }
        }

        public MyOtherClass MyOtherClassValue
        {
            get { return myOtherClassValue; }
            set { myOtherClassValue = value; }
        }

        public override string ToString()
        {
            return $"IntValue: {intValue}, DateValue: {dateValue}, MyOtherClassValue: {myOtherClassValue}";
        }

        public object Clone()
        {
            MyClass clone = new MyClass();
            clone.IntValue = this.IntValue;
            clone.DateValue = this.DateValue;
            clone.MyOtherClassValue = (MyOtherClass)this.MyOtherClassValue.Clone();
            return clone;
        }

        public int CompareTo(MyClass other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.IntValue.CompareTo(other.IntValue);
        }
    }
}
