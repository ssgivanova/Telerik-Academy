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
        private int count;
        private T[] elements;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            elements = new T[capacity];
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set
            {
                if (value > 0)
                {
                    this.capacity = value;
                }
            }
        }

        public int Count
        {
            get { return this.Count; }
            private set
            {
                if (value > 0)
                {
                    this.count = value;
                }
            }
        }

        //Defining an indexer
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= elements.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} is invalid - outside the list",index));
                }
                return this.elements[index];
            }
            set
            {
                if(index < 0 || index >= elements.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} is invalid - outside the list", index));
                }
                this.elements[index] = value;
            }
        }

        //Implement auto-grow functionality: when the internal array is full, 
        //create a new array of double size and move all elements to it.
        public void ChechForAutoGrow()
        {
            //autogrow
            if (this.elements.Length == this.capacity)
            {
                T[] newArray = new T[capacity * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    newArray[i] = elements[i];
                }
                //change the reference to the array
                this.elements = newArray;
            }
        }


       public void AddElement(T element)
        {
            ChechForAutoGrow();
           
           //add the new element at last position
            elements[count] = element;
            count++;
        }

        //inserting element at given position
        public void InsertElementAtPosition(T element, int index)
        {
            ChechForAutoGrow();

            //check if it's possible to insert element at this position
            if (index < 0 || index >= elements.Length)
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

                this.elements = newArray;

                //for (int i = count; i > index; i--)
                //{
                //    this.elements[count] = this.elements[count-1];
                //}
                //this.elements[index] = element;
                //count++;
            }

        }

        //removing element by index
        public void RemoveElement(int index)
        {
            //check if it's possible to remove element at this position
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Index is outside the array");
            }
            else
            {
                //resize array to can contain the new element -> size -1
                //T[] newArray = new T[elements.Length - 1];
                //for (int i = 0; i < index; i++)
                //{
                //    newArray[i] = elements[i];
                //}
                //for (int i = index+1; i < newArray.Length; i++)
                //{
                //    newArray[i] = elements[i];
                //}
                //this.elements = newArray;

                for (int i = index; i < this.count - 1; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }
                count--;
            }
        }

        //clearing the list
        public void ClearList()
        {
            this.Count = 0;
            this.elements = new T[this.Capacity];

            //set all elements to default value
            //for (int i = 0; i < this.elements.Length; i++)
            //{
            //    this.elements[i] = default(T);
            //}
        }

        //finding element by its value 
        public int IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Elements in list : ");
            for (int i = 0; i < this.count; i++)
			{
			 sb.Append(this.elements[i] + " ");
			}
            return sb.ToString();
        }


        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element 
        //in the GenericList<T>.
        //You may need to add a generic constraints for the type T.

        public T Min()
        {
            T min = this.elements[0];
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
            T max = this.elements[0];
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
