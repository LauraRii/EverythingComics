namespace EverythingComics.App.Cadastros
{
    partial class CadastroMovimentacao
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
            cboProduto = new MaterialSkin.Controls.MaterialComboBox();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            txtObs = new MaterialSkin.Controls.MaterialTextBox2();
            radioEntrada = new MaterialSkin.Controls.MaterialRadioButton();
            radioSaida = new MaterialSkin.Controls.MaterialRadioButton();
            dtpData = new DateTimePicker();
            lblData = new MaterialSkin.Controls.MaterialLabel();
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
            tabPageCadastro.Controls.Add(cboProduto);
            tabPageCadastro.Controls.Add(radioEntrada);
            tabPageCadastro.Controls.Add(radioSaida);
            tabPageCadastro.Controls.Add(txtQuantidade);
            tabPageCadastro.Controls.Add(txtObs);
            tabPageCadastro.Controls.Add(lblData);
            tabPageCadastro.Controls.Add(dtpData);
            tabPageCadastro.Location = new Point(4, 26);
            tabPageCadastro.Size = new Size(793, 393);
            tabPageCadastro.Controls.SetChildIndex(dtpData, 0);
            tabPageCadastro.Controls.SetChildIndex(lblData, 0);
            tabPageCadastro.Controls.SetChildIndex(txtObs, 0);
            tabPageCadastro.Controls.SetChildIndex(txtQuantidade, 0);
            tabPageCadastro.Controls.SetChildIndex(radioSaida, 0);
            tabPageCadastro.Controls.SetChildIndex(radioEntrada, 0);
            tabPageCadastro.Controls.SetChildIndex(cboProduto, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(567, 336);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(7, 348);
            btnEditar.Visible = false;
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
            // cboProduto
            // 
            cboProduto.AutoResize = false;
            cboProduto.BackColor = Color.FromArgb(242, 242, 242);
            cboProduto.Depth = 0;
            cboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduto.DropDownHeight = 174;
            cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduto.DropDownWidth = 121;
            cboProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduto.FormattingEnabled = true;
            cboProduto.Hint = "Selecione o Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(120, 19);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = MaterialSkin.MouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(400, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BackColor = Color.FromArgb(242, 242, 242);
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(20, 90);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(150, 48);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtObs
            // 
            txtObs.AnimateReadOnly = false;
            txtObs.BackColor = Color.FromArgb(242, 242, 242);
            txtObs.BackgroundImageLayout = ImageLayout.None;
            txtObs.CharacterCasing = CharacterCasing.Normal;
            txtObs.Depth = 0;
            txtObs.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObs.HideSelection = true;
            txtObs.Hint = "Observação (Ex: Nota Fiscal 123)";
            txtObs.LeadingIcon = null;
            txtObs.Location = new Point(190, 90);
            txtObs.MaxLength = 100;
            txtObs.MouseState = MaterialSkin.MouseState.OUT;
            txtObs.Name = "txtObs";
            txtObs.PasswordChar = '\0';
            txtObs.PrefixSuffixText = null;
            txtObs.ReadOnly = false;
            txtObs.RightToLeft = RightToLeft.No;
            txtObs.SelectedText = "";
            txtObs.SelectionLength = 0;
            txtObs.SelectionStart = 0;
            txtObs.ShortcutsEnabled = true;
            txtObs.Size = new Size(550, 48);
            txtObs.TabIndex = 5;
            txtObs.TabStop = false;
            txtObs.TextAlign = HorizontalAlignment.Left;
            txtObs.TrailingIcon = null;
            txtObs.UseSystemPasswordChar = false;
            // 
            // radioEntrada
            // 
            radioEntrada.AutoSize = true;
            radioEntrada.BackColor = Color.FromArgb(242, 242, 242);
            radioEntrada.Depth = 0;
            radioEntrada.ForeColor = Color.FromArgb(222, 0, 0, 0);
            radioEntrada.Location = new Point(540, 25);
            radioEntrada.Margin = new Padding(0);
            radioEntrada.MouseLocation = new Point(-1, -1);
            radioEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            radioEntrada.Name = "radioEntrada";
            radioEntrada.Ripple = true;
            radioEntrada.Size = new Size(90, 37);
            radioEntrada.TabIndex = 2;
            radioEntrada.TabStop = true;
            radioEntrada.Text = "Entrada";
            radioEntrada.UseVisualStyleBackColor = false;
            // 
            // radioSaida
            // 
            radioSaida.AutoSize = true;
            radioSaida.BackColor = Color.FromArgb(242, 242, 242);
            radioSaida.Depth = 0;
            radioSaida.ForeColor = Color.FromArgb(222, 0, 0, 0);
            radioSaida.Location = new Point(640, 25);
            radioSaida.Margin = new Padding(0);
            radioSaida.MouseLocation = new Point(-1, -1);
            radioSaida.MouseState = MaterialSkin.MouseState.HOVER;
            radioSaida.Name = "radioSaida";
            radioSaida.Ripple = true;
            radioSaida.Size = new Size(76, 37);
            radioSaida.TabIndex = 3;
            radioSaida.TabStop = true;
            radioSaida.Text = "Saída";
            radioSaida.UseVisualStyleBackColor = false;
            // 
            // dtpData
            // 
            dtpData.BackColor = Color.FromArgb(242, 242, 242);
            dtpData.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(20, 175);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(150, 24);
            dtpData.TabIndex = 7;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.BackColor = Color.FromArgb(242, 242, 242);
            lblData.Depth = 0;
            lblData.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblData.Location = new Point(20, 150);
            lblData.MouseState = MaterialSkin.MouseState.HOVER;
            lblData.Name = "lblData";
            lblData.Size = new Size(149, 19);
            lblData.TabIndex = 6;
            lblData.Text = "Data Movimentação:";
            // 
            // CadastroMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Location = new Point(0, 0);
            Name = "CadastroMovimentacao";
            Text = "Movimentação de Estoque";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtId;
        private MaterialSkin.Controls.MaterialComboBox cboProduto;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox2 txtObs;
        private MaterialSkin.Controls.MaterialRadioButton radioEntrada;
        private MaterialSkin.Controls.MaterialRadioButton radioSaida;
        private System.Windows.Forms.DateTimePicker dtpData;
        private MaterialSkin.Controls.MaterialLabel lblData;
    }
}