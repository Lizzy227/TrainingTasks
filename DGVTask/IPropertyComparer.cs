namespace DGVTask
{
    public interface IPropertyComparer<T>
    {
        int Compare(T xValue, T yValue);
    }
}