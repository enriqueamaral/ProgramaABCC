namespace ProgramaABCC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConsultar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxSku = new TextBox();
            textBoxArticulo = new TextBox();
            textBoxMarca = new TextBox();
            textBoxModelo = new TextBox();
            textBoxStock = new TextBox();
            textBoxCantidad = new TextBox();
            dateTimePickerFechaAlta = new DateTimePicker();
            dateTimePickerFechaBaja = new DateTimePicker();
            checkBoxDescontinuado = new CheckBox();
            comboBoxDepartamento = new ComboBox();
            comboBoxClase = new ComboBox();
            comboBoxFamilia = new ComboBox();
            buttonAlta = new Button();
            buttonActualizar = new Button();
            buttonBorrar = new Button();
            SuspendLayout();
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(306, 6);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(75, 23);
            buttonConsultar.TabIndex = 0;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Sku:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Artículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 5;
            label5.Text = "Departamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "Clase:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Familia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 326);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 8;
            label8.Text = "Stock:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 326);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 9;
            label9.Text = "Cantidad:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 389);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 10;
            label10.Text = "Fecha Alta:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(306, 389);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 11;
            label11.Text = "Fecha Baja:";
            // 
            // textBoxSku
            // 
            textBoxSku.Location = new Point(114, 6);
            textBoxSku.Name = "textBoxSku";
            textBoxSku.Size = new Size(172, 23);
            textBoxSku.TabIndex = 12;
            textBoxSku.KeyPress += textBoxSku_KeyPress;
            // 
            // textBoxArticulo
            // 
            textBoxArticulo.Location = new Point(114, 50);
            textBoxArticulo.Name = "textBoxArticulo";
            textBoxArticulo.Size = new Size(416, 23);
            textBoxArticulo.TabIndex = 13;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(114, 101);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(416, 23);
            textBoxMarca.TabIndex = 14;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(114, 143);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(416, 23);
            textBoxModelo.TabIndex = 15;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(114, 323);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(172, 23);
            textBoxStock.TabIndex = 19;
            textBoxStock.KeyPress += textBoxStock_KeyPress;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(384, 323);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(146, 23);
            textBoxCantidad.TabIndex = 20;
            textBoxCantidad.KeyPress += textBoxCantidad_KeyPress;
            // 
            // dateTimePickerFechaAlta
            // 
            dateTimePickerFechaAlta.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaAlta.Location = new Point(114, 383);
            dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
            dateTimePickerFechaAlta.Size = new Size(112, 23);
            dateTimePickerFechaAlta.TabIndex = 22;
            // 
            // dateTimePickerFechaBaja
            // 
            dateTimePickerFechaBaja.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaBaja.Location = new Point(384, 383);
            dateTimePickerFechaBaja.Name = "dateTimePickerFechaBaja";
            dateTimePickerFechaBaja.Size = new Size(107, 23);
            dateTimePickerFechaBaja.TabIndex = 23;
            // 
            // checkBoxDescontinuado
            // 
            checkBoxDescontinuado.AutoSize = true;
            checkBoxDescontinuado.Location = new Point(438, 8);
            checkBoxDescontinuado.Name = "checkBoxDescontinuado";
            checkBoxDescontinuado.Size = new Size(106, 19);
            checkBoxDescontinuado.TabIndex = 24;
            checkBoxDescontinuado.Text = "Descontinuado";
            checkBoxDescontinuado.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.Enabled = false;
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(114, 183);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(416, 23);
            comboBoxDepartamento.TabIndex = 25;
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            // 
            // comboBoxClase
            // 
            comboBoxClase.Enabled = false;
            comboBoxClase.FormattingEnabled = true;
            comboBoxClase.Location = new Point(114, 226);
            comboBoxClase.Name = "comboBoxClase";
            comboBoxClase.Size = new Size(416, 23);
            comboBoxClase.TabIndex = 26;
            comboBoxClase.SelectedIndexChanged += comboBoxClase_SelectedIndexChanged;
            // 
            // comboBoxFamilia
            // 
            comboBoxFamilia.Enabled = false;
            comboBoxFamilia.FormattingEnabled = true;
            comboBoxFamilia.Location = new Point(114, 273);
            comboBoxFamilia.Name = "comboBoxFamilia";
            comboBoxFamilia.Size = new Size(416, 23);
            comboBoxFamilia.TabIndex = 27;
            // 
            // buttonAlta
            // 
            buttonAlta.Enabled = false;
            buttonAlta.Location = new Point(238, 427);
            buttonAlta.Name = "buttonAlta";
            buttonAlta.Size = new Size(75, 23);
            buttonAlta.TabIndex = 28;
            buttonAlta.Text = "Dar de alta";
            buttonAlta.UseVisualStyleBackColor = true;
            buttonAlta.Click += buttonAlta_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Enabled = false;
            buttonActualizar.Location = new Point(355, 427);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 29;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Enabled = false;
            buttonBorrar.Location = new Point(469, 427);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 30;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 462);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonAlta);
            Controls.Add(comboBoxFamilia);
            Controls.Add(comboBoxClase);
            Controls.Add(comboBoxDepartamento);
            Controls.Add(checkBoxDescontinuado);
            Controls.Add(dateTimePickerFechaBaja);
            Controls.Add(dateTimePickerFechaAlta);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxArticulo);
            Controls.Add(textBoxSku);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConsultar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConsultar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxSku;
        private TextBox textBoxArticulo;
        private TextBox textBoxMarca;
        private TextBox textBoxModelo;
        private TextBox textBoxStock;
        private TextBox textBoxCantidad;
        private DateTimePicker dateTimePickerFechaAlta;
        private DateTimePicker dateTimePickerFechaBaja;
        private CheckBox checkBoxDescontinuado;
        private ComboBox comboBoxDepartamento;
        private ComboBox comboBoxClase;
        private ComboBox comboBoxFamilia;
        private Button buttonAlta;
        private Button buttonActualizar;
        private Button buttonBorrar;
    }
}
