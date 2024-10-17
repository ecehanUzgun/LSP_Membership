using LSP_Validate.Abstract;
using LSP_Validate.Concretes;

namespace LSP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiamondMembership diamondMembership = new DiamondMembership();
            diamondMembership.AmountSpent = 100;
            decimal resultDiamond = diamondMembership.CalculatePoint();

            PremiumMembership premiumMembership = new PremiumMembership();
            premiumMembership.AmountSpent = 100;
            decimal resultPremium = premiumMembership.CalculatePoint();

            BasicMembership basicMembership = new BasicMembership();
            string basicOrder = basicMembership.PlaceOrder();

            Console.WriteLine(basicOrder);
            Console.WriteLine(resultPremium);
            Console.WriteLine(resultDiamond);
        }
    }
}
