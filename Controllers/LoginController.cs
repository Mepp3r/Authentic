using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    private ILoginData data;

    public LoginController(ILoginData data)
    {
        this.data = data;
    }

    [HttpPost]
    public ActionResult Login(Login login)
    {
        data.Verificacao(login);
        return View();
    }
}
