﻿namespace FactoryMethodExample.Maryniak.Models;

public abstract class Document
{
    public abstract void Open();
    public abstract void Save();
    public abstract void Close();
}
