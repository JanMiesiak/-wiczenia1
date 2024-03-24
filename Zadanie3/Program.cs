static double calculateAverage(int []arr)
{
    double avg = 0;
        for (int i = 0; i < arr.Length; i++) 
        {
            avg+=arr[i];
            
        }
        avg = avg/arr.Length;
        return avg;
    }

//example use
int[] tmp = [1,2,3,4];
Console.WriteLine(calculateAverage(tmp));