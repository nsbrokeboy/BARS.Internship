using System;

namespace BARS.Internship.Task4.MyArray
{
    public class MyArray<T>
    {
        public int Length { get; set; } = default;

        private T[] _array;

        private int _nextIndex;

        public MyArray()
        {
            Length = 0;
            _array = Array.Empty<T>();
            _nextIndex = 0;
        }

        public MyArray(int length)
        {
            Length = length;
            _array = new T[length];
            _nextIndex = 0;
        }

        public void Add(T element)
        {
            if (_nextIndex <= Length - 1)
            {
                _array[_nextIndex] = element;
            }
            else
            {
                Array.Resize(ref _array, _nextIndex + 1);
                _array[_nextIndex] = element;
                
                Length++;
            }

            _nextIndex++;
        }

        public T GetByIndex(int index)
        {
            if (index <= Length - 1)
            {
                return _array[index];
            }
            else throw new IndexOutOfRangeException($"Индекс {index} выходит за границы массива");
        }

        public void DeleteByIndex(int index)
        {
            var temporaryArray = new T[Length - 1];

            if (index <= Length - 1)
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (i != index)
                    {
                        temporaryArray[i] = _array[i];
                    }
                }

                _array = temporaryArray;
                Length -= 1;
            }
            else throw new IndexOutOfRangeException($"Индекс {index} выходит за границы массива");
        }

        public override string ToString()
        {
            string output = "[";

            foreach (var element in _array)
            {
                output = $"{output}, {element}";
            }
                        
            output += "]";

            return output;
        }
    }
}