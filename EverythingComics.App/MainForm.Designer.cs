namespace EverythingComics.App
{
    partial class MainForm
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
            btnClientes = new MaterialSkin.Controls.MaterialButton();
            btnFuncionarios = new MaterialSkin.Controls.MaterialButton();
            btnProdutos = new MaterialSkin.Controls.MaterialButton();
            btnVendas = new MaterialSkin.Controls.MaterialButton();
            btnEstoque = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.AutoSize = false;
            btnClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClientes.Depth = 0;
            btnClientes.HighEmphasis = true;
            btnClientes.Icon = null;
            btnClientes.Location = new Point(50, 50);
            btnClientes.Margin = new Padding(4, 6, 4, 6);
            btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            btnClientes.Name = "btnClientes";
            btnClientes.NoAccentTextColor = Color.Empty;
            btnClientes.Size = new Size(200, 60);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CLIENTES";
            btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClientes.UseAccentColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.AutoSize = false;
            btnFuncionarios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFuncionarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFuncionarios.Depth = 0;
            btnFuncionarios.HighEmphasis = true;
            btnFuncionarios.Icon = null;
            btnFuncionarios.Location = new Point(280, 50);
            btnFuncionarios.Margin = new Padding(4, 6, 4, 6);
            btnFuncionarios.MouseState = MaterialSkin.MouseState.HOVER;
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.NoAccentTextColor = Color.Empty;
            btnFuncionarios.Size = new Size(200, 60);
            btnFuncionarios.TabIndex = 1;
            btnFuncionarios.Text = "FUNCIONÁRIOS";
            btnFuncionarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFuncionarios.UseAccentColor = false;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.AutoSize = false;
            btnProdutos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProdutos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProdutos.Depth = 0;
            btnProdutos.HighEmphasis = true;
            btnProdutos.Icon = null;
            btnProdutos.Location = new Point(510, 50);
            btnProdutos.Margin = new Padding(4, 6, 4, 6);
            btnProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            btnProdutos.Name = "btnProdutos";
            btnProdutos.NoAccentTextColor = Color.Empty;
            btnProdutos.Size = new Size(200, 60);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "PRODUTOS";
            btnProdutos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProdutos.UseAccentColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnVendas
            // 
            btnVendas.AutoSize = false;
            btnVendas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVendas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVendas.Depth = 0;
            btnVendas.HighEmphasis = true;
            btnVendas.Icon = null;
            btnVendas.Location = new Point(50, 150);
            btnVendas.Margin = new Padding(4, 6, 4, 6);
            btnVendas.MouseState = MaterialSkin.MouseState.HOVER;
            btnVendas.Name = "btnVendas";
            btnVendas.NoAccentTextColor = Color.Empty;
            btnVendas.Size = new Size(200, 60);
            btnVendas.TabIndex = 3;
            btnVendas.Text = "REALIZAR VENDA";
            btnVendas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVendas.UseAccentColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.AutoSize = false;
            btnEstoque.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEstoque.Depth = 0;
            btnEstoque.HighEmphasis = true;
            btnEstoque.Icon = null;
            btnEstoque.Location = new Point(280, 150);
            btnEstoque.Margin = new Padding(4, 6, 4, 6);
            btnEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            btnEstoque.Name = "btnEstoque";
            btnEstoque.NoAccentTextColor = Color.Empty;
            btnEstoque.Size = new Size(200, 60);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "MOVIMENTAÇÃO";
            btnEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEstoque.UseAccentColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnEstoque);
            materialCard1.Controls.Add(btnVendas);
            materialCard1.Controls.Add(btnProdutos);
            materialCard1.Controls.Add(btnFuncionarios);
            materialCard1.Controls.Add(btnClientes);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 343);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(766, 258);
            materialCard1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 788);
            Controls.Add(materialCard1);
            Name = "MainForm";
            Text = "Everything Comics - Sistema de Gestão";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClientes;
        private MaterialSkin.Controls.MaterialButton btnFuncionarios;
        private MaterialSkin.Controls.MaterialButton btnProdutos;
        private MaterialSkin.Controls.MaterialButton btnVendas;
        private MaterialSkin.Controls.MaterialButton btnEstoque;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}