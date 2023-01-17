
namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BurrowsWheelerTransform b = new BurrowsWheelerTransform();
            var words = "Welcome";
            var encodedWord = b.Encode(words);
            Console.WriteLine($"Encoded Word: {encodedWord.encoded} {encodedWord.index}");
            var decodedWord =  b.Decode(encodedWord.encoded, encodedWord.index);
            Console.WriteLine($" Decoded Word : {decodedWord}");
        }
    }
}
