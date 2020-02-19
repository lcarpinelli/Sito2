using Sito2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sito2.Models
{
   public interface ICatalogoService
    {
        public List<CatalogoViewModel> GetCatalogo();
        public int GetWeight();
        public int GetRedApples();
        public double GetAverage();
        public int GetGreenApples();
        public double GetRedPercentual();
        public double GetGreenPercentual();
        public int GetApple();
        public InfoViewModel GetInfo();
    }
}
