using CorePDFReport.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wkhtmltopdf.NetCore;

namespace CorePDFReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly IGeneratePdf _generatePdf;

        public ValuesController(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }

        [HttpPost]
        [Route("Get/Meseros")]
        public async Task<IActionResult> Get(List<Mesero> meseros)
        
        {
            return await _generatePdf.GetPdf("Views/MeseroInfo.cshtml", meseros);
        }

        [HttpPost]
        [Route("Get/Clientes")]
        public async Task<IActionResult> Get2(List<Cliente> clientes)

        {
            return await _generatePdf.GetPdf("Views/ClienteInfo.cshtml", clientes);
        }

    }
}
