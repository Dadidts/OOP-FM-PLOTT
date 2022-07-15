using System.Globalization;

namespace _4_Lesson;

public static class FileMe
{

    public static IEnumerable<string> EnumLines(this FileInfo file)
    {
        using var reader = file.OpenText();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            yield return line!;
        }
    }
    



}
