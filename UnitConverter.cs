using System;
using System.Collections.Generic;
namespace ConvernterExweek1
{
    class UnitConverter
    {
        int ratio;
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }
        public int Convert (int unit)
        {
            return unit * ratio;
        }
    }

    class Program
    {
        static void Main(string[] args)
            //behaviour อยู่ในmain
        {
            UnitConverter feetToInchCoverter = new UnitConverter(12);
            UnitConverter mileToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchCoverter.Convert(30));
            Console.WriteLine(feetToInchCoverter.Convert(100));
            Console.WriteLine(feetToInchCoverter.Convert(mileToFeetConverter.Convert(1)));

        }
    }
}
