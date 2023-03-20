string[] TestAlgorithm(string[] array, int value, int length = 0)
{
    string[] arrTemp = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (arrTemp.Length > 0 && j < arrTemp.Length)
            {
                arrTemp[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && arrTemp.Length <= 0) return TestAlgorithm(array, value, length);
    return arrTemp;
}