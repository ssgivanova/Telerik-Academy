namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /*
    Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    Keep the elements of the list in an array with fixed capacity which is given as parameter in the 
    class constructor.
    Implement methods for adding element, accessing element by index, removing element by index, 
    inserting element at given position, clearing the list, finding element by its value and ToString().
    Check all input parameters to avoid accessing elements at invalid positions */

    class GenericList<T> where T : IComparable
    {
        private int capacity;
        private T[] elements;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            elements = new T[capacity];
        }

        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value > 0)
                {
                    this.capacity = value;
                }
            }
        }

        //Defining an indexer
        public int this[int index]
        {
            get
            {
                if(index < 0 || index > elements.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} is invalid - outside the list",index));
                }
                return this[index];
            }
            set
            {
                if(index < 0 || index > elements.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} is invalid - outside the list", index));
                }
                this[index] = value;
            }
        }


        //adding element
        //public T[] AddElement(T element)
        //{
        //    //resize array to can contain the new element -> size + 1
        //    T[] newArray = new T[elements.Length + 1];
        //    for (int i = 0; i < elements.Length; i++)
        //    {
        //        newArray[i] = elements[i];
        //    }
        //    newArray[newArray.Length - 1] = element;
        //    return newArray;
        //}

        public void AddElement(T element)
        {
            if (elements.Length <= this.capacity)
            {
                int i = 0;
                if (elements[i] == null || (dynamic)elements[i] == 0)
                {
                    elements[i++] = element;
                }
            }
        }

        //removing element by index
        public T[] RemoveElement(int index)
        {
            //check if it's possible to remove element at this position
            if (index < 0 || index > elements.Length)
            {
                throw new IndexOutOfRangeException("Index is outside the array");
            }
            else
            {
                //resize array to can contain the new element -> size -1
                T[] newArray = new T[elements.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = elements[i];
                }
                for (int i = index + 1; i < elements.Length; i++)
                {
                    newArray[i] = elements[i];
                }
                return newArray;
            }
        }

        //inserting element at given position
        public T[] InsertElementAtPosition(T element, int index)
        {
            //check if it's possible to remove element at this position
            if (index < 0 || index > elements.Length)
            {
                throw new IndexOutOfRangeException("Index is outside the array");
            }
            else
            {
                //resize array to can contain the new element -> size -1
                T[] newArray = new T[elements.Length + 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = elements[i];
                }
                newArray[index] = element;
                for (int i = index + 1; i < elements.Length; i++)
                {
                    newArray[i] = elements[i];
                }
                return newArray;
            }

        }

        //accessing element by index
        public T GetElement(int index)
        {
            T element;

            if (index >= 0 || index < elements.Length)
            {
                element = elements[index];
                return element;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is outside the array");
            }
        }

        //clearing the list
        public T[] ClearList()
        {
            T[] newArray = new T[0];
            return newArray;
        }

        //finding element by its value 
        public int FindElementByValue(T element)
        {
            int index = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Elements in list : ");
            foreach (T element in this.elements)
            {
                sb.Append(element + " ");
            }
            return sb.ToString();
        }


        //Implement auto-grow functionality: when the internal array is full, 
        //create a new array of double size and move all elements to it.
        public T[] AutoGrow()
        {
            if(this.elements.Length == this.capacity)
            {
                T[] newArray = new T[capacity * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    newArray[i] = elements[i]; 
                }
                return newArray;
            }

            return this.elements;
        }


        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element 
        //in the GenericList<T>.
        //You may need to add a generic constraints for the type T.

        public T Min()
        {
            T min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(min) < 0)
                {
                    min = elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }

    }
}
