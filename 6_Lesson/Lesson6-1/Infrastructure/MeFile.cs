namespace _6_Lesson.Lesson61.Infrastructure;

public class MeFile
{
    public FileInfo FunctionRead()
    {

        const string date_file_path = @"C:\Users\Стас\Desktop\!LS_GB\OOP\6_Lesson\Lesson6-1\Infrastructure\BaseClient.txt";
        var date_file = new FileInfo(date_file_path);
        return date_file;

    }

}