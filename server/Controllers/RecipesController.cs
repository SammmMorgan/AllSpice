namespace AllSpice.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RecipeController : ControllerBase
{
    private readonly RecipeService _recipeService;
    private readonly Auth0Provider _auth0Provider;


    public RecipeController(RecipeService recipeService, Auth0Provider auth0Provider)
    {
        _auth0Provider = auth0Provider;
        _recipeService = recipeService;
    }


    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Recipe>> CreateRecipe([FromBody] Recipe recipeData)
    {
        try
        {
            Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            recipeData.CreatorId = userInfo.Id;
            Recipe recipe = _recipeService.CreateRecipe(recipeData);
            return Ok(recipe);
        }
        catch (System.Exception)
        {

            throw;
        }
    }





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