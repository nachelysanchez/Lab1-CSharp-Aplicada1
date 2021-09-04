
namespace registroUsuarios
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
            this.id = new System.Windows.Forms.Label();
            this.lid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lAlias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombres = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lClave = new System.Windows.Forms.TextBox();
            this.lClaveConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lCosto = new System.Windows.Forms.TextBox();
            this.cActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(29, 35);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 15);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lid
            // 
            this.lid.Location = new System.Drawing.Point(92, 32);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(126, 23);
            this.lid.TabIndex = 1;
            this.lid.Text = "1";
            this.lid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alias";
            // 
            // lAlias
            // 
            this.lAlias.Location = new System.Drawing.Point(92, 77);
            this.lAlias.Name = "lAlias";
            this.lAlias.Size = new System.Drawing.Size(175, 23);
            this.lAlias.TabIndex = 3;
            this.lAlias.Text = "Nach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            // 
            // lNombres
            // 
            this.lNombres.Location = new System.Drawing.Point(92, 124);
            this.lNombres.Name = "lNombres";
            this.lNombres.Size = new System.Drawing.Size(244, 23);
            this.lNombres.TabIndex = 5;
            this.lNombres.Text = "Nachely Victoria Sánchez Burgos";
            // 
            // lEmail
            // 
            this.lEmail.Location = new System.Drawing.Point(393, 124);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(212, 23);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "nachely_sanchez@ucne.edu.do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clave";
            // 
            // lClave
            // 
            this.lClave.Location = new System.Drawing.Point(92, 172);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(86, 23);
            this.lClave.TabIndex = 9;
            this.lClave.Text = "***********";
            // 
            // lClaveConfirmar
            // 
            this.lClaveConfirmar.Location = new System.Drawing.Point(296, 172);
            this.lClaveConfirmar.Name = "lClaveConfirmar";
            this.lClaveConfirmar.Size = new System.Drawing.Size(100, 23);
            this.lClaveConfirmar.TabIndex = 10;
            this.lClaveConfirmar.Text = "***********";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirmar Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Costo x Hora";
            // 
            // lCosto
            // 
            this.lCosto.Location = new System.Drawing.Point(507, 172);
            this.lCosto.Name = "lCosto";
            this.lCosto.Size = new System.Drawing.Size(100, 23);
            this.lCosto.TabIndex = 13;
            this.lCosto.Text = "102";
            // 
            // cActivo
            // 
            this.cActivo.AutoSize = true;
            this.cActivo.Checked = true;
            this.cActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cActivo.Location = new System.Drawing.Point(547, 36);
            this.cActivo.Name = "cActivo";
            this.cActivo.Size = new System.Drawing.Size(60, 19);
            this.cActivo.TabIndex = 14;
            this.cActivo.Text = "Activo";
            this.cActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nivel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Empleado"});
            this.comboBox1.Location = new System.Drawing.Point(472, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Administrador";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::registroUsuarios.Properties.Resources.icons8_nuevo_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(172, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 86);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nuevo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::registroUsuarios.Properties.Resources.icons8_guardar_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(296, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 85);
            this.button2.TabIndex = 18;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::registroUsuarios.Properties.Resources.icons8_eliminar_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(415, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 85);
            this.button3.TabIndex = 19;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::registroUsuarios.Properties.Resources.icons8_google_web_search_24;
            this.button4.Location = new System.Drawing.Point(224, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 308);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cActivo);
            this.Controls.Add(this.lCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lClaveConfirmar);
            this.Controls.Add(this.lClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lAlias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lid);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Registros de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox lid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lAlias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lNombres;
        private System.Windows.Forms.TextBox lEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lClave;
        private System.Windows.Forms.TextBox lClaveConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lCosto;
        private System.Windows.Forms.CheckBox cActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

