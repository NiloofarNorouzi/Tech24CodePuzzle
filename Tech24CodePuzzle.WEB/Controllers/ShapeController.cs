using Microsoft.AspNetCore.Mvc;

namespace Tech24CodePuzzle.WEB.Controllers
{
    public class ShapeController : Controller
    {
        private readonly ShapeCommandParser _parser;

        public ShapeController()
        {
            _parser = new ShapeCommandParser();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DrawShape(string shapeCommand)
        {
            try
            {

                if (string.IsNullOrEmpty(shapeCommand))
                {
                    ViewBag.ErrorMessage = "Please enter a valid shape description.";
                    return View("Index");
                }

                var shape = _parser.ParseInput(shapeCommand);

                if (shape != null)
                {
                    ViewBag.shapeName = shape.Name;
                    ViewBag.shapeDimensions = shape.Dimensions;
                }
                else
                {
                    ViewBag.shapeName = null;
                    ViewBag.shapeDimensions = null;
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            return View("Index");
        }
    }
}
