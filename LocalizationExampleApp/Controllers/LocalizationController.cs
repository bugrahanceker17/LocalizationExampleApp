using LocalizationExampleApp.Languages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationExampleApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocalizationController : Controller
{
    private readonly IStringLocalizer<Lang> _stringLocalizer;

    public LocalizationController(IStringLocalizer<Lang> stringLocalizer)
    {
        _stringLocalizer = stringLocalizer;
    }


    [HttpGet]
    public ActionResult Run()
    {
        string resultData = _stringLocalizer["Welcome"].Value;
        
        return Ok(new { Result = resultData});
    }
}