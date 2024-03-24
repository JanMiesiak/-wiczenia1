static double findMax(int []arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }

    }
    
    return max;
}

//example use
int[] tmp = [1,7,7,4];
Console.WriteLine(findMax(tmp));

