using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TesteMVC.Repositorio;
using TesteMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace TesteMVC.Controllers;

public class EscolaController(IEscolaRepositorio escolaRepositorio) : Controller
{
    private readonly IEscolaRepositorio _escolaRepositorio = escolaRepositorio;

    public IActionResult Index()
    {
        List<EscolaModel> escolas = _escolaRepositorio.ListaEscola();
        var groupedEscolas = escolas.GroupBy(e => e.Ra)
                            .OrderBy(g => g.Key)
                            .ToList();

        return View(groupedEscolas);
    }

    [HttpGet]
    public IActionResult Api()
    {
        List<EscolaModel> escolas = _escolaRepositorio.ListaEscola();

        
        string json = JsonConvert.SerializeObject(escolas, new JsonSerializerSettings {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        });

        
            
        return Content(json);
    }
}
