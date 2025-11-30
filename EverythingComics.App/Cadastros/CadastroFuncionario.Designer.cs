namespace EverythingComics.App.Cadastros
{
    partial class CadastroFuncionario
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
            txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            txtCpf = new MaterialSkin.Controls.MaterialTextBox2();
            txtCargo = new MaterialSkin.Controls.MaterialTextBox2();
            txtDepartamento = new MaterialSkin.Controls.MaterialTextBox2();
            txtCelular = new MaterialSkin.Controls.MaterialTextBox2();
            txtSalario = new MaterialSkin.Controls.MaterialTextBox2();
            txtStatus = new MaterialSkin.Controls.MaterialTextBox2();
            txtId = new MaterialSkin.Controls.MaterialTextBox2();
            dtpDataNasc = new DateTimePicker();
            lblDataNasc = new MaterialSkin.Controls.MaterialLabel();
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
            tabPageCadastro.Controls.Add(txtCpf);
            tabPageCadastro.Controls.Add(txtCargo);
            tabPageCadastro.Controls.Add(txtDepartamento);
            tabPageCadastro.Controls.Add(txtCelular);
            tabPageCadastro.Controls.Add(txtSalario);
            tabPageCadastro.Controls.Add(txtStatus);
            tabPageCadastro.Controls.Add(lblDataNasc);
            tabPageCadastro.Controls.Add(dtpDataNasc);
            tabPageCadastro.Location = new Point(4, 26);
            tabPageCadastro.Size = new Size(793, 393);
            tabPageCadastro.Controls.SetChildIndex(dtpDataNasc, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDataNasc, 0);
            tabPageCadastro.Controls.SetChildIndex(txtStatus, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSalario, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCelular, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDepartamento, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCargo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCpf, 0);
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
            btnCancelar.Location = new Point(662, 348);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(550, 348);
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
            txtNome.Hint = "Nome do Funcionário";
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
            // txtCpf
            // 
            txtCpf.AnimateReadOnly = false;
            txtCpf.BackColor = Color.FromArgb(242, 242, 242);
            txtCpf.BackgroundImageLayout = ImageLayout.None;
            txtCpf.CharacterCasing = CharacterCasing.Normal;
            txtCpf.Depth = 0;
            txtCpf.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpf.HideSelection = true;
            txtCpf.Hint = "CPF";
            txtCpf.LeadingIcon = null;
            txtCpf.Location = new Point(540, 20);
            txtCpf.MaxLength = 11;
            txtCpf.MouseState = MaterialSkin.MouseState.OUT;
            txtCpf.Name = "txtCpf";
            txtCpf.PasswordChar = '\0';
            txtCpf.PrefixSuffixText = null;
            txtCpf.ReadOnly = false;
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.SelectedText = "";
            txtCpf.SelectionLength = 0;
            txtCpf.SelectionStart = 0;
            txtCpf.ShortcutsEnabled = true;
            txtCpf.Size = new Size(200, 48);
            txtCpf.TabIndex = 2;
            txtCpf.TabStop = false;
            txtCpf.TextAlign = HorizontalAlignment.Left;
            txtCpf.TrailingIcon = null;
            txtCpf.UseSystemPasswordChar = false;
            // 
            // txtCargo
            // 
            txtCargo.AnimateReadOnly = false;
            txtCargo.BackColor = Color.FromArgb(242, 242, 242);
            txtCargo.BackgroundImageLayout = ImageLayout.None;
            txtCargo.CharacterCasing = CharacterCasing.Normal;
            txtCargo.Depth = 0;
            txtCargo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCargo.HideSelection = true;
            txtCargo.Hint = "Cargo";
            txtCargo.LeadingIcon = null;
            txtCargo.Location = new Point(20, 90);
            txtCargo.MaxLength = 40;
            txtCargo.MouseState = MaterialSkin.MouseState.OUT;
            txtCargo.Name = "txtCargo";
            txtCargo.PasswordChar = '\0';
            txtCargo.PrefixSuffixText = null;
            txtCargo.ReadOnly = false;
            txtCargo.RightToLeft = RightToLeft.No;
            txtCargo.SelectedText = "";
            txtCargo.SelectionLength = 0;
            txtCargo.SelectionStart = 0;
            txtCargo.ShortcutsEnabled = true;
            txtCargo.Size = new Size(250, 48);
            txtCargo.TabIndex = 3;
            txtCargo.TabStop = false;
            txtCargo.TextAlign = HorizontalAlignment.Left;
            txtCargo.TrailingIcon = null;
            txtCargo.UseSystemPasswordChar = false;
            // 
            // txtDepartamento
            // 
            txtDepartamento.AnimateReadOnly = false;
            txtDepartamento.BackColor = Color.FromArgb(242, 242, 242);
            txtDepartamento.BackgroundImageLayout = ImageLayout.None;
            txtDepartamento.CharacterCasing = CharacterCasing.Normal;
            txtDepartamento.Depth = 0;
            txtDepartamento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDepartamento.HideSelection = true;
            txtDepartamento.Hint = "Departamento";
            txtDepartamento.LeadingIcon = null;
            txtDepartamento.Location = new Point(290, 90);
            txtDepartamento.MaxLength = 40;
            txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.PasswordChar = '\0';
            txtDepartamento.PrefixSuffixText = null;
            txtDepartamento.ReadOnly = false;
            txtDepartamento.RightToLeft = RightToLeft.No;
            txtDepartamento.SelectedText = "";
            txtDepartamento.SelectionLength = 0;
            txtDepartamento.SelectionStart = 0;
            txtDepartamento.ShortcutsEnabled = true;
            txtDepartamento.Size = new Size(230, 48);
            txtDepartamento.TabIndex = 4;
            txtDepartamento.TabStop = false;
            txtDepartamento.TextAlign = HorizontalAlignment.Left;
            txtDepartamento.TrailingIcon = null;
            txtDepartamento.UseSystemPasswordChar = false;
            // 
            // txtCelular
            // 
            txtCelular.AnimateReadOnly = false;
            txtCelular.BackColor = Color.FromArgb(242, 242, 242);
            txtCelular.BackgroundImageLayout = ImageLayout.None;
            txtCelular.CharacterCasing = CharacterCasing.Normal;
            txtCelular.Depth = 0;
            txtCelular.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCelular.HideSelection = true;
            txtCelular.Hint = "Celular";
            txtCelular.LeadingIcon = null;
            txtCelular.Location = new Point(540, 90);
            txtCelular.MaxLength = 11;
            txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            txtCelular.Name = "txtCelular";
            txtCelular.PasswordChar = '\0';
            txtCelular.PrefixSuffixText = null;
            txtCelular.ReadOnly = false;
            txtCelular.RightToLeft = RightToLeft.No;
            txtCelular.SelectedText = "";
            txtCelular.SelectionLength = 0;
            txtCelular.SelectionStart = 0;
            txtCelular.ShortcutsEnabled = true;
            txtCelular.Size = new Size(200, 48);
            txtCelular.TabIndex = 5;
            txtCelular.TabStop = false;
            txtCelular.TextAlign = HorizontalAlignment.Left;
            txtCelular.TrailingIcon = null;
            txtCelular.UseSystemPasswordChar = false;
            // 
            // txtSalario
            // 
            txtSalario.AnimateReadOnly = false;
            txtSalario.BackColor = Color.FromArgb(242, 242, 242);
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.CharacterCasing = CharacterCasing.Normal;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalario.HideSelection = true;
            txtSalario.Hint = "Salário (R$)";
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(20, 160);
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = MaterialSkin.MouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffixText = null;
            txtSalario.ReadOnly = false;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(150, 48);
            txtSalario.TabIndex = 6;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Left;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            // 
            // txtStatus
            // 
            txtStatus.AnimateReadOnly = false;
            txtStatus.BackColor = Color.FromArgb(242, 242, 242);
            txtStatus.BackgroundImageLayout = ImageLayout.None;
            txtStatus.CharacterCasing = CharacterCasing.Normal;
            txtStatus.Depth = 0;
            txtStatus.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStatus.HideSelection = true;
            txtStatus.Hint = "Status (Ex: Ativo)";
            txtStatus.LeadingIcon = null;
            txtStatus.Location = new Point(190, 160);
            txtStatus.MaxLength = 40;
            txtStatus.MouseState = MaterialSkin.MouseState.OUT;
            txtStatus.Name = "txtStatus";
            txtStatus.PasswordChar = '\0';
            txtStatus.PrefixSuffixText = null;
            txtStatus.ReadOnly = false;
            txtStatus.RightToLeft = RightToLeft.No;
            txtStatus.SelectedText = "";
            txtStatus.SelectionLength = 0;
            txtStatus.SelectionStart = 0;
            txtStatus.ShortcutsEnabled = true;
            txtStatus.Size = new Size(200, 48);
            txtStatus.TabIndex = 7;
            txtStatus.TabStop = false;
            txtStatus.TextAlign = HorizontalAlignment.Left;
            txtStatus.TrailingIcon = null;
            txtStatus.UseSystemPasswordChar = false;
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
            // dtpDataNasc
            // 
            dtpDataNasc.BackColor = Color.FromArgb(242, 242, 242);
            dtpDataNasc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDataNasc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(420, 185);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(150, 24);
            dtpDataNasc.TabIndex = 9;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.BackColor = Color.FromArgb(242, 242, 242);
            lblDataNasc.Depth = 0;
            lblDataNasc.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataNasc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDataNasc.Location = new Point(420, 160);
            lblDataNasc.MouseState = MaterialSkin.MouseState.HOVER;
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(149, 19);
            lblDataNasc.TabIndex = 8;
            lblDataNasc.Text = "Data de Nascimento:";
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Location = new Point(0, 0);
            Name = "CadastroFuncionario";
            Text = "Cadastro de Funcionários";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private MaterialSkin.Controls.MaterialTextBox2 txtCpf;
        private MaterialSkin.Controls.MaterialTextBox2 txtCargo;
        private MaterialSkin.Controls.MaterialTextBox2 txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox2 txtCelular;
        private MaterialSkin.Controls.MaterialTextBox2 txtSalario;
        private MaterialSkin.Controls.MaterialTextBox2 txtStatus;
        private MaterialSkin.Controls.MaterialTextBox2 txtId;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private MaterialSkin.Controls.MaterialLabel lblDataNasc;
    }
}