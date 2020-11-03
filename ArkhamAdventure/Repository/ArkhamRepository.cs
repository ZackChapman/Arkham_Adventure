using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using ArkhamAdventure.Models;
using Microsoft.EntityFrameworkCore;
using ArkhamAdventure.Models.ViewModels;

namespace ArkhamAdventure.Repository
{
    public class ArkhamRepository : IArkhamRepository
    {
        private ArkhamAdventureDBContext db;

        public ArkhamRepository(ArkhamAdventureDBContext _db)
        {
            db = _db;
        }
        public Scenario GetScenario(int? id)
        {
            if (db != null)
            {
                id ??= 1;
                var list =  GetScenarios();
                return list.FirstOrDefault(x => x.ScenarioId == id);
            }
            return null;
        }
        public NavButtons GetNavButtons(int navId)
        {
            if (db != null)
            {
               return db.NavButtons.FirstOrDefault(x => x.NavigationId == navId);
            }
            return null;
        }
        public NavOptions GetNavOptions(int navId)
        {
            if (db != null)
            {
                return db.NavOptions.FirstOrDefault(x => x.NavigationId == navId);
            }
            return null;
        }
        public Images GetImage(int? imgId)
        {
            var img = new Images();
            img = db.Images.FirstOrDefault(i => i.ImageID == imgId);
            if (img != null)
            {
                var imageBase64Data = Convert.ToBase64String(img.Image);
                img.ImageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                return img;
            }
            return null;
        }

        private List<Scenario> GetScenarios()
        {
            try
            {
                return db.Scenario.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
