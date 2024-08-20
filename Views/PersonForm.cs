
using Models.DomainModels;
using Services;


namespace Views
{
    public partial class frmPerson : Form
    {
        private readonly PersonService _personService;
        private bool isEditing = false;
        private int idToEdit = 0;
        public frmPerson()
        {
            InitializeComponent();
            _personService = new PersonService();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personService.FillGrid();
            dgvPerson.Columns[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };
            if (!isEditing)
            {
                _personService.Save(person);
                MessageBox.Show("Done", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
            else
            {
                _personService.Edit(idToEdit, person);
                MessageBox.Show("Done", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idToEdit = 0;
                isEditing = false;
            }
            dgvPerson.DataSource = _personService.FillGrid();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow != null)
            {
                txtFirstName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
                idToEdit = int.Parse(dgvPerson.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = dgvPerson.CurrentRow.Cells[0].Value.ToString();
            var firstName = dgvPerson.CurrentRow.Cells[1].Value.ToString();
            var lastname = dgvPerson.CurrentRow.Cells[2].Value.ToString();
            var fullName = firstName + " " + lastname;

            if (dgvPerson.CurrentRow != null)
            {
                if ((MessageBox.Show($"Are You Sure You Want To Delete {fullName} ?!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    _personService.Delete(int.Parse(id));
                }
            }
            dgvPerson.DataSource = _personService.FillGrid();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personService.FillGrid();
        }
    }
}
