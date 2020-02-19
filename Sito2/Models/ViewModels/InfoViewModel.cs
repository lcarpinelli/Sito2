using Sito2.Models.Services.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sito2.Models.ViewModels
{
    public class InfoViewModel
    {
        public int FullWeight { get; set; }
        public int RedApples { get; set; }
        public double Average { get; set; }
        public int GreenApples { get; set; }
        public double RedPercentual { get; set; }
        public double GreenPercentual { get; set; }
        public int Apples { get; set; }

        public InfoViewModel(int full, int appleRed, double average,int appleGreen, double redPercentual, double greenPercentual, int apples)
        {
            FullWeight = full;
            RedApples = appleRed;
            Average = average;
            GreenApples = appleGreen;
            this.RedPercentual = redPercentual;
            this.GreenPercentual = greenPercentual;
            this.Apples = apples;
        }

    }
}
