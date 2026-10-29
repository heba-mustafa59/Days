namespace day5;
public interface IShoppingcart<T>
{
    public void addItem(T x);
    public void RemoveItem(T x);
    public void Displayitem();
}

public class ShoppingCart<T>:IShoppingcart<T>
{
    List<T> items = new List<T>();

    public ShoppingCart()
    {
        
    }
      public ShoppingCart(T x)
    {
        items.Add(x);
    }
    public void addItem(T x)
    {
        items.Add(x);
    }
    public void RemoveItem(T x)
    {
        items.Remove(x);
    }
    public void Displayitem()
    {
        System.Console.WriteLine("Shopping Cart Items");
        foreach (T i in items)
        {
            System.Console.WriteLine(i);
        }
    }
}
