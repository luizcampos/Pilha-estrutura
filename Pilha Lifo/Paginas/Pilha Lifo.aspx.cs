using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Pilha_Lifo : System.Web.UI.Page
{
    static List<String> pilhaPalavras = new List<String>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           
        }
    }

    protected void btnInserir_Click(object sender, EventArgs e)
    {
        try
        {
            if ((txtElemento.Text != "") && (txtElemento.Text != null))
            {
                Pilha.Inserir(txtElemento.Text, pilhaPalavras);

                Session["INSERCAO"] = pilhaPalavras;
            }

            txtElemento.Text = "";
            ltrMsg.Text = "<p class='alert alert-success'>Inserido com sucesso!</p>";
            ltrDados.Text = Pilha.Mostrar(pilhaPalavras);
        }
        catch (Exception)
        {
            ltrMsg.Text = "<p class='alert alert-danger'>Inserção não realizada!</p>";
        }
    }

    protected void btnMostrar_Click(object sender, EventArgs e)
    {
        ltrMsg.Text = "";
        if (Session["INSERCAO"] != null)
        {
            pilhaPalavras = (List<String>)Session["INSERCAO"];
            ltrDados.Text = Pilha.Mostrar(pilhaPalavras);
        }
        else
        {
            ltrDados.Text = "<div class='alert alert-danger'>Não há elementos</div>";
        }
    }

    protected void btnTopo_Click(object sender, EventArgs e)
    {
        ltrMsg.Text = "";
        if ((Session["INSERCAO"] != null) && (pilhaPalavras.Count() != 0))
            ltrDados.Text = Pilha.Topo(pilhaPalavras);
    }

    protected void btnRetirar_Click(object sender, EventArgs e)
    {
        ltrMsg.Text = "";
        if (Session["INSERCAO"] != null)
        {
            pilhaPalavras = (List<String>)Session["INSERCAO"];
            Pilha.Retirar(pilhaPalavras);
            ltrDados.Text = Pilha.Mostrar(pilhaPalavras);
        }
    }
}