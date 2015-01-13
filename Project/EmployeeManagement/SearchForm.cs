using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class SearchForm : Form
    {
        IEnumerable<EmployeeData> _items;

        public SearchForm(IEnumerable<EmployeeData> items)
        {
            InitializeComponent();
            _items = items;
        }

        private void ButtonExecuteClick(object sender, EventArgs ev)
        {
            _listBoxEmployee.Items.Clear();
            _listBoxEmployee.Items.AddRange(_items.Where(e => e.Address.IndexOf(_textBoxSearch.Text) != -1).ToArray());
        }
    }
}
