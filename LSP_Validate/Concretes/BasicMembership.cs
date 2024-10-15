using LSP_Validate.Abstract;

namespace LSP_Validate.Concretes
{
    public class BasicMembership : Membership
    {
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
