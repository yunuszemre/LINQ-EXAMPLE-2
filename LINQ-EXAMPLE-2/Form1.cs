using LINQ_EXAMPLE_2.Models;

namespace LINQ_EXAMPLE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Select
            using (NorthwindContext DB = new NorthwindContext())
            {
                //Method Syntax
                var result = DB.Employees.ToList();
                dataGridView1.DataSource=result;

                var result4 = DB.Employees.Select(t0=>t0.FirstName).ToList();

                //Anonymus Type
                var result5 = DB.Employees.Select(t0 => new { Name = t0.FirstName, Surname = t0.LastName, Title = t0.Title }).ToList();
                dataGridView1.DataSource = result5;

                var result6 = DB.Employees.Select(t0 => new PersonalDTO<Employee>() { Id=t0.EmployeeId, FirstName = t0.FirstName}).ToList();
 
                //Querry Syntax
                var result2 = (from t0 in DB.Employees select t0).ToList();

                var result7 = (from t0 in DB.Employees select new { Name = t0.FirstName, Surname = t0.LastName, Title = t0.Title }).ToList();
            }
            
        }
    }
}