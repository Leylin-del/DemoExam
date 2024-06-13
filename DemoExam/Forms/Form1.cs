
using DemoExam.Database;
using Microsoft.EntityFrameworkCore;

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
            var db = new ExamContext();
            var a = db.Database.EnsureCreated();
            var orders=  db.Orders.Include(x=>x.Client)
                .Select(x=> new { x.Client.LastName, x.Client.Phone, x.Client.Email, x.OrderDate, x.Status })
                .ToList();

            dataGridView1.DataSource = orders;
        }
    }
}