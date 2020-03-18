using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraSesc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string operacao = "";
        long valor = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void BotaoNumero(object sender,EventArgs e)
        {
            if(painelResultado.Text.Length == 1 && painelResultado.Text == "0")
                painelResultado.Text = ((Button)sender).Text;
            else
                painelResultado.Text += ((Button)sender).Text;
        }

        public void BotaoOperacao(object sender, EventArgs e)
        {
            operacao = ((Button)sender).Text;
            valor = long.Parse(painelResultado.Text);
            painelResultado.Text += operacao;
        }

        public void BotaoLimpar(object sender, EventArgs e)
        {
            painelResultado.Text = "0";
        }


        public void BotaoDel(object sender, EventArgs e)
        {
            painelResultado.Text = painelResultado.Text.Remove(painelResultado.Text.Length-1);
        }

        public void BotaoResultado(object sender, EventArgs e)
        {
            var segundoValor = painelResultado.Text.Split(operacao[0]);

            switch (operacao)
            {
                case "X":
                    painelResultado.Text = (valor * long.Parse(segundoValor[1])).ToString();
                    break;
                case "+":
                    painelResultado.Text = (valor + long.Parse(segundoValor[1])).ToString();
                    break;
                case "-":
                    painelResultado.Text = (valor - long.Parse(segundoValor[1])).ToString();
                    break;
                case "%":
                    painelResultado.Text = (valor % long.Parse(segundoValor[1])).ToString();
                    break;
                case "/":
                    painelResultado.Text = (valor / long.Parse(segundoValor[1])).ToString();
                    break;
            }
        }

    }
}
