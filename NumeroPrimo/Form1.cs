using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Numero;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Deve inserir somente numeros
            //pode inserir numero quebrados
            //deve calcular se o numero é primo
            //deve informa se ele é primo em outro form
            //se nao for primo deve informa em outro form


            if (int.TryParse(txtNumero.Text, out Numero))
            {
                Numero = int.Parse(txtNumero.Text);
                Resultado telaResultado = new Resultado();

                int divisores = 0;

                // Ciclo para testar todas as divisões de 1 até ao número digitado

                for (int i = 1; i <= Numero; i++)
                {
                    // Se o resto da divisão por i for zero, encontrámos um divisor
                    if (Numero % i == 0)
                    {
                        divisores++;
                    }
                }

                // Se tiver exatamente 2 divisores (o 1 e ele próprio), é primo

                if (divisores == 2)
                {
                    string mensagem = $"O número {Numero} é primo !";
                    telaResultado.Exibir(mensagem);
                    telaResultado.Show();
                }
                else
                {
                    string mensagem = $"O número{Numero} não é primo !!!";
                    telaResultado.Exibir(mensagem);
                    telaResultado.Show();
                }

            }

            else
            {
                // Se o utilizador digitou letras ou deixou vazio, mostra este alerta
                MessageBox.Show("Por favor, insira apenas números inteiros válidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
