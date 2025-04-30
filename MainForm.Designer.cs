namespace ModelStateEditorApp
{
    partial class MainForm
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
            btnPrintEditScope = new System.Windows.Forms.Button();
            btnPrintModelStatesInEdit = new System.Windows.Forms.Button();
            btnChangeModelStatesInEdit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnPrintEditScope
            // 
            btnPrintEditScope.Location = new System.Drawing.Point(50, 50);
            btnPrintEditScope.Name = "btnPrintEditScope";
            btnPrintEditScope.Size = new System.Drawing.Size(200, 30);
            btnPrintEditScope.TabIndex = 0;
            btnPrintEditScope.Text = "Print Edit Scope";
            btnPrintEditScope.UseVisualStyleBackColor = true;
            btnPrintEditScope.Click += btnPrintEditScope_Click;
            // 
            // btnPrintModelStatesInEdit
            // 
            btnPrintModelStatesInEdit.Location = new System.Drawing.Point(50, 100);
            btnPrintModelStatesInEdit.Name = "btnPrintModelStatesInEdit";
            btnPrintModelStatesInEdit.Size = new System.Drawing.Size(200, 30);
            btnPrintModelStatesInEdit.TabIndex = 1;
            btnPrintModelStatesInEdit.Text = "Print Model States in Edit";
            btnPrintModelStatesInEdit.UseVisualStyleBackColor = true;
            btnPrintModelStatesInEdit.Click += btnPrintModelStatesInEdit_Click;
            // 
            // btnChangeModelStatesInEdit
            // 
            btnChangeModelStatesInEdit.Location = new System.Drawing.Point(50, 150);
            btnChangeModelStatesInEdit.Name = "btnChangeModelStatesInEdit";
            btnChangeModelStatesInEdit.Size = new System.Drawing.Size(200, 30);
            btnChangeModelStatesInEdit.TabIndex = 2;
            btnChangeModelStatesInEdit.Text = "Change Model States in Edit";
            btnChangeModelStatesInEdit.UseVisualStyleBackColor = true;
            btnChangeModelStatesInEdit.Click += btnChangeModelStatesInEdit_Click;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(300, 250);
            Controls.Add(btnChangeModelStatesInEdit);
            Controls.Add(btnPrintModelStatesInEdit);
            Controls.Add(btnPrintEditScope);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Inventor Model State Operations";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPrintEditScope;
        private System.Windows.Forms.Button btnPrintModelStatesInEdit;
        private System.Windows.Forms.Button btnChangeModelStatesInEdit;
    }

}
