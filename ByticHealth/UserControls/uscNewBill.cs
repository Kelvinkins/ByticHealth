using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByticHealth.App_Data;

namespace ByticHealth.UserControls
{



    public partial class uscNewBill : UserControl
    {
        BHModel db = new BHModel();
        public static List<Product> Products=new List<Product>();
        public static Patient patient;
        public uscNewBill()
        {
            InitializeComponent();
        }
        public uscNewBill(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = (int)cmbItem.SelectedValue,
                Description = cmbItem.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Qty = Convert.ToInt32(txtQty.Text),
            };
            product.Total = product.Qty * product.Price;

            var existingProduct = Products.Where(p => p.ProductID == product.ProductID).ToList();
            if (existingProduct.Count()==0)
            {
                Products.Add(product);
            }else
            {
                MessageBox.Show("Sorry, this item already exists in the list. Consider updating it if you wish to make changes to the item.");

            }
            txtGrandTotal.Text = Products.ToList().Sum(s=>s.Total).ToString();
            dgvLineItems.DataSource = Products.ToList();
        }

        private void uscNewBill_Load(object sender, EventArgs e)
        {
            cmbItem.DataSource = db.Drugs.ToList();
            cmbItem.ValueMember = "DrugID";
            cmbItem.DisplayMember = "DrugName";
            dgvLineItems.DataSource = Products.ToList();
            txtGrandTotal.Text = Products.ToList().Sum(s => s.Total).ToString();

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int DrugID = Convert.ToInt32(cmbItem.SelectedValue);
                var drugPrice = db.Drugs.Find(DrugID).SalePrice;
                txtPrice.Text = drugPrice.ToString();
            }catch(Exception)
            {

            }
        }

        private void btnPostBill_Click(object sender, EventArgs e)
        {
            var bill = new Bill
            {
                BillID = Computation.GetBillID(1),
                GrandTotal = Products.Sum(p => p.Total),
                PatNum = patient.PatNum,
                TransactionDate = dteTransactionDate.Value,
                Remark = txtRemark.Text


            };
            db.Bills.Add(bill);
            if(db.SaveChanges()>0)
            {
                int StatusID=0;
                foreach (var item in Products)
                {
                    var billDetails = new BillDetail();

                    billDetails.BillDetailID = Computation.GetBillDetailID(1);
                    billDetails.DrugID = item.ProductID;
                    billDetails.Price = item.Price;
                    billDetails.Quantity = item.Qty;
                    billDetails.Total = item.Total;
                    billDetails.BillID = bill.BillID;
                    db.BillDetails.Add(billDetails);
                    StatusID = StatusID + db.SaveChanges();
                }
                if (StatusID > 0)
                {
                    MessageBox.Show("Bill posted successfully with " + StatusID.ToString()+"items");
                    txtBillID.Text = bill.BillID.ToString();
                }

               
            }

        }
    }


    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }

    }
}
