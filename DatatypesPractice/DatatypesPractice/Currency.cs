using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesPractice
{
    public class Currency
    {
       
        public double Value { get; set; }
        public string Type { get; set; }
        public Currency(double cValue, string cType)
        {
            this.Value = cValue;
            this.Type = cType;
        }
        public override string ToString()
        {
            return (this.Value + this.Type);
        }
        public Currency()
        {
        }
        public void SetValue(double cValue, string cType)
        {
            this.Value = cValue;
            this.Type = cType;
        }
        public void GetValue()
        {
            Console.WriteLine(this.Value + this.Type);

        }
    }
}