using System.ComponentModel;

namespace DGVTask
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private PropertyDescriptor _sortProperty;
        private ListSortDirection _sortDirection;

        // Core sort methods
        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> items = this.Items as List<T>;

            if (items == null)
            {
                _isSorted = false;
                return;
            }

            PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
            items.Sort(pc);
            _isSorted = true;
            _sortProperty = property;
            _sortDirection = direction;

            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
            _sortDirection = ListSortDirection.Ascending;
        }

        // Core sort properties
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }
    }
}
