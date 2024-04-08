using System;

namespace DatatypesPractice
{
    public class CustomeArrayList<T>
    {
        private int count = 0;
        private T[] arr = new T[intialCapacityOfArray];//small bucket
        public int Count { get { return count; } }
        private const int intialCapacityOfArray = 5;
        public void AddNewElement(T element)
        {

            if (count + 1 > arr.Length) //Growing the capacity of array 
            {
                T[] bigbucket = new T[arr.Length * 2];
                arr.CopyTo(bigbucket, 0);

                arr = bigbucket;
            }
            this.arr[this.count] = element; // take that insert to array
            this.count++; // increase
        }

        public T RemoveAtThisPoint(int position)
        {
           // T[] newBucket = new T[arr.Length];
           
            var index = position;
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid index: " + index);
            }
            T item = this.arr[index];
            Array.Copy(this.arr, index + 1,
            this.arr, index, this.count - index - 1);
            this.arr[this.count - 1] = default(T);
            this.count--;
            return item;
        }

        public void RemoveAllElements()
        {
            arr = new T[intialCapacityOfArray]; 
            count = 0;

        }

        public void ReplaceAtThisPlace(int position, T newItem)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                if(position == i)
                {
                    arr[i] = newItem;
                }
            }
            
        }

        public void ReadAtThisPosition(int position)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (position == i)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        } 
    }
}