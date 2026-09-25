namespace G_NET_65_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Generic Class is a class that allows you to define a blueprint with type parameters
            postponing the specification of the actual data types until the object is instantiated


            WHY GENERICS ?

            Type Safety: Catches type mismatch errors at compile-time

            Performance: Eliminates the need for boxing and unboxing operations when working with value types

            Code Reusability: Allows you to write a single implementation that works across multiple data types without duplicating code

             
             */
            #endregion
            #region Q2
            /*
             
             public class Container<T>
{
    private T _item;

    public void Add(T item)
    {
        _item = item;
    }

    public T Get()
    {
        return _item;
    }
}
             */
            #endregion
            #region Q3
            /*
             
             Multiple Type Parameters allow a class or method to operate on more than one specified type parameter
             ------------

            public class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}


             */
            #endregion

        }
    }
}
