
using Library.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers;

[Route("controller")]
public class DocumentTypesController : Controller
{
    private readonly ILogger<DocumentTypesController> _logger;

    private readonly AppDbContext _dbContext;

    public DocumentTypesController(ILogger<DocumentTypesController> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var ListDocumentTypes = await _dbContext.DocumentTypes.ToListAsync();
        return View(ListDocumentTypes);
    }
    public IActionResult Create()
    {
        return View();
    }
    public async Task<IActionResult> Create(DocumentTypesController documentTypesController)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Add(documentTypesController);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }else
        {
            _logger.LogError("Error saving");
            return View(documentTypesController);
        }
        
    }

    public IActionResult Delete()
    {
        _logger.LogInformation("LLego al Controlador");
        return View();
    }
    public IActionResult Details()
    {
        _logger.LogInformation("LLego al Controlador");
        return View();
    }
    public IActionResult Edit()
    {
        _logger.LogInformation("LLego al Controlador");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
