using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignment
{
    public class CustomSort
    {
        public delegate int CompareDelegate<T>(T S1,T S2);
        public CustomSort() { }

       


        public void BubbleSort<T>(List<T> array,CompareDelegate<T> c) 
        {


            int n=array.Count;
            //c += Compare;
            //CompareDelegate<T> c = new CompareDelegate<T>(Compare);

            for (int i=0; i<n-1; i++)
            {
                for(int j=i+1;j<n; j++)
                {
                    if (c(array[i], array[j])<0)
                    {
                        T temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;

                    }

                }
            }

            //for (var i = 0; i < students.Count(); ++i)
            //{
            //    Console.WriteLine(students[i]);
            //}



        }

    }
}
