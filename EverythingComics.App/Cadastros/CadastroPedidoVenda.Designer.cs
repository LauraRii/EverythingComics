namespace EverythingComics.App.Cadastros
{
    partial class CadastroPedidoVenda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtId = new MaterialSkin.Controls.MaterialTextBox2();
            cboCliente = new MaterialSkin.Controls.MaterialComboBox();
            cboFuncionario = new MaterialSkin.Controls.MaterialComboBox();
            dtpDataVenda = new DateTimePicker();
            lblDataVenda = new MaterialSkin.Controls.MaterialLabel();
            dtpDataEntrega = new DateTimePicker();
            lblDataEntrega = new MaterialSkin.Controls.MaterialLabel();
            txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            groupBoxItens = new GroupBox();
            gridItens = new DataGridView();
            btnAdicionarItem = new ReaLTaiizor.Controls.MaterialButton();
            txtQtdItem = new MaterialSkin.Controls.MaterialTextBox2();
            txtPrecoUnit = new MaterialSkin.Controls.MaterialTextBox2();
            cboProduto = new MaterialSkin.Controls.MaterialComboBox();
            lblAviso = new MaterialSkin.Controls.MaterialLabel();
            tabControlBase.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBoxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridItens).BeginInit();
            SuspendLayout();
            // 
            // tabControlBase
            // 
            tabControlBase.Size = new Size(801, 508);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 26);
            tabPageConsulta.Size = new Size(793, 478);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(cboFuncionario);
            tabPageCadastro.Controls.Add(lblDataVenda);
            tabPageCadastro.Controls.Add(dtpDataVenda);
            tabPageCadastro.Controls.Add(lblDataEntrega);
            tabPageCadastro.Controls.Add(dtpDataEntrega);
            tabPageCadastro.Controls.Add(txtTotal);
            tabPageCadastro.Controls.Add(groupBoxItens);
            tabPageCadastro.Controls.Add(lblAviso);
            tabPageCadastro.Location = new Point(4, 26);
            tabPageCadastro.Size = new Size(793, 478);
            tabPageCadastro.Controls.SetChildIndex(lblAviso, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBoxItens, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTotal, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataEntrega, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDataEntrega, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpDataVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDataVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFuncionario, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
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
            btnCancelar.Location = new Point(636, 406);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(520, 406);
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
            txtId.Hint = "ID Venda";
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
            txtId.Size = new Size(100, 48);
            txtId.TabIndex = 0;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(242, 242, 242);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(140, 19);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = MaterialSkin.MouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(300, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 1;
            // 
            // cboFuncionario
            // 
            cboFuncionario.AutoResize = false;
            cboFuncionario.BackColor = Color.FromArgb(242, 242, 242);
            cboFuncionario.Depth = 0;
            cboFuncionario.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncionario.DropDownHeight = 174;
            cboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncionario.DropDownWidth = 121;
            cboFuncionario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncionario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFuncionario.Hint = "Funcionário";
            cboFuncionario.IntegralHeight = false;
            cboFuncionario.ItemHeight = 43;
            cboFuncionario.Location = new Point(460, 19);
            cboFuncionario.MaxDropDownItems = 4;
            cboFuncionario.MouseState = MaterialSkin.MouseState.OUT;
            cboFuncionario.Name = "cboFuncionario";
            cboFuncionario.Size = new Size(300, 49);
            cboFuncionario.StartIndex = 0;
            cboFuncionario.TabIndex = 2;
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.BackColor = Color.FromArgb(242, 242, 242);
            dtpDataVenda.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDataVenda.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpDataVenda.Format = DateTimePickerFormat.Short;
            dtpDataVenda.Location = new Point(20, 115);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(120, 24);
            dtpDataVenda.TabIndex = 5;
            // 
            // lblDataVenda
            // 
            lblDataVenda.AutoSize = true;
            lblDataVenda.BackColor = Color.FromArgb(242, 242, 242);
            lblDataVenda.Depth = 0;
            lblDataVenda.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataVenda.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDataVenda.Location = new Point(20, 90);
            lblDataVenda.MouseState = MaterialSkin.MouseState.HOVER;
            lblDataVenda.Name = "lblDataVenda";
            lblDataVenda.Size = new Size(88, 19);
            lblDataVenda.TabIndex = 4;
            lblDataVenda.Text = "Data Venda:";
            // 
            // dtpDataEntrega
            // 
            dtpDataEntrega.BackColor = Color.FromArgb(242, 242, 242);
            dtpDataEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpDataEntrega.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtpDataEntrega.Format = DateTimePickerFormat.Short;
            dtpDataEntrega.Location = new Point(180, 115);
            dtpDataEntrega.Name = "dtpDataEntrega";
            dtpDataEntrega.Size = new Size(120, 24);
            dtpDataEntrega.TabIndex = 7;
            // 
            // lblDataEntrega
            // 
            lblDataEntrega.AutoSize = true;
            lblDataEntrega.BackColor = Color.FromArgb(242, 242, 242);
            lblDataEntrega.Depth = 0;
            lblDataEntrega.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDataEntrega.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDataEntrega.Location = new Point(180, 90);
            lblDataEntrega.MouseState = MaterialSkin.MouseState.HOVER;
            lblDataEntrega.Name = "lblDataEntrega";
            lblDataEntrega.Size = new Size(97, 19);
            lblDataEntrega.TabIndex = 6;
            lblDataEntrega.Text = "Data Entrega:";
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = false;
            txtTotal.BackColor = Color.FromArgb(242, 242, 242);
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "TOTAL DA VENDA (R$)";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(560, 90);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(200, 48);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // groupBoxItens
            // 
            groupBoxItens.BackColor = Color.FromArgb(242, 242, 242);
            groupBoxItens.Controls.Add(gridItens);
            groupBoxItens.Controls.Add(btnAdicionarItem);
            groupBoxItens.Controls.Add(txtQtdItem);
            groupBoxItens.Controls.Add(txtPrecoUnit);
            groupBoxItens.Controls.Add(cboProduto);
            groupBoxItens.Enabled = false;
            groupBoxItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBoxItens.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBoxItens.Location = new Point(20, 160);
            groupBoxItens.Name = "groupBoxItens";
            groupBoxItens.Size = new Size(740, 220);
            groupBoxItens.TabIndex = 6;
            groupBoxItens.TabStop = false;
            groupBoxItens.Text = "Itens da Venda (Salve a venda para habilitar)";
            // 
            // gridItens
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridItens.DefaultCellStyle = dataGridViewCellStyle2;
            gridItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            gridItens.Location = new Point(15, 85);
            gridItens.Name = "gridItens";
            gridItens.Size = new Size(705, 115);
            gridItens.TabIndex = 4;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.AutoSize = false;
            btnAdicionarItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarItem.BackColor = Color.FromArgb(242, 242, 242);
            btnAdicionarItem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionarItem.Depth = 0;
            btnAdicionarItem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnAdicionarItem.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnAdicionarItem.HighEmphasis = true;
            btnAdicionarItem.Icon = Properties.Resources.btnAdicionarItemIcon;
            btnAdicionarItem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionarItem.ImageAlign = ContentAlignment.MiddleRight;
            btnAdicionarItem.Location = new Point(540, 35);
            btnAdicionarItem.Margin = new Padding(4, 6, 4, 6);
            btnAdicionarItem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.NoAccentTextColor = Color.Empty;
            btnAdicionarItem.Size = new Size(180, 40);
            btnAdicionarItem.TabIndex = 3;
            btnAdicionarItem.Text = "ADICIONAR ITEM";
            btnAdicionarItem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionarItem.UseAccentColor = false;
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // txtQtdItem
            // 
            txtQtdItem.AnimateReadOnly = false;
            txtQtdItem.BackColor = Color.FromArgb(242, 242, 242);
            txtQtdItem.BackgroundImageLayout = ImageLayout.None;
            txtQtdItem.CharacterCasing = CharacterCasing.Normal;
            txtQtdItem.Depth = 0;
            txtQtdItem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQtdItem.HideSelection = true;
            txtQtdItem.Hint = "Qtd";
            txtQtdItem.LeadingIcon = null;
            txtQtdItem.Location = new Point(330, 30);
            txtQtdItem.MaxLength = 32767;
            txtQtdItem.MouseState = MaterialSkin.MouseState.OUT;
            txtQtdItem.Name = "txtQtdItem";
            txtQtdItem.PasswordChar = '\0';
            txtQtdItem.PrefixSuffixText = null;
            txtQtdItem.ReadOnly = false;
            txtQtdItem.RightToLeft = RightToLeft.No;
            txtQtdItem.SelectedText = "";
            txtQtdItem.SelectionLength = 0;
            txtQtdItem.SelectionStart = 0;
            txtQtdItem.ShortcutsEnabled = true;
            txtQtdItem.Size = new Size(80, 48);
            txtQtdItem.TabIndex = 1;
            txtQtdItem.TabStop = false;
            txtQtdItem.TextAlign = HorizontalAlignment.Left;
            txtQtdItem.TrailingIcon = null;
            txtQtdItem.UseSystemPasswordChar = false;
            // 
            // txtPrecoUnit
            // 
            txtPrecoUnit.AnimateReadOnly = false;
            txtPrecoUnit.BackColor = Color.FromArgb(242, 242, 242);
            txtPrecoUnit.BackgroundImageLayout = ImageLayout.None;
            txtPrecoUnit.CharacterCasing = CharacterCasing.Normal;
            txtPrecoUnit.Depth = 0;
            txtPrecoUnit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoUnit.HideSelection = true;
            txtPrecoUnit.Hint = "Preço (R$)";
            txtPrecoUnit.LeadingIcon = null;
            txtPrecoUnit.Location = new Point(420, 30);
            txtPrecoUnit.MaxLength = 32767;
            txtPrecoUnit.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecoUnit.Name = "txtPrecoUnit";
            txtPrecoUnit.PasswordChar = '\0';
            txtPrecoUnit.PrefixSuffixText = null;
            txtPrecoUnit.ReadOnly = false;
            txtPrecoUnit.RightToLeft = RightToLeft.No;
            txtPrecoUnit.SelectedText = "";
            txtPrecoUnit.SelectionLength = 0;
            txtPrecoUnit.SelectionStart = 0;
            txtPrecoUnit.ShortcutsEnabled = true;
            txtPrecoUnit.Size = new Size(100, 48);
            txtPrecoUnit.TabIndex = 2;
            txtPrecoUnit.TabStop = false;
            txtPrecoUnit.TextAlign = HorizontalAlignment.Left;
            txtPrecoUnit.TrailingIcon = null;
            txtPrecoUnit.UseSystemPasswordChar = false;
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
            cboProduto.Hint = "Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(15, 30);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = MaterialSkin.MouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(300, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 0;
            cboProduto.SelectedIndexChanged += cboProduto_SelectedIndexChanged;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = Color.FromArgb(242, 242, 242);
            lblAviso.Depth = 0;
            lblAviso.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            lblAviso.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            lblAviso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblAviso.Location = new Point(308, 143);
            lblAviso.MouseState = MaterialSkin.MouseState.HOVER;
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(246, 14);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "* Salve a venda primeiro para adicionar itens.";
            // 
            // CadastroPedidoVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Location = new Point(0, 0);
            Name = "CadastroPedidoVenda";
            Text = "Vendas";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            groupBoxItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtId;
        private MaterialSkin.Controls.MaterialComboBox cboCliente;
        private MaterialSkin.Controls.MaterialComboBox cboFuncionario;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private MaterialSkin.Controls.MaterialLabel lblDataVenda;
        private MaterialSkin.Controls.MaterialLabel lblDataEntrega;

        private System.Windows.Forms.GroupBox groupBoxItens;
        private System.Windows.Forms.DataGridView gridItens;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionarItem;
        private MaterialSkin.Controls.MaterialTextBox2 txtQtdItem;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecoUnit;
        private MaterialSkin.Controls.MaterialComboBox cboProduto;
        private MaterialSkin.Controls.MaterialLabel lblAviso;
    }
}