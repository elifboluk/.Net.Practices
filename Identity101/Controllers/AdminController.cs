﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity101.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    //[AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }
    //deneme
}