namespace AllSpice.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RecipeController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<string>> GetAllRecipes()
    {
        try
        {

        }
        catch (System.Exception)
        {

            throw;
        }
    }
}