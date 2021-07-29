
namespace Primer_Proyecto_de_Formulario_en_visual_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClickThis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblHelloWorld = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lbl2);
            this.panel1.Controls.Add(this.LblHelloWorld);
            this.panel1.Controls.Add(this.BtnClickThis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 265);
            this.panel1.TabIndex = 0;
            // 
            // BtnClickThis
            // 
            this.BtnClickThis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnClickThis.BackColor = System.Drawing.Color.Maroon;
            this.BtnClickThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClickThis.BorderRadius = 0;
            this.BtnClickThis.ButtonText = "ClickThis";
            this.BtnClickThis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClickThis.DisabledColor = System.Drawing.Color.Gray;
            this.BtnClickThis.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClickThis.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnClickThis.Iconimage")));
            this.BtnClickThis.Iconimage_right = null;
            this.BtnClickThis.Iconimage_right_Selected = null;
            this.BtnClickThis.Iconimage_Selected = null;
            this.BtnClickThis.IconMarginLeft = 0;
            this.BtnClickThis.IconMarginRight = 0;
            this.BtnClickThis.IconRightVisible = true;
            this.BtnClickThis.IconRightZoom = 0D;
            this.BtnClickThis.IconVisible = true;
            this.BtnClickThis.IconZoom = 90D;
            this.BtnClickThis.IsTab = false;
            this.BtnClickThis.Location = new System.Drawing.Point(326, 39);
            this.BtnClickThis.Name = "BtnClickThis";
            this.BtnClickThis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnClickThis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnClickThis.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClickThis.selected = false;
            this.BtnClickThis.Size = new System.Drawing.Size(112, 41);
            this.BtnClickThis.TabIndex = 1;
            this.BtnClickThis.Text = "ClickThis";
            this.BtnClickThis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClickThis.Textcolor = System.Drawing.Color.White;
            this.BtnClickThis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClickThis.Click += new System.EventHandler(this.BtnClickThis_Click);
            // 
            // LblHelloWorld
            // 
            this.LblHelloWorld.AutoSize = true;
            this.LblHelloWorld.BackColor = System.Drawing.Color.White;
            this.LblHelloWorld.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHelloWorld.Location = new System.Drawing.Point(208, 111);
            this.LblHelloWorld.Name = "LblHelloWorld";
            this.LblHelloWorld.Size = new System.Drawing.Size(0, 21);
            this.LblHelloWorld.TabIndex = 2;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.BackColor = System.Drawing.Color.White;
            this.Lbl2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(36, 130);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(0, 21);
            this.Lbl2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 265);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnClickThis;
        private System.Windows.Forms.Label LblHelloWorld;
        private System.Windows.Forms.Label Lbl2;
    }
}

