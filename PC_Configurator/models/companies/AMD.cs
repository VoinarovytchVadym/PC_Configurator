﻿using PC_Configurator.models.companies.interfaces;
using PC_Configurator.models.products;

namespace PC_Configurator.models.companies;

public class AMD : ICpuCompany, IGpuCompany
{
    public Cpu CreateProduct(string line, string socket, int coresNumber, int streamsNumber, double frequency, string? graphicsCore, string fullName)
    {
        return new Cpu("AMD",line, socket, coresNumber, streamsNumber, frequency, graphicsCore,fullName);
    }
    public Gpu CreateProduct(string model, string vendor, string chip, int vram, string vramType, string fullName)
    {
        return new Gpu("AMD",model, vendor, chip, vram, vramType,fullName);
    }
}