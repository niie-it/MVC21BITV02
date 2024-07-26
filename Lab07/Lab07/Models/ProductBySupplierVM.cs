namespace Lab07.Models
{
    public class ProductBySupplierVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set;}
        public double UnitPrice { get; set;}
        public string Status
        {
            get
            {
                if (UnitPrice > 50) return "Cheap";
                else return "Normal";
            }
        }
    }
}
