namespace AllSpice.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RecipeController : ControllerBase
{
    private readonly RecipesService _recipesService;
    private readonly Auth0Provider _auth0Provider;


    public RecipeController(RecipesService recipesService, Auth0Provider auth0Provider)
    {
        _auth0Provider = auth0Provider;
        _recipesService = recipesService;
    }


    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Recipe>> CreateRecipe([FromBody] Recipe recipeData)
    {
        try
        {
            Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            recipeData.CreatorId = userInfo.Id;
            // Recipe recipe = _recipesService.CreateRecipe(recipeData);
            return Ok();
        }
        catch (System.Exception)
        {

            throw;
        }
    }





    // public ActionResult<List<string>> GetAllRecipes()
    // {
    //     try
    //     {

    //     }
    //     catch (System.Exception)
    //     {

    //         throw;
    //     }
    // }
}