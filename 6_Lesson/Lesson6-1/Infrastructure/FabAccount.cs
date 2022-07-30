namespace _6_Lesson;

public static class FabAccount
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
