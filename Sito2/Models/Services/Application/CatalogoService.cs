using Sito2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sito2.Models.Services.Application
{
    public class CatalogoService:ICatalogoService
    {
        public List<CatalogoViewModel> GetCatalogo()
        {
            List<CatalogoViewModel> apples = new List<CatalogoViewModel>
                {
                new CatalogoViewModel { Color = "Red", Weight = 180, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 195, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 190, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Red", Weight = 200, Origin ="Usa"},
                new CatalogoViewModel { Color = "Green", Weight = 170, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 168, Origin ="Usa"},
                new CatalogoViewModel { Color = "Green", Weight = 193, Origin ="Italy"},
                new CatalogoViewModel { Color = "Red", Weight = 176, Origin ="France"},
                new CatalogoViewModel { Color = "Green", Weight = 210, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Red", Weight = 169, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 180, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Green", Weight = 183, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 195, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 213, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 196, Origin ="Italy"},                
                new CatalogoViewModel { Color = "Green", Weight = 210, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Red", Weight = 169, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 180, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Green", Weight = 183, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 195, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 213, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 196, Origin ="Italy"},               
                new CatalogoViewModel { Color = "Green", Weight = 210, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Red", Weight = 169, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 180, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Green", Weight = 183, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 195, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 213, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 196, Origin ="Italy"},                
                new CatalogoViewModel { Color = "Red", Weight = 180, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 195, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 190, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Red", Weight = 200, Origin ="Usa"},
                new CatalogoViewModel { Color = "Green", Weight = 170, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 168, Origin ="Usa"},
                new CatalogoViewModel { Color = "Green", Weight = 193, Origin ="Italy"},
                new CatalogoViewModel { Color = "Red", Weight = 176, Origin ="France"},
                new CatalogoViewModel { Color = "Green", Weight = 210, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Red", Weight = 169, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 180, Origin ="Germany"},
                new CatalogoViewModel { Color = "Red", Weight = 185, Origin ="Uk"},
                new CatalogoViewModel { Color = "Green", Weight = 183, Origin ="France"},
                new CatalogoViewModel { Color = "Red", Weight = 195, Origin ="Italy"},
                new CatalogoViewModel { Color = "Green", Weight = 213, Origin ="Ireland"},
                new CatalogoViewModel { Color = "Green", Weight = 196, Origin ="Italy"},                
                };
            return apples;
        }

        public int GetRedApples()
        {
            List<CatalogoViewModel> apples = GetCatalogo();
            int redAppleCount = apples.Where(apple=>apple.Color=="Red").Count();
            return redAppleCount;
        }

        public int GetWeight()
        {
            List<CatalogoViewModel> apples = GetCatalogo();
            int Weight = apples.Select(apple => apple.Weight).Sum();
            return Weight;           
        }
        public double GetAverage()
        {
            List<CatalogoViewModel> apples = GetCatalogo();
            double Average = apples.Select(apple => apple.Weight).Average();
            return Average;           
        }
        public int GetGreenApples()
        {
            List<CatalogoViewModel> apples = GetCatalogo();
            int GreenAppleCount = apples.Where(apple => apple.Color == "Green").Count();
            return GreenAppleCount;
        }
        public int GetApple()
        {
            int apples = GetRedApples() + GetGreenApples();
            return apples;
        }
        public double GetRedPercentual()
        {
            int x = GetRedApples() * 100;
            double value = x / (GetApple());
            return value;
        }       
        public double GetGreenPercentual()
        {
            int x = GetGreenApples() * 100;
            double value = x / (GetApple());
            return value;
        }

        public InfoViewModel GetInfo()
        {
            InfoViewModel info = new InfoViewModel(GetWeight(),GetRedApples(),GetAverage(),GetGreenApples(),GetRedPercentual(),GetGreenPercentual(),GetApple());
            return info;
        }

        
    }
}
