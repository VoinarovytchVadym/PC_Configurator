﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class CurrentConfigurationPage : Page
{
    private Db db = Db.GetInstance();
    public CurrentConfigurationPage()
    {
        InitializeComponent();
        if (MainWindow.Cpu != null)
        {
            List<Cpu> cpu = [MainWindow.Cpu];
            SelectedCpu.ItemsSource = cpu;
            SelectedCpu.Visibility = Visibility.Visible;
        }

        if (MainWindow.Gpu != null)
        {
            List<Gpu> gpu = [MainWindow.Gpu];
            SelectedGpu.ItemsSource = gpu;
            SelectedGpu.Visibility = Visibility.Visible;
        }

        if (MainWindow.Ram != null)
        {
            List<Ram> ram = [MainWindow.Ram];
            SelectedRam.ItemsSource = ram;
            SelectedRam.Visibility = Visibility.Visible;
        }
    }
}