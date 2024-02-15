using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;
public class VennDiagram<T>
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VennDiagram(List<T> list)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        vennList = list ?? throw new ArgumentNullException(nameof(list));
        //Next = this;
    }
    //public VennDiagram<T> Next { get; private set; }
    public List<T> Union { get; private set; }
    public List<T> Except { get; private set; }
    public List<T> vennList { get; private set; }
    public void Add(List<T> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            /*if (inputList[i] == null)
                {
                throw new ArgumentNullException("item " + nameof(inputList));
            }*/
            if (vennList.Contains(inputList[i]))
            {
                Union.Add(inputList[i]);
            }
            else
            {
                Except.Add(inputList[i]);
            }
            
        }
      
    }
}



