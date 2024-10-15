using LSP_Validate.Abstract;
using LSP_Validate.Interfaces;

namespace LSP_Validate.Concretes
{
    public class DiamondMembership : Membership,IRewardPoint
    {
        public decimal AmountSpent { get; set; }

        public decimal CalculatePoint()
        {
            return AmountSpent * 0.05m;
        }

        public override string PlaceOrder()
        {
            return "Sipariş oluşturuldu.";
        }

        public override string ReturnOrder()
        {
            return "İade talebi oluşturuldu.";
        }
    }
}
