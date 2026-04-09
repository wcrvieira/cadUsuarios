using System.Diagnostics;

namespace Estruturas
{
    public partial class frmOperadores : Form
    {
        public frmOperadores()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            string url = "https://etecdans.cps.sp.gov.br/";
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            Process.Start(chromePath, url);
        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }

        private void btnVSCode_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Microsoft VS Code\code.exe";
            Process.Start(path);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApresenta_Click(object sender, EventArgs e)
        {
            lsbMostra.Font = new Font("Arial", 12);
            lsbMostra.Items.Add("Meu nome é Wagner Cesar Vieira");
            lsbMostra.Items.Add("Moro em Bebedouro e curto MPB");
            lsbMostra.Items.Add("Este texto é simples!!!");
            lsbMostra.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();
        }

        private void lsbMostra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmOperadores_Load(object sender, EventArgs e)
        {

        }
    }
}
