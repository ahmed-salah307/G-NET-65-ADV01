using System.Data;
using System.Diagnostics;

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
            #region Q4
            /* Generic Method is a method defined with type parameters,
                 allowing it to process parameters of various types dynamically
            -----------------------------

             public static class Helper
 {
     public static void Swap<T>(ref T a, ref T b)
     {
         T temp = a;
         a = b;
         b = temp;
     }
 }


            */
            #endregion
            #region Q5
            /*
             
             public static class MathHelper
{
    public static T FindMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
             
             */
            #endregion
            #region Q6
            /*
             
             Generic Interface defines contracts (methods/properties) using generic 
            type parameters, letting implementing classes specify the concrete type
             ---------------------------------

            public interface IRepository<T>
{
    void Add(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Delete(T entity);
}

             */
            #endregion
            #region Q7
            /*
             
             The struct constraint restricts the type parameter to value types only
            -----------------------
            public class ValueContainer<T> where T : struct
{
    public T Value { get; set; }
}
             
             */
            #endregion
            #region Q8
            /*
             
             The class constraint restricts the type parameter to reference types only
            --------------------
            public class ReferenceContainer<T> where T : class
{
    public T Item { get; set; }
}
             
             */
            #endregion
            #region Q9
            /*
            The new() constraint specifies that any type argument supplied must
                have a public parameterless constructor, allowing the instantiation of T using new T()

            ---------------------

            public class Factory<T> where T : new()
{
    public T CreateInstance()
    {
        return new T();
    }
}
            */
            #endregion
            #region Q10
            /*
             
             
             An Interface Constraint specifies that the type argument must implement a particular interface
            -----------------------

             public class Printer<T> where T : IFormattable
{
    public void Print(T item)
    {
        Console.WriteLine(item.ToString());
    }
}
             
             */
            #endregion
            #region Q11
            /*
             
             Base Class Constraint specifies that the type argument must inherit from a specific base class
            ----------------
            public class Entity
{
    public int Id { get; set; }
}

public class EntityManager<T> where T : Entity
{
    public void DisplayId(T entity)
    {
        Console.WriteLine(entity.Id);
    }
}

             */
            #endregion
        }
    }
}
