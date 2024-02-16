using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class VennDiagram<T>
{
    public VennDiagram(List<T> except) 
    {
        Except = except;
        

    }
    public List<T> Except { get; private set; }
    public List<T> AddUnion(T value)
    {
        List<T> union = new List<T>();
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }
        
        union.Add(value);
        return union;

    }

    /*public VennDiagram(T value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));

        //Next = this;
    }
    //public VennDiagram<T> Next { get; private set; }
    public Node<T>? Union { get; private set; }
    public Node<T>? Except { get; private set; }
    public T Value { get; private set; }
    public void AddUnion(T item)
    {
        if (Union == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        else {
            
            Union.Append(item);
        }
    }
    public void AddExcept(T item) 
    {
        Node<T> temp = new(item);
        if(Except == null)
        {
            throw new ArgumentNullException(nameof(item));
            
        }
        else
        {
            //VennDiagram<T> current = new(item);
            //current.Except = temp;
            Except.Append(item);
        }
    }*/
}



