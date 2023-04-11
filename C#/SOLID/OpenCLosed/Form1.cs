namespace OpenCLosed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreditCard creditCard = new CreditCard() { Name = "Kredi Kartý"};
            Cash cash = new Cash() { Name = "Nakit"};
            CryptoCurrency currency = new CryptoCurrency() { Name = "Kripto Para"};

            comboBox1.Items.Add(creditCard.Name);
            comboBox1.Items.Add(cash.Name);
            comboBox1.Items.Add(currency.Name);

        }
    }

    interface PaymentManager
    {
        public string Name { get; set; }
    }

    class CreditCard : PaymentManager {

        public string Name { get; set; }


    }

    class Cash : PaymentManager
    {
        public string Name { get; set; }
    }

    class CryptoCurrency : PaymentManager
    {
        public string Name { get; set; }
    }
 }