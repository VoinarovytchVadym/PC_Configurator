﻿using PC_Configurator.core;

namespace PC_Configurator.models.products;

public class Ram(string producer, string type, int capacity, int numberOfModules, int frequency, string fullName)
: IProduct
{
    public int Id { get; set; }
    public string FullName { get; set; } = fullName;
    public string Producer { get; set; } = producer;
    public string Type { get; set; } = type;
    public int Capacity { get; set; } = capacity;
    public int NumberOfModules { get; set; } = numberOfModules;
    public int Frequency { get; set; } = frequency;

    public void SaveToDataBase()
    {
        Db db = Db.GetInstance();
        db.Rams.Add(this);
        db.SaveChanges();
    }
}