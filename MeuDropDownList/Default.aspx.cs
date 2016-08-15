using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuDropDownList
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _valorSelecionado = cmbEstado.SelectedValue.ToString();
            cmbCidades.Items.Clear();

            if (_valorSelecionado.Equals("1")) //DF GO SP RJ
            {
                cmbCidades.Items.Add(new ListItem("São Sebastião", "1"));
                cmbCidades.Items.Add(new ListItem("Asa Sul", "2"));
                cmbCidades.Items.Add(new ListItem("Asa Norte", "3"));
                cmbCidades.Visible = true;
            }
            else if (_valorSelecionado.Equals("2"))
            {
                cmbCidades.Items.Add(new ListItem("Goiânia", "1"));
                cmbCidades.Items.Add(new ListItem("Aparecida de Goiânia", "2"));
                cmbCidades.Items.Add(new ListItem("Anápolis", "3"));
                cmbCidades.Visible = true;
            }
            else if (_valorSelecionado.Equals("3"))
            {
                cmbCidades.Items.Add(new ListItem("São Paulo", "1"));
                cmbCidades.Items.Add(new ListItem("Campinas", "2"));
                cmbCidades.Visible = true;
            }
            else if (_valorSelecionado.Equals("4"))
            {
                cmbCidades.Items.Add(new ListItem("Rio de Janeiro", "1"));
                cmbCidades.Items.Add(new ListItem("Niteroi", "2"));
                cmbCidades.Visible = true;
            }
            else
            {
                cmbCidades.Visible = false;
            }
        }
    }
}