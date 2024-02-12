using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class Node<T>
{
    public Node<T> _Next;
    //public Node _Previous;
    public Node(T value)
    {
        Value = value;
        //Prev = _Previous;
        Next = this;
    }   
    public object Value { get; }
    //public Node? Prev { get; set; }
    public Node<T> Next
    {
        get{ return _Next!;}
        private set { _Next = value; }
        
    }

    /*public override string ToString()
    {
        Node current = this;
        string outPut = current.Value + " ";
        while (current.Next != null) 
        {
            current = current.Next;
            outPut += current.Value + " ";
        }
        return outPut;
    }*/
    public void Append(T value)
    {
        if (Exists(value))
        {
            throw new ApplicationException("Value already exist");
        }
        else
        {
            if (Next != this)
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Next = Next;
                Next = newNode;
            }
            else
            {
                Next = new Node<T>(value);
            }
        
        }
    }
    public void Clear()
    {
        //With the clear method because none of the the disconnected nodes are being referenced we don't have to worry about garbage collection
        //If Clear() is never called, as long as the list isn't too big then we shouldn't worry about garbage collection
        //however if the list is too big then we need to handle garbage collection otherwise we will get a stack overflow

        Next = this;
        //temp.Next = this;
        /*if (temp.Next != null)
        {
            temp.Next = this;
        }
        else
        {
            Next = temp;
        }*/
  
    }
    public bool Exists(T value)
    {
        var current = this;
        do
        {
            if (current.Value.Equals(value))
            {
                return true;
            }
        }while(current != this);

        return false;
    }

}

