namespace encryptionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clickCounter = 0;
        String[] encodeArray = { "MD5", "RIPEMD-128", "SHA-1", "SHA-256", "SHA-512" };

        private String result(String input)
        {
            String method = null;
            String result = null;
            // otomatik olarak ilk secenegi sectigi icin ve kullanici bir secenek secmediginde system null reference exp. hatasi veriyor
            if (cbxEncode.SelectedItem != null)
            {
                method = cbxEncode.SelectedItem.ToString();
            }
            else
            {
                method = encodeArray[0];

            }


            Cryptography crypto = new Cryptography();

            switch (method)
            {
                case "MD5":
                    result = crypto.CalculateMD5(input);
                    break;
                case "SHA-1":
                    result = crypto.CalculateSHA1(input);
                    break;
                case "RIPEMD-128":
                    result = crypto.CalculateRIPEMD128(input);
                    break;
                case "SHA-256":
                    result = crypto.CalculateSHA256(input);
                    break;
                case "SHA-512":
                    result = crypto.CalculateSHA512(input);
                    break;

            }

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbxEncode.Text = encodeArray[0];

            foreach (string encode in encodeArray)
            {
                cbxEncode.Items.Add(encode);

            }
        }

        private void tbxInput_Click(object sender, EventArgs e)
        {
            // ilk kes tikladiginda ve ikinici kez tiklamak istediginde icerigi silmesin
            if (clickCounter == 0)
            {
                tbxInput.Clear();
                clickCounter++;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            String inputText = tbxInput.Text;
            String outputResult = result(inputText);
            //input text karakter kontrolu
            if (inputText.Length < 256 || inputText.Length > 512)
            {
                MessageBox.Show("Giriş geçersiz! Lütfen 256 ila 512 karakter arasında bir text giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbxOutput.Text = outputResult;
            }
        }
    }
}