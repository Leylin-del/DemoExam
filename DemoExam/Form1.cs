
using DemoExam.Database;

namespace DemoExam
{
    public partial class workOrder : Form
    {
        public workOrder()
        {
            InitializeComponent();
        }

        private void workOrder_Load(object sender, EventArgs e)
        {
            var examContext = new ExamContext();
            var canConnect = examContext.Database.EnsureCreated();

            MessageBox.Show(canConnect.ToString());
        }
    }
}
