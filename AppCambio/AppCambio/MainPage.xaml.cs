using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCambio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           try
           {
                //Variaveis, onde coverto elas atraves da classe Convert
                //O entry no xamarin é um objeto, e tem uma propriedade chamada
                //Text, que captura o que foi digitado nele
                decimal cotacao = Convert.ToDecimal(txt_cotacao.Text);
                decimal dolares = Convert.ToDecimal(txt_quantia_usd.Text);

                decimal reais = cotacao * dolares;

                NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

                txt_reais.Text = reais.ToString("C", nfi);

            }
            catch (Exception ex)
            {
                txt_reais.Text = "Ops, ocorreu um erro: \n " + ex.Message;
            }




        }
    }
}
