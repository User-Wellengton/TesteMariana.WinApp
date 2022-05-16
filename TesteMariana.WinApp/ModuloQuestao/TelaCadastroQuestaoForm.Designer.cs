namespace TesteMariana.WinApp.ModuloQuestao
{
    partial class TelaCadastroQuestaoForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEnunciado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxResposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarResposta = new System.Windows.Forms.Button();
            this.checkBoxAlternativaCorreta = new System.Windows.Forms.CheckBox();
            this.listBoxRespostas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(404, 558);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 65);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(289, 558);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 65);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(156, 68);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(183, 33);
            this.comboBoxDisciplina.TabIndex = 26;
            this.comboBoxDisciplina.SelectedValueChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedValueChanged);
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Enabled = false;
            this.txtBoxNumero.Location = new System.Drawing.Point(156, 32);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(117, 31);
            this.txtBoxNumero.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Disciplina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Número:";
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(156, 108);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(183, 33);
            this.comboBoxMateria.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Matéria:";
            // 
            // txtBoxEnunciado
            // 
            this.txtBoxEnunciado.Location = new System.Drawing.Point(156, 148);
            this.txtBoxEnunciado.Name = "txtBoxEnunciado";
            this.txtBoxEnunciado.Size = new System.Drawing.Size(351, 31);
            this.txtBoxEnunciado.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enunciado:";
            // 
            // txtBoxResposta
            // 
            this.txtBoxResposta.Location = new System.Drawing.Point(131, 252);
            this.txtBoxResposta.Name = "txtBoxResposta";
            this.txtBoxResposta.Size = new System.Drawing.Size(260, 31);
            this.txtBoxResposta.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Resposta:";
            // 
            // btnAdicionarResposta
            // 
            this.btnAdicionarResposta.Location = new System.Drawing.Point(404, 252);
            this.btnAdicionarResposta.Name = "btnAdicionarResposta";
            this.btnAdicionarResposta.Size = new System.Drawing.Size(104, 33);
            this.btnAdicionarResposta.TabIndex = 33;
            this.btnAdicionarResposta.Text = "Adicionar";
            this.btnAdicionarResposta.UseVisualStyleBackColor = true;
            this.btnAdicionarResposta.Click += new System.EventHandler(this.btnAdicionarResposta_Click);
            // 
            // checkBoxAlternativaCorreta
            // 
            this.checkBoxAlternativaCorreta.AutoSize = true;
            this.checkBoxAlternativaCorreta.Location = new System.Drawing.Point(131, 300);
            this.checkBoxAlternativaCorreta.Name = "checkBoxAlternativaCorreta";
            this.checkBoxAlternativaCorreta.Size = new System.Drawing.Size(185, 29);
            this.checkBoxAlternativaCorreta.TabIndex = 34;
            this.checkBoxAlternativaCorreta.Text = "Alternativa Correta";
            this.checkBoxAlternativaCorreta.UseVisualStyleBackColor = true;
            // 
            // listBoxRespostas
            // 
            this.listBoxRespostas.FormattingEnabled = true;
            this.listBoxRespostas.ItemHeight = 25;
            this.listBoxRespostas.Location = new System.Drawing.Point(51, 338);
            this.listBoxRespostas.Name = "listBoxRespostas";
            this.listBoxRespostas.Size = new System.Drawing.Size(443, 204);
            this.listBoxRespostas.TabIndex = 35;
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 638);
            this.Controls.Add(this.listBoxRespostas);
            this.Controls.Add(this.checkBoxAlternativaCorreta);
            this.Controls.Add(this.btnAdicionarResposta);
            this.Controls.Add(this.txtBoxResposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEnunciado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "TelaCadastroQuestaoForm";
            this.Text = "Tela Cadastro Questao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEnunciado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxResposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarResposta;
        private System.Windows.Forms.CheckBox checkBoxAlternativaCorreta;
        private System.Windows.Forms.ListBox listBoxRespostas;
    }
}