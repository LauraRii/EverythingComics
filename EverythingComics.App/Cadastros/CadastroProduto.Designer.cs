namespace EverythingComics.App.Cadastros
{
    partial class CadastroProduto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtId = new MaterialSkin.Controls.MaterialTextBox2();
            txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            txtQtdEstoque = new MaterialSkin.Controls.MaterialTextBox2();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox2();
            dtpDataCriacao = new DateTimePicker();
            lblDataCriacao = new MaterialSkin.Controls.MaterialLabel();
            tabControlBase.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 26);
            tabPageConsulta.Size = new Size(793, 393);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(txtQtdEstoque);
            tabPageCadastro.Controls.Add(lblDataCriacao);
            tabPageCadastro.Controls.Add(dtpDataCriacao);
            tabPageCadastro.Location = new Point(4, 26);
            tabPageCadastro.Size = new Size(793, 393);
            tabPageCadastro.Controls.SetChildIndex(dtpDataCriacao, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDataCriacao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQtdEstoque, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(460, 334);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(558, 334);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(665, 334);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(662, 321);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(550, 321);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.BackColor = Color.FromArgb(242, 242, 242);
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(20, 20);
            txtId.MaxLength = 32767;
            txtId.MouseState = MaterialSkin.MouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(80, 48);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.BackColor = Color.FromArgb(242, 242, 242);
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome do Produto";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(120, 20);
            txtNome.MaxLength = 40;
            txtNome.MouseState = MaterialSkin.MouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(500, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.AnimateReadOnly = false;
            txtQtdEstoque.BackColor = Color.FromArgb(242, 242, 242);
            txtQtdEstoque.BackgroundImageLayout = ImageLayout.None;
            txtQtdEstoque.CharacterCasing = CharacterCasing.Normal;
            txtQtdEstoque.Depth = 0;
            txtQtdEstoque.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQtdEstoque.HideSelection = true;
            txtQtdEstoque.Hint = "Qtd. em Estoque";
            txtQtdEstoque.LeadingIcon = null;
            txtQtdEstoque.Location = new Point(240, 90);
            txtQtdEstoque.MaxLength = 32767;
            txtQtdEstoque.MouseState = MaterialSkin.MouseState.OUT;
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.PasswordChar = '\0';
            txtQtdEstoque.PrefixSuffixText = null;
            txtQtdEstoque.ReadOnly = false;
            txtQtdEstoque.RightToLeft = RightToLeft.No;
            txtQtdEstoque.SelectedText = "";
            txtQtdEstoque.SelectionLength = 0;
            txtQtdEstoque.SelectionStart = 0;
            txtQtdEstoque.ShortcutsEnabled = true;
            txtQtdEstoque.Size = new Size(200, 48);
            txtQtdEstoque.TabIndex = 3;
            txtQtdEstoque.TabStop = false;
            txtQtdEstoque.TextAlign = HorizontalAlignment.Left;
            txtQtdEstoque.TrailingIcon = null;
            txtQtdEstoque.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BackColor = Color.FromArgb(242, 242, 242);
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço Unitário (R$)";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(20, 90);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = false;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(200, 48);
            txtPreco.TabIndex = 2;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            // 
            // dtpDataCriacao
            // 
            dtpDataCriacao.BackColor = Color.FromArgb(242, 242, 242);
            dtpDataCriacao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDataCriacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpDataCriacao.Format = DateTimePickerFormat.Short;
            dtpDataCriacao.Location = new Point(460, 115);
            dtpDataCriacao.Name = "dtpDataCriacao";
            dtpDataCriacao.Size = new Size(150, 24);
            dtpDataCriacao.TabIndex = 5;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.BackColor = Color.FromArgb(242, 242, 242);
            lblDataCriacao.Depth = 0;
            lblDataCriacao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataCriacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDataCriacao.Location = new Point(460, 90);
            lblDataCriacao.MouseState = MaterialSkin.MouseState.HOVER;
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(118, 19);
            lblDataCriacao.TabIndex = 4;
            lblDataCriacao.Text = "Data de Criação:";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Location = new Point(0, 0);
            Name = "CadastroProduto";
            Text = "Cadastro de Produtos";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtId;
        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private MaterialSkin.Controls.MaterialTextBox2 txtQtdEstoque;
        private MaterialSkin.Controls.MaterialTextBox2 txtPreco;
        private System.Windows.Forms.DateTimePicker dtpDataCriacao;
        private MaterialSkin.Controls.MaterialLabel lblDataCriacao;
    }
}