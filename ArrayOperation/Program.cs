using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{

    class Operation{

        public void SortArray(double [] arr){
            
            int size = arr.Length;
            

            for (int i = 0; i<size; i++) {

               int iMin = i;

                for (int j=i+1;j<size;j++) {
                    if (arr[j] < arr[iMin])
                        iMin = j;
                }
                double temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;

              
            }

            
        }

        public void GetMinimumMaximum(double [] arr){
            int size = arr.Length;
            double minimumValue = arr[0];
            double maximumValue = arr[size-1];
            Console.WriteLine();    
            Console.WriteLine("Minimum Value: "+minimumValue);
            Console.WriteLine("Maximum Value: "+maximumValue);
             
        }
        public void PrintArray(double [] arr){
            int size = arr.Length;

            for(int i = 0; i < size;i++){

                Console.Write(arr[i]+" ");
            }
        
        }

        public void GetElementFrequency(double [] arr){

            
            int arraySize = arr.Length;
            bool [] isChecked = new bool[arraySize];
          

            for(int i = 0 ; i < arraySize ; i++){
                int iStart = i;
                int eachCount = 1;
                
                if (isChecked[i])
                {
                    continue;
                }   
                for(int j = i+1; j < arraySize ; j++){

                    

                    if(arr[iStart] == arr[j]){

                        isChecked[j] = true;
                        eachCount ++;

                    }
                     
                                                
                }
               

                Console.WriteLine(" "+eachCount+" number of element "+arr[i]);
                

            }
            

            
    
        }
    }
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Operation op = new Operation();
            double [] arr = { 112,121,231,33,33,3,3,33,33,33,33,33,33,11,2,113313};
            op.PrintArray(arr);
            op.SortArray(arr);
            op.GetMinimumMaximum(arr);
            Console.WriteLine("Each element count...");
            op.GetElementFrequency(arr);
            

            
            Console.ReadKey();
        }
    }
}
