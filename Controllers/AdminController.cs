﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CulinaryForum.Controllers;

[Authorize(Policy = "Admin")]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}