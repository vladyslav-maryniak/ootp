namespace TemplateMethodExample.Maryniak.Models;

public abstract class DataProcessor
{
    // Template method
    public void ProcessData()
    {
        ReadData();
        ProcessDataDetails();
        WriteData();
    }

    protected abstract void ReadData();
    protected abstract void ProcessDataDetails();
    protected abstract void WriteData();
}
