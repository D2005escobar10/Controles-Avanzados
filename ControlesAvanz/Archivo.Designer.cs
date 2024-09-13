namespace ControlesAvanz
{
    partial class Archivo
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
            listadoVentas = new FlowLayoutPanel();
            SelectorDepartamento = new ListBox();
            ComboBoxAnios = new ComboBox();
            ComboBoxMeses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listadoVentas
            // 
            listadoVentas.AutoScroll = true;
            listadoVentas.Location = new Point(323, 62);
            listadoVentas.Name = "listadoVentas";
            listadoVentas.Size = new Size(744, 556);
            listadoVentas.TabIndex = 0;
            // 
            // SelectorDepartamento
            // 
            SelectorDepartamento.FormattingEnabled = true;
            SelectorDepartamento.Location = new Point(33, 232);
            SelectorDepartamento.Name = "SelectorDepartamento";
            SelectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            SelectorDepartamento.Size = new Size(232, 104);
            SelectorDepartamento.TabIndex = 1;
            SelectorDepartamento.SelectedValueChanged += SelectorDepartamento_SelectedValueChanged;
            // 
            // ComboBoxAnios
            // 
            ComboBoxAnios.FormattingEnabled = true;
            ComboBoxAnios.Location = new Point(33, 65);
            ComboBoxAnios.Name = "ComboBoxAnios";
            ComboBoxAnios.Size = new Size(234, 28);
            ComboBoxAnios.TabIndex = 2;
            ComboBoxAnios.SelectedValueChanged += ComboBoxAnios_SelectedValueChanged;
            // 
            // ComboBoxMeses
            // 
            ComboBoxMeses.FormattingEnabled = true;
            ComboBoxMeses.Location = new Point(33, 135);
            ComboBoxMeses.Name = "ComboBoxMeses";
            ComboBoxMeses.Size = new Size(234, 28);
            ComboBoxMeses.TabIndex = 3;
            ComboBoxMeses.SelectedValueChanged += ComboBoxMeses_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 204);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 4;
            label1.Text = "Seleccionar Departamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 5;
            label2.Text = "Seleccionar Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 106);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 6;
            label3.Text = "Seleccionar Mes";
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 630);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComboBoxMeses);
            Controls.Add(ComboBoxAnios);
            Controls.Add(SelectorDepartamento);
            Controls.Add(listadoVentas);
            Name = "Archivo";
            Text = "Archivo";
            Load += Archivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel listadoVentas;
        private ListBox SelectorDepartamento;
        private ComboBox ComboBoxAnios;
        private ComboBox ComboBoxMeses;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}