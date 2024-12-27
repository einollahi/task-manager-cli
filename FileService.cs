using System.IO;
using System.Text.Json;

namespace _01_TaskManagerCli;

internal class FileService
{
    private readonly String FileName = "taks.json";

    public String? ReadFile() { 
        if (IsFileExisted())
        {
            return File.ReadAllText(FileName);
        } else
        {
            File.CreateText(FileName);
            return null;
        }
    }

    public void Save(Object data)
    {
        var json = JsonSerializer.Serialize(data);
        File.WriteAllText(FileName, json);
    }

    private bool IsFileExisted() {
        return File.Exists(FileName);
    }
}

