using System.ComponentModel;

namespace DGVTask
{
    public class PropertyComparer<T> : IComparer<T>, IPropertyComparer<T>
    {
        private readonly PropertyDescriptor _property;
        private readonly ListSortDirection _direction;

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            if (property == null)
            {
                return;
            }

            this._property = property;
            this._direction = direction;
        }
        // IComparer<T> interface
        public int Compare(T xValue, T yValue)
        {
            var xPropertyValue = (IComparable)_property.GetValue(xValue);
            var yPropertyValue = (IComparable)_property.GetValue(yValue);

            return _direction == ListSortDirection.Ascending ? xPropertyValue.CompareTo(yPropertyValue) : yPropertyValue.CompareTo(xPropertyValue);
        }

    }
}
