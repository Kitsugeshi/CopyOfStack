using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyOfStack
{
    class MyStack<T>
    {
        private List<T> items;
        private int Size { get; set; }
        public int Count { get { return items.Count; } }

        public MyStack(int size) 
        {
            items = new List<T>(size);
            Size = size;
        }

        public MyStack(MyStack<T> obj) //Конструктор копирования
        {
            this.items = obj.items;
            obj.Size = Size;
        }

        public void Push(T item)
        {
            if (Count < Size)
            {
                items.Add(item);
            }
            else
            {
                throw new IndexOutOfRangeException("Стек переполнен");
            }
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if(Count > 0)
            {
                return items.LastOrDefault();
            }
            else 
            { 
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
