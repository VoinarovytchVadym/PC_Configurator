﻿using System.Windows.Controls;
using PC_Configurator.core;
using PC_Configurator.models.products;

namespace PC_Configurator.views;

public partial class CaseSelectionPage : Page
{
    private readonly List<Case> _caseList;
    private readonly Db _db = Db.GetInstance();
    public CaseSelectionPage()
    {
        InitializeComponent();
        _caseList = _db.Cases.ToList();
        CasesListView.ItemsSource = _caseList;
    }
    public event EventHandler<Case> ItemSelected;

    private void CasesListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ItemSelected.Invoke(this, _db.Cases.FirstOrDefault(u=>u.Id==_caseList[CasesListView.SelectedIndex].Id)!);
        NavigationService!.Content = null;
    }
}