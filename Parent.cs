using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY
{
    class Parent
    {
        public double Apple;
        public double Banana;
        public double Cherry;
        public double Grape;
        public double Mango;
        public double Orange;

        public double Syrah;
        public double Merlot;
        public double Riesling;
        public double Pinot;
        public double Chardonnay;
        public double Sauvignon;

        public double MilkShake;
        public double VanillaCone;
        public double ClasVanilla;
        public double VanMilkShake;
        public double ChocMilkShake;
        public double StrawMilkShake;

        public double itemscost1;
        public double itemscost2;
        public double itemscost3;
        public double itemscost;

        public double pApple =0.4;
        public double pBanana=1.8;
        public double pCherry=2.5;
        public double pGrape=2.3;
        public double pMango=1.89;
        public double pOrange=1.78;

        public double pSyrah=9.5;
        public double pMerlot=7.9;
        public double pRiesling=7.00;
        public double pPinot=7.5;
        public double pChardonnay=8.7;
        public double pSauvignon=9.3;

        public double pMilkShake=1.59;
        public double pVanillaCone=1.94;
        public double pClasVanilla=2.09;
        public double pVanMilkShake=2.9;
        public double pChocMilkShake=2.0;
        public double pStrawMilkShake=3.10;
        public double TaxCost;

        public double GetAmount()
        {
            itemscost1 = Apple + Banana + Cherry + Grape + Mango + Orange;
            itemscost2 = Syrah + Merlot + Riesling + Pinot + Chardonnay + Sauvignon;
            itemscost3 = MilkShake + VanillaCone + ClasVanilla + VanMilkShake + ChocMilkShake + StrawMilkShake;

            itemscost = itemscost1 + itemscost2 + itemscost3;
            return itemscost;

        }

        public double mcTaxRate = 0.15;

        public double cFIndTax(double cAmount)
        {
            double FindTax = cAmount * mcTaxRate;
            return FindTax;
        }

        public double GetTax()
        {
            TaxCost = cFIndTax(itemscost);
            return TaxCost;
        }
    }
}
