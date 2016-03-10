using AwesomeEnumerations;

namespace MeasurementConvert
{
    public class Converter
    {

        public static double MeasurementConvertInputOutput(int number, EnumSeparation.UnitsOfMeasure inputUom, EnumSeparation.UnitsOfMeasure outputUom)
        {
            switch (inputUom)
            {
                case EnumSeparation.UnitsOfMeasure.Feet:
                    number = number*12;
                    break;
                case EnumSeparation.UnitsOfMeasure.Yards:
                    number = number*36;
                    break;
            }

            switch (outputUom)
            {
                case EnumSeparation.UnitsOfMeasure.Feet:
                    number = number/12;
                    break;
                case EnumSeparation.UnitsOfMeasure.Yards:
                    number = number/36;
                    break;
            }
            return number;
        }
    }

    
}
