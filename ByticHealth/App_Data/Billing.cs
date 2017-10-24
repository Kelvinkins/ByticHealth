using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Remark { get; set; }
        public decimal GrandTotal { get; set; }
    }

    public class BillDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillDetailID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("DrugID")]
        public virtual Drug Drug { get; set; }
        public int DrugID { get; set; }

        [ForeignKey("BillID")]
        public virtual Bill Bill { get; set; }
        public int? BillID { get; set; }

    }
}
