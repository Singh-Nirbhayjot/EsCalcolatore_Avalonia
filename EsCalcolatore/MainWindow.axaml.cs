using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Globalization;

namespace EsCalcolatore;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CmbFigura.SelectedIndex = 0;
    }

    private void CmbFigura_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (CmbFigura.SelectedIndex == 0)         
        {
            LblMisura1.Text = "Base";
            LblMisura2.IsVisible = true;
            TxtMisura2.IsVisible = true;
        }
        else if (CmbFigura.SelectedIndex == 1)     
        {
            LblMisura1.Text = "Lato";
            LblMisura2.IsVisible = false;
            TxtMisura2.IsVisible = false;
        }
        else                                       
        {
            LblMisura1.Text = "Raggio";
            LblMisura2.IsVisible = false;
            TxtMisura2.IsVisible = false;
        }

        TxtMisura1.Text = "";
        TxtMisura2.Text = "";
        TxtRisultato.Text = "";
    }

    private void BtnCalcola_Click(object? sender, RoutedEventArgs e)
    {
        double misura1;
        double misura2 = 0;

        if (!double.TryParse(TxtMisura1.Text, out misura1))
        {
            TxtRisultato.Text = "Errore: " + LblMisura1.Text + " non è un numero valido.";
            return;
        }

        if (CmbFigura.SelectedIndex == 0)
        {
            if (!double.TryParse(TxtMisura2.Text, out misura2))
            {
                TxtRisultato.Text = "Errore: " + LblMisura2.Text + " non è un numero valido.";
                return;
            }
        }
        if (TxtMisura1.Text.Contains(".") || TxtMisura2.Text.Contains("."))
        {
            TxtRisultato.Text = "Errore: per i decimali usa la virgola, non il punto.";
            return;
        }
        try
        {
            CFigura figura;

            if (CmbFigura.SelectedIndex == 0)
                figura = new CRettangolo("Rettangolo", misura1, misura2);
            else if (CmbFigura.SelectedIndex == 1)
                figura = new CQuadrato("Quadrato", misura1);
            else
                figura = new CCerchio("Cerchio", misura1);

            TxtRisultato.Text = figura.Descrizione();
        }
        catch (ArgumentException ex)
        {
            TxtRisultato.Text = "Errore: " + ex.Message;
        }
    }
}
