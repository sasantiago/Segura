using Microsoft.AspNetCore.Mvc;
using SEGURA_ASSETMENTS.Data;
using System.Collections.Generic;
using System.Linq;

public class SedesController : Controller
{
    private readonly SEGURA_ASSETMENTSContext _context;

    public SedesController(SEGURA_ASSETMENTSContext context)
    {
        _context = context;
    }

    // Acción para obtener la lista de sedes
    public IActionResult Index()
    {
        var sedes = _context.Sedes.ToList();
        return View(sedes); // Pasa la lista de sedes a la vista
    }
}
