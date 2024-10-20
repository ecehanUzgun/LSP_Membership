﻿using LSP_Validate.Abstract;
using LSP_Validate.Interfaces;

namespace LSP_Validate.Concretes
{
    public class PremiumMembership : Membership,IRewardPoint
    {
        public decimal AmountSpent { get; set; }

        public decimal CalculatePoint()
        {
            return AmountSpent * 0.03m;
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
