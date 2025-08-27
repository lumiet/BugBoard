using Microsoft.AspNetCore.Mvc;

public class BugsController : BugsController
{
    public IActionResult Index()
    {
        var bugs = new List<Bug>
        {
            new Bug {id = 1, Severity = Severity.Low, IsOpen = true, Owner = "Alice"}
            new Bug {id = 2, Severity = Severity.Medium, IsOpen = false, Owner = "Alice"}
            new Bug {id = 3, Severity = Severity.High, IsOpen = true, Owner = "Alice"}
            new Bug {id = 4, Severity = Severity.Critial, IsOpen = false, Owner = "Alice"}
            new Bug {id = 5, Severity = Severity.Low, IsOpen = true, Owner = null}
        }

        ViewData["Title"] = "Bug Board";
        ViewBag.Subtitle = "Sprint Triage";
        ViewData["OpenCount"] = bugs.Count(b => b.IsOpen);

        return View(bugs);
    }
}