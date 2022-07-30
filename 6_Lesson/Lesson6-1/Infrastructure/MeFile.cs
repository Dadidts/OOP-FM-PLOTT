namespace _6_Lesson.Lesson61.Infrastructure;

public static class MeFile
{
    public static FileInfo FunctionRead(string date_file_path)
    {

        var date_file = new FileInfo(date_file_path);
        return date_file;

    }

}