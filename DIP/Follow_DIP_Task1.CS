public interface IFileReader
{
    string ReadFile(string filePath);
}

public interface IFileWriter
{
    void WriteFile(string filePath, string content);
}

public class FileReader : IFileReader
{
    public string ReadFile(string filePath)
    {
        // Code to read file content
        return "File content";
    }
}

public class FileWriter : IFileWriter
{
    public void WriteFile(string filePath, string content)
    {
        // Code to write file content
    }
}

public class FileProcessor
{
    private readonly IFileReader _fileReader;
    private readonly IFileWriter _fileWriter;

    public FileProcessor(IFileReader fileReader, IFileWriter fileWriter)
    {
        _fileReader = fileReader;
        _fileWriter = fileWriter;
    }

    public void ProcessFile(string inputFilePath, string outputFilePath)
    {
        string fileContent = _fileReader.ReadFile(inputFilePath);
        // Process the file content
        _fileWriter.WriteFile(outputFilePath, fileContent);
    }
}
