using LSP_Validate.Abstracts;

namespace LSP_Validate.Concretes
{
    public class PremiumMembership : Membership,IFastDelivery
    {
        public string GetFastDelivery()
        {
            return "1-3 iş günü içinde teslimat";
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
