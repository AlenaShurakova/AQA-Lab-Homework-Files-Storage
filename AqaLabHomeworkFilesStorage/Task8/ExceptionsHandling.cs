namespace AqaLabHomeworkFilesStorage.Task8
{
    public class ExceptionsHandling
    {
        public static void ShowMassiveElement()
        {
            var massive = new int[] { 8, 7, 1, 4, 2 };
            Console.WriteLine("Input index of element in massive:");
            var inputedValue = Console.ReadLine();

            var elementIndex = inputedValue.Equals(string.Empty) ? null : inputedValue;
            int parsedelementIndex = int.Parse(elementIndex);
            int elementOfMassiveByIndex = massive[parsedelementIndex];

            Console.WriteLine($"Massive element that has index {inputedValue} has value {elementOfMassiveByIndex}");
        }
    }
}
