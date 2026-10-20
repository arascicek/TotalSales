namespace TotalSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                int index = 0;
                decimal total = 0m;

                var sales = new decimal[SIZE];

                StreamReader inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream && index < sales.Length)
                {
                    sales[index] = decimal.Parse(inputFile.ReadLine());
                    total += sales[index];
                    index++;
                }

                inputFile.Close();

                foreach (decimal value in sales)
                {
                    saleListBox.Items.Add(value.ToString("c"));
                }

                foreach (decimal value in sales)
                {
                    total += value;

                }
                lblTotal.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
