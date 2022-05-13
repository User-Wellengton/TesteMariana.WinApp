namespace TesteMariana.WinApp.ModuloMateria
{
    partial class TelaCadastroMateriaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.radioButtonSerieUm = new System.Windows.Forms.RadioButton();
            this.radioButtonSerieDois = new System.Windows.Forms.RadioButton();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(198, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(117, 223);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Disciplina:";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(101, 22);
            this.txtBoxNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(83, 23);
            this.txtBoxNumero.TabIndex = 16;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(101, 44);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(199, 23);
            this.textBoxNome.TabIndex = 17;
            // 
            // radioButtonSerieUm
            // 
            this.radioButtonSerieUm.AutoSize = true;
            this.radioButtonSerieUm.Location = new System.Drawing.Point(4, 18);
            this.radioButtonSerieUm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSerieUm.Name = "radioButtonSerieUm";
            this.radioButtonSerieUm.Size = new System.Drawing.Size(59, 19);
            this.radioButtonSerieUm.TabIndex = 18;
            this.radioButtonSerieUm.TabStop = true;
            this.radioButtonSerieUm.Text = "1 Série";
            this.radioButtonSerieUm.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerieDois
            // 
            this.radioButtonSerieDois.AutoSize = true;
            this.radioButtonSerieDois.Location = new System.Drawing.Point(85, 18);
            this.radioButtonSerieDois.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSerieDois.Name = "radioButtonSerieDois";
            this.radioButtonSerieDois.Size = new System.Drawing.Size(59, 19);
            this.radioButtonSerieDois.TabIndex = 19;
            this.radioButtonSerieDois.TabStop = true;
            this.radioButtonSerieDois.Text = "2 Série";
            this.radioButtonSerieDois.UseVisualStyleBackColor = true;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(101, 67);
            this.comboBoxDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(129, 23);
            this.comboBoxDisciplina.TabIndex = 20;
            this.comboBoxDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButtonSerieDois);
            this.groupBox.Controls.Add(this.radioButtonSerieUm);
            this.groupBox.Location = new System.Drawing.Point(66, 98);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox.Size = new System.Drawing.Size(210, 41);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Série:";
            // 
            // TelaCadastroMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaCadastroMateriaForm";
            this.Text = "Tela Cadastro Matéria";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.RadioButton radioButtonSerieUm;
        private System.Windows.Forms.RadioButton radioButtonSerieDois;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.GroupBox groupBox;
    }
}