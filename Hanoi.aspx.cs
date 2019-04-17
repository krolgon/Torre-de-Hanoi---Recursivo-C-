using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Estrutura_de_Dados_Hanoi : System.Web.UI.Page
{
    int cont = 0;
    string movimentos ="";
    
    void mover(string origem, string final) {
        cont += 1;
        movimentos += "Mover de " + origem + " para " + final + " - Número do movimento: " + Convert.ToString(cont) + "<br/>";
        lblResultado.Text = movimentos;
    }

    void moverTorre(int n, string origem, string final, string auxiliar) {
        if (n == 1)
        {
            mover(origem, final);
        }
        else {
            moverTorre(n - 1, origem, auxiliar, final);
            mover(origem, final);
            moverTorre(n - 1, auxiliar, final, origem);
        }
    }
       
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        int numero = Convert.ToInt32(txbDiscos.Text);
        moverTorre(numero, "A", "B", "C");

    }
}
