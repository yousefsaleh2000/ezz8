﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blank.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty(SupportsGet=true)]
    public string name { get; set; } = "world";

    public void OnGet()
    {
      ViewData["name"] = $"{name}";
    }
}
