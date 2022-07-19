namespace _4_Lesson.Lesson41;

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
