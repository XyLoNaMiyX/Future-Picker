namespace Future_Picker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startB = new System.Windows.Forms.Button();
            this.questionL = new System.Windows.Forms.Label();
            this.dislikeB = new System.Windows.Forms.Button();
            this.neutralB = new System.Windows.Forms.Button();
            this.likeB = new System.Windows.Forms.Button();
            this.currentQuestionL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scorePB = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acceptB = new System.Windows.Forms.Button();
            this.becomeL = new System.Windows.Forms.Label();
            this.scoresLV = new System.Windows.Forms.ListView();
            this.fieldCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkUpdatesB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePB)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(3, 3);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(164, 23);
            this.startB.TabIndex = 0;
            this.startB.TabStop = false;
            this.startB.Text = "Comenzar test";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // questionL
            // 
            this.questionL.AutoSize = true;
            this.questionL.Location = new System.Drawing.Point(3, 3);
            this.questionL.Name = "questionL";
            this.questionL.Size = new System.Drawing.Size(165, 13);
            this.questionL.TabIndex = 1;
            this.questionL.Text = "Inicializando zona de preguntas...";
            // 
            // dislikeB
            // 
            this.dislikeB.Location = new System.Drawing.Point(3, 55);
            this.dislikeB.Name = "dislikeB";
            this.dislikeB.Size = new System.Drawing.Size(75, 23);
            this.dislikeB.TabIndex = 2;
            this.dislikeB.Text = "No me gusta";
            this.dislikeB.UseVisualStyleBackColor = true;
            this.dislikeB.Click += new System.EventHandler(this.dislikeB_Click);
            // 
            // neutralB
            // 
            this.neutralB.Location = new System.Drawing.Point(3, 84);
            this.neutralB.Name = "neutralB";
            this.neutralB.Size = new System.Drawing.Size(164, 23);
            this.neutralB.TabIndex = 3;
            this.neutralB.Text = "Me es indiferente/desconozco";
            this.neutralB.UseVisualStyleBackColor = true;
            this.neutralB.Click += new System.EventHandler(this.neutralB_Click);
            // 
            // likeB
            // 
            this.likeB.Location = new System.Drawing.Point(92, 55);
            this.likeB.Name = "likeB";
            this.likeB.Size = new System.Drawing.Size(75, 23);
            this.likeB.TabIndex = 4;
            this.likeB.Text = "Me gusta";
            this.likeB.UseVisualStyleBackColor = true;
            this.likeB.Click += new System.EventHandler(this.likeB_Click);
            // 
            // currentQuestionL
            // 
            this.currentQuestionL.AutoSize = true;
            this.currentQuestionL.Location = new System.Drawing.Point(3, 36);
            this.currentQuestionL.Name = "currentQuestionL";
            this.currentQuestionL.Size = new System.Drawing.Size(76, 13);
            this.currentQuestionL.TabIndex = 5;
            this.currentQuestionL.Text = "Pregunta 1/60";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startB);
            this.panel1.Location = new System.Drawing.Point(217, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 34);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scorePB);
            this.panel2.Controls.Add(this.questionL);
            this.panel2.Controls.Add(this.dislikeB);
            this.panel2.Controls.Add(this.currentQuestionL);
            this.panel2.Controls.Add(this.neutralB);
            this.panel2.Controls.Add(this.likeB);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 171);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // scorePB
            // 
            this.scorePB.Location = new System.Drawing.Point(173, 55);
            this.scorePB.Name = "scorePB";
            this.scorePB.Size = new System.Drawing.Size(50, 50);
            this.scorePB.TabIndex = 6;
            this.scorePB.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkUpdatesB);
            this.panel3.Controls.Add(this.acceptB);
            this.panel3.Controls.Add(this.becomeL);
            this.panel3.Controls.Add(this.scoresLV);
            this.panel3.Location = new System.Drawing.Point(518, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 315);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // acceptB
            // 
            this.acceptB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptB.Location = new System.Drawing.Point(146, 242);
            this.acceptB.Name = "acceptB";
            this.acceptB.Size = new System.Drawing.Size(74, 23);
            this.acceptB.TabIndex = 2;
            this.acceptB.Text = "Aceptar y salir";
            this.acceptB.UseVisualStyleBackColor = true;
            this.acceptB.Click += new System.EventHandler(this.acceptB_Click);
            // 
            // becomeL
            // 
            this.becomeL.AutoSize = true;
            this.becomeL.Location = new System.Drawing.Point(3, 5);
            this.becomeL.Name = "becomeL";
            this.becomeL.Size = new System.Drawing.Size(105, 13);
            this.becomeL.TabIndex = 1;
            this.becomeL.Text = "¡Deberías hacerte...!";
            // 
            // scoresLV
            // 
            this.scoresLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fieldCH,
            this.scoreCH});
            this.scoresLV.FullRowSelect = true;
            this.scoresLV.GridLines = true;
            this.scoresLV.Location = new System.Drawing.Point(2, 24);
            this.scoresLV.Name = "scoresLV";
            this.scoresLV.Size = new System.Drawing.Size(218, 212);
            this.scoresLV.TabIndex = 0;
            this.scoresLV.UseCompatibleStateImageBehavior = false;
            this.scoresLV.View = System.Windows.Forms.View.Details;
            // 
            // fieldCH
            // 
            this.fieldCH.Text = "Campo";
            this.fieldCH.Width = 183;
            // 
            // scoreCH
            // 
            this.scoreCH.Text = "Pts";
            this.scoreCH.Width = 28;
            // 
            // checkUpdatesB
            // 
            this.checkUpdatesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUpdatesB.Location = new System.Drawing.Point(6, 243);
            this.checkUpdatesB.Name = "checkUpdatesB";
            this.checkUpdatesB.Size = new System.Drawing.Size(134, 23);
            this.checkUpdatesB.TabIndex = 3;
            this.checkUpdatesB.Text = "Comprobar actualizaciones";
            this.checkUpdatesB.UseVisualStyleBackColor = true;
            this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 372);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 80);
            this.Name = "Form1";
            this.Text = "Futuro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scorePB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Label questionL;
        private System.Windows.Forms.Button dislikeB;
        private System.Windows.Forms.Button neutralB;
        private System.Windows.Forms.Button likeB;
        private System.Windows.Forms.Label currentQuestionL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox scorePB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView scoresLV;
        private System.Windows.Forms.ColumnHeader fieldCH;
        private System.Windows.Forms.ColumnHeader scoreCH;
        private System.Windows.Forms.Label becomeL;
        private System.Windows.Forms.Button acceptB;
        private System.Windows.Forms.Button checkUpdatesB;
    }
}

