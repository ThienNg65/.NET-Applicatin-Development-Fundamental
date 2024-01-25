using System;
using System.Windows.Forms;

namespace Lab3
{

    public partial class Form1 : Form
    {
        class clsBookSale
        {

            String strTitle;
            int intQuantity;
            decimal decPrice;
            static decimal decSalesTotal = 0;
            static int intSalesCount = 0;

            public static decimal SalesTotal
            {
                get
                {
                    return decSalesTotal;
                }
            }

            public static int SalesCount
            {
                get
                {
                    return intSalesCount;
                }
            }

            public String Title
            {
                get
                {
                    return strTitle;
                }
                set
                {
                    strTitle = value;
                }
            }

            public int Quantity
            {
                get
                {
                    return intQuantity;
                }
                set
                {
                    if (value > 0)
                    {
                        intQuantity = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

            public decimal Price
            {
                get
                {
                    return decPrice;
                }

                set
                {
                    if (value >= 0)
                    {
                        decPrice = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

            public decimal ExtendedPrice()
            {
                decimal decExtendedPrice = intQuantity * decPrice;
                decSalesTotal += decExtendedPrice;
                intSalesCount += 1;

                return decExtendedPrice;
            }

            const float sngDISCOUT_RATE = 0.1F;

            bool blnDiscount;
            public bool Discount
            {
                get { return blnDiscount; }
                set { blnDiscount = value; }
            }

            public virtual decimal DiscountAmount()
            {
                decimal decDiscountAmount;
                if (blnDiscount)
                {
                    decDiscountAmount = intQuantity * decPrice * Convert.ToDecimal(sngDISCOUT_RATE);
                }
                else
                {
                    decDiscountAmount = 0M;
                }

                return decDiscountAmount;
            }



            public decimal NetDue()
            {
                decimal decNetDue = ExtendedPrice() - DiscountAmount();

                decSalesTotal += decNetDue;
                intSalesCount += 1;
                return decNetDue;
            }

            public clsBookSale(string title, int quantiy, decimal price, bool discount)
            {
                this.Title = title;
                this.Quantity = quantiy;
                this.Price = price;
                this.Discount = discount;
            }
        }

        class clsStudentBookSale : clsBookSale
        {
            public clsStudentBookSale(String title, int quantity, decimal price, bool discount, bool student) : base(title, quantity, price, discount)
            {
                blnStudentDiscount = student;
            }

            bool blnStudentDiscount;
            const float sngSTUDENT_DISCOUNT_RATE = 0.15F;

            public bool studentDiscount
            {
                get
                {
                    return blnStudentDiscount;
                }
                set
                {
                    blnStudentDiscount = value;
                }
            }

            public override decimal DiscountAmount()
            {
                decimal decDiscountAmount;
                decDiscountAmount = base.DiscountAmount();

                if (studentDiscount)
                    decDiscountAmount += ExtendedPrice()
                        * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
                return decDiscountAmount;
            }
        }



        private clsBookSale mBookSale;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuCal_Click(object sender, EventArgs e)
        {
            try
            {
                mBookSale = new clsStudentBookSale(txtTitle.Text,
                    (int)Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtQuan.Text),
                    chkDis.Checked,
                    chkDisStudent.Checked);


                txtPrice.Text = mBookSale.Price.ToString("C");
                lblEPrice.Text = mBookSale.ExtendedPrice().ToString("C");
                lblDis.Text = mBookSale.DiscountAmount().ToString("C");
                lblNetDue.Text = mBookSale.NetDue().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in quantity or price." + ex.Message, "Data Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtQuan.Clear();
            txtPrice.Clear();
            lblEPrice.Text = "";
            lblDis.Text = "";
            lblNetDue.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSum_Click(object sender, EventArgs e)
        {
            string strMessage = "Sale Total: " +
                clsBookSale.SalesTotal.ToString("C") +
                "\nSales Count: " + clsBookSale.SalesCount.ToString();

            MessageBox.Show(strMessage, "Summary Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
