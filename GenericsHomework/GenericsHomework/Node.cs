using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class Node
{
    public Node _Next;
    public Node(object value, Node prev, Node next)
    {
        Value = value; Prev = prev;_Next = next;
    }   
    public object Value { get; }
    public Node? Prev { get; set; }
    public Node Next
    {
        get
        {
            if (_Next == null)
            {
               return _Next = this;
            }
        }
            private set;
        
    }

    public override string ToString()
    {
        return "Value :" + Value+ "PrevNode :" + Prev +"NextNode : " + Next; 
    }
}

