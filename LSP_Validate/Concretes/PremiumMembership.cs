using LSP_Validate.Abstracts;

namespace LSP_Validate.Concretes
{
    public class PremiumMembership : Membership,IFastDelivery,IPremiumDiscount
    {
        public string GetFastDelivery()
        {
            return "Ertesi gün teslimat";
        }
        public override string PlaceOrder()
        {
            return "Sipariş oluşturuldu.";
        }

        public string PremiumDiscountRate()
        {
            return "Her siparişte %3 indirim.";
        }

        public override string ReturnOrder()
        {
            return "İade talebi oluşturuldu.";
        }
        
    }
}
