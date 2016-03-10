using AwesomeEnumerations;

namespace SuperAwesomeApp.Models
{
    public class MeasurementConversionClass
    {
        public double Result { get; set; }
        public int Input { get; set; }
        public EnumSeparation.UnitsOfMeasure InputUom { get; set; }
        public EnumSeparation.UnitsOfMeasure ResultUom { get; set; }
    }

    
}