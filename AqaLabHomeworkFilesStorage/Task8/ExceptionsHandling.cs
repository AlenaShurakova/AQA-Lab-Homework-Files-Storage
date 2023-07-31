namespace AqaLabHomeworkFilesStorage.Task8
{
    public class ExceptionsHandling
    {
        public static void ShowArrayElement()
        {
            var array = new int[] { 8, 7, 1, 4, 2 };
            Console.WriteLine("Input index of element in array:");
            var inputedValue = Console.ReadLine();

            var elementIndex = inputedValue.Equals(string.Empty) ? null : inputedValue;
            int parsedElementIndex = int.Parse(elementIndex);
            int elementOfarrayByIndex = array[parsedElementIndex];

            Console.WriteLine($"Array element that has index {inputedValue} has value {elementOfarrayByIndex}");
        }
    }
}
