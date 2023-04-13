namespace WinFormsApp1
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
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.ListChaveNfe = new System.Windows.Forms.ListBox();
      this.CHAVE_NFE = new System.Windows.Forms.TextBox();
      this.AddList = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ListChaveNfe
      // 
      this.ListChaveNfe.FormattingEnabled = true;
      this.ListChaveNfe.ItemHeight = 15;
      this.ListChaveNfe.Location = new System.Drawing.Point(12, 62);
      this.ListChaveNfe.Name = "ListChaveNfe";
      this.ListChaveNfe.Size = new System.Drawing.Size(512, 619);
      this.ListChaveNfe.TabIndex = 0;
      // 
      // CHAVE_NFE
      // 
      this.CHAVE_NFE.Location = new System.Drawing.Point(12, 12);
      this.CHAVE_NFE.Name = "CHAVE_NFE";
      this.CHAVE_NFE.Size = new System.Drawing.Size(431, 23);
      this.CHAVE_NFE.TabIndex = 1;
      this.CHAVE_NFE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHAVE_NFE_KeyDown);
      // 
      // AddList
      // 
      this.AddList.Location = new System.Drawing.Point(449, 11);
      this.AddList.Name = "AddList";
      this.AddList.Size = new System.Drawing.Size(75, 23);
      this.AddList.TabIndex = 2;
      this.AddList.Text = "Add";
      this.AddList.UseVisualStyleBackColor = true;
      this.AddList.Click += new System.EventHandler(this.AddList_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(555, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1300, 693);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.AddList);
      this.Controls.Add(this.CHAVE_NFE);
      this.Controls.Add(this.ListChaveNfe);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ListBox ListChaveNfe;
    private TextBox CHAVE_NFE;
    private Button AddList;
    private Button button1;
  }
}