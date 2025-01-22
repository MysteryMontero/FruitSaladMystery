using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSaladLibrary
{
    public class Strawberry : Fruit
    {
        public bool IsItGoodForJam { get; set; }
        public int SweetnessLevel { get; set; }
        public Strawberry(string color, double weight, bool isOrganic, bool isItGoodForJam, int sweetnessLevel) :
            base("Strawberry", color, weight, isOrganic)
        {
            SweetnessLevel = sweetnessLevel;
            IsItGoodForJam = isItGoodForJam;
        }
        //implementation of the abstract Describe method
        public override string Describe()
        {
            string jamLabel = IsItGoodForJam ? "Good for jam!" : "Holy mother of Joseph this sh** is nasty!";
            return $"{base.ToString()}, Sweetness Level: {SweetnessLevel}, {jamLabel}";
        }
    }
}
