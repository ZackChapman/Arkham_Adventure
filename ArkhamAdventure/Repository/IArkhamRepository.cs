using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArkhamAdventure.Models;
using ArkhamAdventure.Models.ViewModels;

namespace ArkhamAdventure.Repository
{
    public interface IArkhamRepository
    {
        Scenario GetScenario(int? id);
        NavButtons GetNavButtons(int navId);
        NavOptions GetNavOptions(int navId);
        //ScenarioImages GetScenarioImages(int? imgId);
        Images GetImage(int? id);
    }
}
