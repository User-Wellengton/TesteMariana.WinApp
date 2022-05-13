namespace TesteMariana.WinApp.ModuloTeste
{
    partial class TelaCadastroTesteForm
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
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxProvaRecuperacao = new System.Windows.Forms.CheckBox();
            this.textBoxQuantidadeQuestoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxQuestoes = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.bntSortearQuestao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(68, 8);
            this.txtBoxNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(83, 23);
            this.txtBoxNumero.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Número:";
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.Location = new System.Drawing.Point(68, 31);
            this.txtBoxTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(136, 23);
            this.txtBoxTitulo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(256, 29);
            this.maskedTextBoxData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(106, 23);
            this.maskedTextBoxData.TabIndex = 34;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(68, 76);
            this.comboBoxMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(129, 23);
            this.comboBoxMateria.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Matéria:";
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(68, 53);
            this.comboBoxDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(129, 23);
            this.comboBoxDisciplina.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Disciplina:";
            // 
            // checkBoxProvaRecuperacao
            // 
            this.checkBoxProvaRecuperacao.AutoSize = true;
            this.checkBoxProvaRecuperacao.Location = new System.Drawing.Point(231, 56);
            this.checkBoxProvaRecuperacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxProvaRecuperacao.Name = "checkBoxProvaRecuperacao";
            this.checkBoxProvaRecuperacao.Size = new System.Drawing.Size(146, 19);
            this.checkBoxProvaRecuperacao.TabIndex = 39;
            this.checkBoxProvaRecuperacao.Text = "Prova de Recuperação ";
            this.checkBoxProvaRecuperacao.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantidadeQuestoes
            // 
            this.textBoxQuantidadeQuestoes.Location = new System.Drawing.Point(155, 100);
            this.textBoxQuantidadeQuestoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantidadeQuestoes.Name = "textBoxQuantidadeQuestoes";
            this.textBoxQuantidadeQuestoes.Size = new System.Drawing.Size(84, 23);
            this.textBoxQuantidadeQuestoes.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Quantidade de Questões:";
            // 
            // listBoxQuestoes
            // 
            this.listBoxQuestoes.FormattingEnabled = true;
            this.listBoxQuestoes.ItemHeight = 15;
            this.listBoxQuestoes.Location = new System.Drawing.Point(22, 154);
            this.listBoxQuestoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxQuestoes.Name = "listBoxQuestoes";
            this.listBoxQuestoes.Size = new System.Drawing.Size(355, 169);
            this.listBoxQuestoes.TabIndex = 44;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(304, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(223, 341);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 42;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // bntSortearQuestao
            // 
            this.bntSortearQuestao.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntSortearQuestao.Location = new System.Drawing.Point(48, 341);
            this.bntSortearQuestao.Name = "bntSortearQuestao";
            this.bntSortearQuestao.Size = new System.Drawing.Size(155, 39);
            this.bntSortearQuestao.TabIndex = 45;
            this.bntSortearQuestao.Text = "Sortear Questões";
            this.bntSortearQuestao.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTesteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 388);
            this.Controls.Add(this.bntSortearQuestao);
            this.Controls.Add(this.listBoxQuestoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textBoxQuantidadeQuestoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxProvaRecuperacao);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaCadastroTesteForm";
            this.Text = "Tela Cadastro Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxProvaRecuperacao;
        private System.Windows.Forms.TextBox textBoxQuantidadeQuestoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxQuestoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button bntSortearQuestao;
    }
}