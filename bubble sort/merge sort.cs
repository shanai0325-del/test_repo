static void MergeSort(int[] array)
{
    if (array.Length <= 1)
    {   
        return;
    }
    else 
    {

        int midpoint = array.Length / 2;
        int[] left = new int[midpoint];
        int[] right = new int[array.Length - midpoint];

        Array.Copy(array, left, midpoint);
        Array.Copy(array, midpoint, right, 0, array.Length - midpoint);

        MergeSort(left);
        MergeSort(right);

        Merge(array, left, right);
    }
}

static void Merge(int[] array, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
        {
            array[k++] = left[i++];
        }
        else
        {
            array[k++] = right[j++];
        }
    }

    while (i < left.Length)
    {
        array[k++] = left[i++];
    }

    while (j < right.Length)
    {
        array[k++] = right[j++];
    }
}