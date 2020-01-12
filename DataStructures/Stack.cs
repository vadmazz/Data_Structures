using System.Collections.Generic;

namespace Data_and_Algoritmes.DataStructures
{
    public class StackData<T>
    {
        public T Array { get; }
        public StackData<T> Next;
    }
    
    public class Stack<T>
    {
        private List<StackData<T>> _array = new List<StackData<T>>();
        private StackData<T> _head;
        private int Count => _array.Count;

        public void Push(ref StackData<T> head, StackData<T> element)
        {
            element.Next = head.Next;
            head = element;
            _array.Add(element);
        }

        public StackData<T> Pop(ref StackData<T> head)
        {
            StackData<T> res = head;
            head = head.Next;
            
            return res;
        }
    }
}