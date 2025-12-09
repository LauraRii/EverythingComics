namespace EverythingComics.App.Cadastros
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            txtCnpj = new MaterialSkin.Controls.MaterialTextBox2();
            txtRua = new MaterialSkin.Controls.MaterialTextBox2();
            txtBairro = new MaterialSkin.Controls.MaterialTextBox2();
            txtCidade = new MaterialSkin.Controls.MaterialTextBox2();
            cboEstado = new MaterialSkin.Controls.MaterialComboBox();
            txtCep = new MaterialSkin.Controls.MaterialTextBox2();
            txtId = new MaterialSkin.Controls.MaterialTextBox2();
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
            tabPageCadastro.Controls.Add(txtCnpj);
            tabPageCadastro.Controls.Add(txtCep);
            tabPageCadastro.Controls.Add(txtRua);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Location = new Point(4, 26);
            tabPageCadastro.Size = new Size(793, 393);
            tabPageCadastro.Controls.SetChildIndex(cboEstado, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBairro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRua, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCep, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCnpj, 0);
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
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.BackColor = Color.FromArgb(242, 242, 242);
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome Completo";
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
            txtNome.Size = new Size(400, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCnpj
            // 
            txtCnpj.AnimateReadOnly = false;
            txtCnpj.BackColor = Color.FromArgb(242, 242, 242);
            txtCnpj.BackgroundImageLayout = ImageLayout.None;
            txtCnpj.CharacterCasing = CharacterCasing.Normal;
            txtCnpj.Depth = 0;
            txtCnpj.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCnpj.HideSelection = true;
            txtCnpj.Hint = "CPF / CNPJ";
            txtCnpj.LeadingIcon = null;
            txtCnpj.Location = new Point(540, 20);
            txtCnpj.MaxLength = 14;
            txtCnpj.MouseState = MaterialSkin.MouseState.OUT;
            txtCnpj.Name = "txtCnpj";
            txtCnpj.PasswordChar = '\0';
            txtCnpj.PrefixSuffixText = null;
            txtCnpj.ReadOnly = false;
            txtCnpj.RightToLeft = RightToLeft.No;
            txtCnpj.SelectedText = "";
            txtCnpj.SelectionLength = 0;
            txtCnpj.SelectionStart = 0;
            txtCnpj.ShortcutsEnabled = true;
            txtCnpj.Size = new Size(200, 48);
            txtCnpj.TabIndex = 2;
            txtCnpj.TabStop = false;
            txtCnpj.TextAlign = HorizontalAlignment.Left;
            txtCnpj.TrailingIcon = null;
            txtCnpj.UseSystemPasswordChar = false;
            // 
            // txtRua
            // 
            txtRua.AnimateReadOnly = false;
            txtRua.BackColor = Color.FromArgb(242, 242, 242);
            txtRua.BackgroundImageLayout = ImageLayout.None;
            txtRua.CharacterCasing = CharacterCasing.Normal;
            txtRua.Depth = 0;
            txtRua.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRua.HideSelection = true;
            txtRua.Hint = "Rua";
            txtRua.LeadingIcon = null;
            txtRua.Location = new Point(190, 90);
            txtRua.MaxLength = 40;
            txtRua.MouseState = MaterialSkin.MouseState.OUT;
            txtRua.Name = "txtRua";
            txtRua.PasswordChar = '\0';
            txtRua.PrefixSuffixText = null;
            txtRua.ReadOnly = false;
            txtRua.RightToLeft = RightToLeft.No;
            txtRua.SelectedText = "";
            txtRua.SelectionLength = 0;
            txtRua.SelectionStart = 0;
            txtRua.ShortcutsEnabled = true;
            txtRua.Size = new Size(350, 48);
            txtRua.TabIndex = 4;
            txtRua.TabStop = false;
            txtRua.TextAlign = HorizontalAlignment.Left;
            txtRua.TrailingIcon = null;
            txtRua.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.BackColor = Color.FromArgb(242, 242, 242);
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(560, 90);
            txtBairro.MaxLength = 40;
            txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(180, 48);
            txtBairro.TabIndex = 5;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.BackColor = Color.FromArgb(242, 242, 242);
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(20, 160);
            txtCidade.MaxLength = 40;
            txtCidade.MouseState = MaterialSkin.MouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(300, 48);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(242, 242, 242);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "UF";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Location = new Point(340, 160);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = MaterialSkin.MouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(80, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 7;
            // 
            // txtCep
            // 
            txtCep.AnimateReadOnly = false;
            txtCep.BackColor = Color.FromArgb(242, 242, 242);
            txtCep.BackgroundImageLayout = ImageLayout.None;
            txtCep.CharacterCasing = CharacterCasing.Normal;
            txtCep.Depth = 0;
            txtCep.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCep.HideSelection = true;
            txtCep.Hint = "CEP";
            txtCep.LeadingIcon = null;
            txtCep.Location = new Point(20, 90);
            txtCep.MaxLength = 8;
            txtCep.MouseState = MaterialSkin.MouseState.OUT;
            txtCep.Name = "txtCep";
            txtCep.PasswordChar = '\0';
            txtCep.PrefixSuffixText = null;
            txtCep.ReadOnly = false;
            txtCep.RightToLeft = RightToLeft.No;
            txtCep.SelectedText = "";
            txtCep.SelectionLength = 0;
            txtCep.SelectionStart = 0;
            txtCep.ShortcutsEnabled = true;
            txtCep.Size = new Size(150, 48);
            txtCep.TabIndex = 3;
            txtCep.TabStop = false;
            txtCep.TextAlign = HorizontalAlignment.Left;
            txtCep.TrailingIcon = null;
            txtCep.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.BackColor = Color.FromArgb(242, 242, 242);
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Location = new Point(0, 0);
            Name = "CadastroCliente";
            Text = "Cadastro de Clientes";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Variáveis
        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private MaterialSkin.Controls.MaterialTextBox2 txtCnpj;
        private MaterialSkin.Controls.MaterialTextBox2 txtRua;
        private MaterialSkin.Controls.MaterialTextBox2 txtBairro;
        private MaterialSkin.Controls.MaterialTextBox2 txtCidade;
        private MaterialSkin.Controls.MaterialComboBox cboEstado; 
        private MaterialSkin.Controls.MaterialTextBox2 txtCep;
        private MaterialSkin.Controls.MaterialTextBox2 txtId;
    }
}