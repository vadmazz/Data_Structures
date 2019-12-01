namespace Data_and_Algoritmes.DataStructures
{
    class Data<T>
    {
        public T Array { get;  }
        public Data<T> Next { get; set; }

        public Data(T data)
        {
            Array = data;
        }
    }
    public class Queue<T>
    {
        private Data<T> _head;
        private Data<T> _tail;
        private int _count;
        /// <summary>
        /// Добавить в очередь
        /// </summary>
        /// <param name="element">Элемент</param>
        public void Enqueue(T element)
        {
            var temp = _tail;
            _tail = new Data<T>(element);
            if (_count == 0)
                _head = _tail;
            else
                temp.Next = _tail;    
        }
        /// <summary>
        /// Извлечь из очереди
        /// </summary>
        /// <returns>Значение головного элемента</returns>
        public T Dequeue()
        {
            var output = _head.Array;
            _head = _head.Next;
            _count--;
            return output;
        }
    }
}