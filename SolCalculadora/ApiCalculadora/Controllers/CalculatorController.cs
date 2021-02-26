namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }
        
        [HttpPost]
        [Route("Subtracion")]
        public int Subtraction([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
        
        [HttpPost]
        [Route("Division")]
        public int Division([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }

    }
}
