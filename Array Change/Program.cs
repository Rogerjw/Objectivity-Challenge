namespace Array_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic[] originalArray = { "Roger", "Muhire", 25 };
            dynamic[] updatedArray = { "Muhire", 1.88 };
            var (newElements, removedElements) = ArrayChange(originalArray, updatedArray);
            Console.WriteLine($"New elements: {string.Join(", ", newElements)}");
            Console.WriteLine($"Removed elements: {string.Join(", ", removedElements)}");
            Console.ReadKey();
        }

        static public (dynamic[], dynamic[]) ArrayChange<dynamic>(dynamic[] originalArray, dynamic[] updatedArray)
        {
            dynamic[] newElements = updatedArray.Except(originalArray).ToArray();
            dynamic[] removedElements = originalArray.Except(updatedArray).ToArray();
            return (newElements, removedElements);
        }
    }
}