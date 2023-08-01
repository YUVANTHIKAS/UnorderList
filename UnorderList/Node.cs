using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderList
{
    
    
        public class Node<T>//int,string,char,
        {
            public T data;
            public Node<T> next;
            public Node(T data)
            {
                this.data = data;
            }
        }
    
}
