using System.Threading.Tasks;
using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
    public NovoProduto()
    {
        InitializeComponent();
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)

            };

            await App.Database.Insert(p);
            await DisplayAlert("Sucesso", "Produto adicionado com sucesso!", "OK!");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK!");
        }
    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {

    }
}