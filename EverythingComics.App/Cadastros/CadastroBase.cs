using MaterialSkin;
using MaterialSkin.Controls;
using FluentValidation;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; 

namespace EverythingComics.App.Cadastros
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsUpdate = false;

        public CadastroBase()
        {
            InitializeComponent();
            ConfigurarTema();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConfigurarTema()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int espessuraBorda = 3;

            Color corBorda = MaterialSkinManager.Instance.ColorScheme.AccentColor;

            using (Pen caneta = new Pen(corBorda, espessuraBorda))
            {
                e.Graphics.DrawRectangle(
                    caneta,
                    0,
                    0,
                    this.ClientSize.Width - 1,
                    this.ClientSize.Height - 1
                );
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            IsUpdate = false;
            tabControlBase.SelectedIndex = 1;
            LimparCampos();
        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase.SelectedRows.Count > 0)
            {
                IsUpdate = true;
                CarregarRegistro(dataGridViewBase.SelectedRows[0]);
                tabControlBase.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = 0;
                        if (dataGridViewBase.SelectedRows[0].Cells["Id"].Value != null)
                        {
                            id = Convert.ToInt32(dataGridViewBase.SelectedRows[0].Cells["Id"].Value);
                        }

                        Deletar(id);
                        CarregarGrid();
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Salvar())
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlBase.SelectedIndex = 0;
                    CarregarGrid();
                }
            }
            catch (ValidationException ex)
            {
                string mensagensErro = string.Join("\n", ex.Errors.Select(erro => "- " + erro.ErrorMessage));

                MessageBox.Show(
                    "Verifique os seguintes campos:\n\n" + mensagensErro,
                    "Dados Inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no sistema:\n" + ex.Message, "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControlBase.SelectedIndex = 0;
        }

        protected virtual void CarregarGrid() { }
        protected virtual void CarregarRegistro(DataGridViewRow row) { }
        protected virtual bool Salvar() { return false; }
        protected virtual void Deletar(int id) { }
        protected virtual void LimparCampos() { }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}