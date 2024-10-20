using LSP_Validate.Abstract;
using LSP_Validate.Concretes;

namespace LSP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMembership basicMembership = new BasicMembership();
            string basicOrder = basicMembership.PlaceOrder();

            PremiumMembership premiumMembership = new PremiumMembership();
            premiumMembership.AmountSpent = 100;
            decimal resultPremiumPoint = premiumMembership.CalculatePoint();

            DiamondMembership diamondMembership = new DiamondMembership();
            diamondMembership.AmountSpent = 100;
            decimal resultDiamondPoint = diamondMembership.CalculatePoint();

            Console.WriteLine(basicOrder);

            Console.WriteLine($"Premium üye olduğunuz için bu siparişinizden {resultPremiumPoint} puan kazandınız. Bir sonraki siparişinizde kullanabilirsiniz.");

            Console.WriteLine($"Diamond üye olduğunuz için bu siparişinizden {resultDiamondPoint} puan kazandınız. Bir sonraki siparişinizde kullanabilirsiniz.");
        }
    }
}
