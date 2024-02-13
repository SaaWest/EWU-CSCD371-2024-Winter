using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class Node<T>
{
    //Node
  
    public Node(T value)
    {
        Value = value;
        
        Next = this;
    }   
    public T Value { get; }
    
    public Node<T> Next
    {
        get;
        private set;
        
    }

    public override string ToString()
    {
        if(Value is null)
        {
            throw new ArgumentException(nameof(Value));
        }

        return Value.ToString()!;
    }
    public void Append(T value)
    {
        Node<T> current = this;
        if (Exists(value))
        {
            throw new ArgumentException("Value already exist "+ (nameof(value)));
        }
        if (current.Next != current)
        { 
            current = current.Next;
             
        }
        Node<T> tempNode = new(value);
        current.Next = tempNode;
        tempNode.Next = this;

    }
    public void Clear()
    {
        //With the clear method because none of the the disconnected nodes are being referenced we don't have to worry about garbage collection
        //If Clear() is never called, as long as the list isn't too big then we shouldn't worry about garbage collection
        //however if the list is too big then we need to handle garbage collection otherwise we will get a stack overflow

        Next = this;

  
    }
    public bool Exists(T value)
    {
        Node<T> current = this;
        do
        {
            if (current.Value!.Equals(value))
            {
                return true;
            }
        }while(current != this);

        return false;
    }

}

