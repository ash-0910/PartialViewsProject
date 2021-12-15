using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialViewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Films> films;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            films = new List<Films>();

            films.Add(new Films()
            {
                Title = "Venom: Let There Be Carnage",
                Duration = "1h 37m",
                Description = "Eddie Brock is still struggling to coexist " +
                "with the shape-shifting extraterrestrial Venom. When deranged serial killer Cletus " +
                "Kasady also becomes host to an alien symbiote," +
                " Brock and Venom must put aside their differences to stop his reign of terror."
            });

            films.Add(new Films()
            {
                Title = "Red Notice",
                Duration = "1h 55m",
                Description = "In the world of international crime, " +
                "an Interpol agent attempts to hunt down and " +
                "capture the world's most wanted art thief"
            });

            films.Add(new Films()
            {
                Title = "Free Guy",
                Duration = "1h 55m",
                Description = "When a bank teller discovers he's actually a background player in an open-world video game, " +
                "he decides to become the hero of his own story -- one that he can rewrite himself. " +
                "In a world where there's no limits, he's determined to save the day his way before it's too late," +
                " and maybe find a little romance with the coder who conceived him."
            });

            films.Add(new Films()
            {
                Title = "Avengers: Endgame",
                Duration = "3h 2m",
                Description = "Adrift in space with no food or water, Tony Stark sends a message to Pepper Potts as his" +
                " oxygen supply starts to dwindle. Meanwhile, the remaining Avengers -- Thor, Black Widow, Captain America " +
                "and Bruce Banner -- must figure out a way to bring back their vanquished allies for an epic showdown with Thanos " +
                "-- the evil demigod who decimated the planet and the universe"
            });

        }

        public void OnGet()
        {

        }
    }
}
