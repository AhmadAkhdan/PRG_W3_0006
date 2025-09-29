using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string email, string password)
    {
        // contoh sederhana validasi
        if (email == "admin@example.com" && password == "12345")
        {
            // kalau login sukses, redirect ke dashboard
            return RedirectToAction("Index", "Dashboard");
        }

        ViewBag.Error = "Email atau password salah!";
        return View();
    }
}
