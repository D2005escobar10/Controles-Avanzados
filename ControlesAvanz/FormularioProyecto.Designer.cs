namespace ControlesAvanz
{
    partial class FormularioProyecto
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(331, 129);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 0;
            button1.Text = "Crear Tarea";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormularioProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "FormularioProyecto";
            Text = "FormularioProyecto";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}