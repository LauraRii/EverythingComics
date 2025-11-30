namespace EverythingComics.App.Cadastros
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            tabControlBase = new TabControl();
            tabPageConsulta = new TabPage();
            btnExcluir = new MaterialSkin.Controls.MaterialButton();
            dataGridViewBase = new DataGridView();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnNovo = new MaterialSkin.Controls.MaterialButton();
            tabPageCadastro = new TabPage();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabControlBase.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase).BeginInit();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlBase
            // 
            tabControlBase.Controls.Add(tabPageConsulta);
            tabControlBase.Controls.Add(tabPageCadastro);
            tabControlBase.ImageList = imageList1;
            tabControlBase.Location = new Point(-1, 67);
            tabControlBase.Name = "tabControlBase";
            tabControlBase.SelectedIndex = 0;
            tabControlBase.Size = new Size(801, 423);
            tabControlBase.TabIndex = 0;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(dataGridViewBase);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.ImageKey = "consultaIcon.png";
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(793, 395);
            tabPageConsulta.TabIndex = 0;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = false;
            btnExcluir.Icon = Properties.Resources.btnExcluirIcon;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(665, 336);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(108, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dataGridViewBase
            // 
            dataGridViewBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase.Location = new Point(3, 3);
            dataGridViewBase.Name = "dataGridViewBase";
            dataGridViewBase.Size = new Size(787, 324);
            dataGridViewBase.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = false;
            btnEditar.Icon = Properties.Resources.btnEditarIcon;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(558, 336);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(99, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = Properties.Resources.btnNovoIcon;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(460, 336);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(90, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "NOVO";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.ImageKey = "cadastroIcon.png";
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(793, 395);
            tabPageCadastro.TabIndex = 1;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = false;
            btnCancelar.Icon = Properties.Resources.btnCancelarIcon;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(662, 323);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(124, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = Properties.Resources.btnSalvarIcon;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(550, 323);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(104, 36);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cadastroIcon.png");
            imageList1.Images.SetKeyName(1, "consultaIcon.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(tabControlBase);
            Name = "CadastroBase";
            Text = "CadastroBase";
            tabControlBase.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase).EndInit();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabControlBase;
        protected System.Windows.Forms.TabPage tabPageConsulta;
        protected System.Windows.Forms.TabPage tabPageCadastro;
        protected System.Windows.Forms.DataGridView dataGridViewBase;
        protected MaterialSkin.Controls.MaterialButton btnNovo;
        protected MaterialSkin.Controls.MaterialButton btnEditar;
        protected MaterialSkin.Controls.MaterialButton btnExcluir;
        protected MaterialSkin.Controls.MaterialButton btnCancelar;
        protected MaterialSkin.Controls.MaterialButton btnSalvar;
        private ImageList imageList1;
    }
}