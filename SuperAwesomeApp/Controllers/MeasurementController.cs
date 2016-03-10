using System.Web.Mvc;
using MeasurementConvert;
using SuperAwesomeApp.Models;

namespace SuperAwesomeApp.Controllers
{
    public class MeasurementController : Controller
    {
        //
        // GET: /Measurement/

        public ActionResult Index(MeasurementConversionClass anything)
        {
            if (anything.Input != 0)
                anything.Result = Converter.MeasurementConvertInputOutput(anything.Input, anything.InputUom, anything.ResultUom);
            return View(anything);
        }

    }
}
