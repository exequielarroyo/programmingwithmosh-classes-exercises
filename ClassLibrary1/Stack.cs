using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Stack
    {
        private readonly ArrayList _list;

        public Stack()
        {
            _list = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj != null)
                _list.Add(obj);
        }

        public object Pop()
        {
            var last = Peek();
            _list.Remove(last);
            return last;
        }

        public object Peek()
        {
            if (_list.Count != 0)
                return _list[_list.Count - 1];
            return 0;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
