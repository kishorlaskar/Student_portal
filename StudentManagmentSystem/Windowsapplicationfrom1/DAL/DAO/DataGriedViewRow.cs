using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class DataGriedViewRow
    {
        internal object cells;

        public static implicit operator DataGriedViewRow(DataGridViewRow v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator DataGriedViewRow(DataGridView v)
        {
            throw new NotImplementedException();
        }
    }
}