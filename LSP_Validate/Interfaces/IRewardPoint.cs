namespace LSP_Validate.Interfaces
{
    public interface IRewardPoint
    {
        public decimal AmountSpent { get; set; }
        public decimal CalculatePoint();
    }
}
