public class Sequence //"utility class" with private constructor but static members
{
    // Static field, holding the current sequence value
    private static int currentValue = 0;
    // Intentionally deny instantiation of this class
    private Sequence()
    {
    }
    // Static method for taking the next sequence value
    public static int NextValue()
    {
        currentValue++;
        return currentValue;
    }
}