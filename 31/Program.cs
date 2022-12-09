Console.Clear();

Double[] array = GetArray(12, -9.0, 9.0);
Console.WriteLine(String.Join(" ", array));

Double positiveSum = 0;
Double negativeSum = 0;

foreach (Double el in array)
{
    positiveSum += el > 0 ? el : 0;
} 
//  for (int i = 0;i < array.Length; i++){
//     int el = array[i];
//     positiveSum += el > 0 ? el : 0;
//     negativeSum += el < 0 ? el : 0;
// } 
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

Double[] GetArray(int size, Double minValue, Double maxValue)
{
    Double[] res = new Double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 5.0 - 2.0;
    }
    return res;
}
