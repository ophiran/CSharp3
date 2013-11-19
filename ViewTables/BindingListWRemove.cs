using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewTables
{
    public class BindingListWRemove<T> : BindingList<T>
    {
        public BindingListWRemove(IList<T> list):base(list)
        {
        }

        protected override void RemoveItem(int index)
        {
            if (BeforeRemove != null)
                BeforeRemove(this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
            base.RemoveItem(index);
        }

        public event EventHandler<ListChangedEventArgs> BeforeRemove;
    }
}
