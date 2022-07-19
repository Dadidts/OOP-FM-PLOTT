using System.Globalization;

namespace _4_Lesson.Lesson42;
public static class FileInfoMe
{

    public static IEnumerable<string> EnumLines42(this FileInfo file)
    {
        using var reader = file.OpenText();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            yield return line!;
        }
    }

}
