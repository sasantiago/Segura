using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEGURA_ASSETMENTS.Models;
using System.Threading.Tasks;

namespace SEGURA_ASSETMENTS.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<Cliente> _userManager;
        private readonly SignInManager<Cliente> _signInManager;

        public LoginController(UserManager<Cliente> userManager, SignInManager<Cliente> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // POST: Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                // Verificar el login del usuario
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.contrasena, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Intento de inicio de sesión inválido.");
                    return View(model);
                }
            }

            // Si llegamos aquí, algo falló, redibujar el formulario
            return View(model);
        }

        // POST: Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
