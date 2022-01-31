using System.ComponentModel.DataAnnotations.Schema;
namespace ML_Data
{
    public class ItemStock
    {
        [Column("0")]
        public string ItemID;

        [Column("1")]
        public float Loccode;

        [Column("2")]
        public float InQty;

        [Column("3")]
        public float OutQty;

        [Column("4")]
        public string ItemType;

        [Column("5")]
        public float TotalStockQty;
    }
    public class itemStockQtyPrediction
    {
        [Column("Score")]
        public float TotalStockQty;
    }
}
