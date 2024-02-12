using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class Node
{
    public Node _Next;
    public Node _Previous;
    public Node(object value)
    {
        Value = value;
        Prev = _Previous;
        Next = _Next!;
    }   
    public object Value { get; }
    public Node? Prev { get; set; }
    public Node Next
    {
        get{ return _Next!;}
        private set { _Next = value; }
        
    }

    public override string ToString()
    {
        return "Value :" + Value.ToString(); 
    }
    public void Append(object value)
    {
        if (Next != this) 
        {
            Node newNode = new Node(value);
            newNode.Next = Next;
            Next = newNode;
        }
        else
        {
            Next = new Node(value);
        }
    }
}

