namespace PR_4_Plotnikov_PR_21_102_CH_M
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMatrixSize = new System.Windows.Forms.TextBox();
            this.listBoxAnswer = new System.Windows.Forms.ListBox();
            this.btnLU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMatrix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxMemSize = new System.Windows.Forms.TextBox();
            this.btnUPDmaxMemSize = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUPDB = new System.Windows.Forms.Button();
            this.btnSimpleIteration = new System.Windows.Forms.Button();
            this.btnPRGNK = new System.Windows.Forms.Button();
            this.btnMinDelta = new System.Windows.Forms.Button();
            this.textBoxMinDelta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMatrixSize
            // 
            this.textBoxMatrixSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMatrixSize.Location = new System.Drawing.Point(154, 9);
            this.textBoxMatrixSize.Name = "textBoxMatrixSize";
            this.textBoxMatrixSize.Size = new System.Drawing.Size(102, 26);
            this.textBoxMatrixSize.TabIndex = 0;
            // 
            // listBoxAnswer
            // 
            this.listBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAnswer.FormattingEnabled = true;
            this.listBoxAnswer.ItemHeight = 25;
            this.listBoxAnswer.Location = new System.Drawing.Point(502, 71);
            this.listBoxAnswer.Name = "listBoxAnswer";
            this.listBoxAnswer.Size = new System.Drawing.Size(1049, 579);
            this.listBoxAnswer.TabIndex = 1;
            // 
            // btnLU
            // 
            this.btnLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLU.Location = new System.Drawing.Point(19, 376);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(156, 80);
            this.btnLU.TabIndex = 2;
            this.btnLU.Text = "Метод разложения LU";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер матрицы";
            // 
            // btnNewMatrix
            // 
            this.btnNewMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewMatrix.Location = new System.Drawing.Point(16, 41);
            this.btnNewMatrix.Name = "btnNewMatrix";
            this.btnNewMatrix.Size = new System.Drawing.Size(424, 56);
            this.btnNewMatrix.TabIndex = 4;
            this.btnNewMatrix.Text = "Создать новую матрицу введённого размера";
            this.btnNewMatrix.UseVisualStyleBackColor = true;
            this.btnNewMatrix.Click += new System.EventHandler(this.btnNewMatrix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строка";
            // 
            // textBoxLine
            // 
            this.textBoxLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLine.Location = new System.Drawing.Point(16, 134);
            this.textBoxLine.Name = "textBoxLine";
            this.textBoxLine.Size = new System.Drawing.Size(443, 31);
            this.textBoxLine.TabIndex = 5;
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpd.Location = new System.Drawing.Point(154, 171);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(172, 56);
            this.btnUpd.TabIndex = 7;
            this.btnUpd.Text = "Изменить выбранную строку";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrev.Location = new System.Drawing.Point(16, 171);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(132, 56);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Предыдущая строка";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(328, 171);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 56);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Следующая строка";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Методы решения (решить методом):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(495, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Консоль вывода:";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 60);
            this.label5.TabIndex = 13;
            this.label5.Text = "Максимальный отступ между элементами \r\n(для корректного вывода, так для 2-значных" +
    " чисел\r\n рекомендуемое значение 4, для четырёхзначных 7)";
            // 
            // textBoxMaxMemSize
            // 
            this.textBoxMaxMemSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxMemSize.Location = new System.Drawing.Point(18, 551);
            this.textBoxMaxMemSize.Name = "textBoxMaxMemSize";
            this.textBoxMaxMemSize.Size = new System.Drawing.Size(176, 26);
            this.textBoxMaxMemSize.TabIndex = 12;
            // 
            // btnUPDmaxMemSize
            // 
            this.btnUPDmaxMemSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUPDmaxMemSize.Location = new System.Drawing.Point(200, 551);
            this.btnUPDmaxMemSize.Name = "btnUPDmaxMemSize";
            this.btnUPDmaxMemSize.Size = new System.Drawing.Size(169, 26);
            this.btnUPDmaxMemSize.TabIndex = 14;
            this.btnUPDmaxMemSize.Text = "Обновить значение";
            this.btnUPDmaxMemSize.UseVisualStyleBackColor = true;
            this.btnUPDmaxMemSize.Click += new System.EventHandler(this.btnUPDmaxMemSize_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(14, 267);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(424, 31);
            this.textBoxB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите матрицу B (через пробел, как сверху вниз)";
            // 
            // btnUPDB
            // 
            this.btnUPDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUPDB.Location = new System.Drawing.Point(14, 304);
            this.btnUPDB.Name = "btnUPDB";
            this.btnUPDB.Size = new System.Drawing.Size(201, 26);
            this.btnUPDB.TabIndex = 17;
            this.btnUPDB.Text = "Обновить значения";
            this.btnUPDB.UseVisualStyleBackColor = true;
            this.btnUPDB.Click += new System.EventHandler(this.btnUPDB_Click);
            // 
            // btnSimpleIteration
            // 
            this.btnSimpleIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSimpleIteration.Location = new System.Drawing.Point(181, 376);
            this.btnSimpleIteration.Name = "btnSimpleIteration";
            this.btnSimpleIteration.Size = new System.Drawing.Size(160, 80);
            this.btnSimpleIteration.TabIndex = 18;
            this.btnSimpleIteration.Text = "Метод простой итерации";
            this.btnSimpleIteration.UseVisualStyleBackColor = true;
            this.btnSimpleIteration.Click += new System.EventHandler(this.btnSimpleIteration_Click);
            // 
            // btnPRGNK
            // 
            this.btnPRGNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPRGNK.Location = new System.Drawing.Point(347, 376);
            this.btnPRGNK.Name = "btnPRGNK";
            this.btnPRGNK.Size = new System.Drawing.Size(112, 80);
            this.btnPRGNK.TabIndex = 19;
            this.btnPRGNK.Text = "Метод прогонки";
            this.btnPRGNK.UseVisualStyleBackColor = true;
            this.btnPRGNK.Click += new System.EventHandler(this.btnPRGNK_Click);
            // 
            // btnMinDelta
            // 
            this.btnMinDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinDelta.Location = new System.Drawing.Point(201, 632);
            this.btnMinDelta.Name = "btnMinDelta";
            this.btnMinDelta.Size = new System.Drawing.Size(176, 26);
            this.btnMinDelta.TabIndex = 20;
            this.btnMinDelta.Text = "Обновить значение";
            this.btnMinDelta.UseVisualStyleBackColor = true;
            this.btnMinDelta.Click += new System.EventHandler(this.btnMinDelta_Click);
            // 
            // textBoxMinDelta
            // 
            this.textBoxMinDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinDelta.Location = new System.Drawing.Point(19, 631);
            this.textBoxMinDelta.Name = "textBoxMinDelta";
            this.textBoxMinDelta.Size = new System.Drawing.Size(176, 26);
            this.textBoxMinDelta.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Точность (только метод итераций)";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(1036, 9);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(515, 56);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Text = "Как пользоваться этой программой?\r\n(Нажать для вывода инструкции)";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 669);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMinDelta);
            this.Controls.Add(this.btnMinDelta);
            this.Controls.Add(this.btnPRGNK);
            this.Controls.Add(this.btnSimpleIteration);
            this.Controls.Add(this.btnUPDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.btnUPDmaxMemSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxMemSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLine);
            this.Controls.Add(this.btnNewMatrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.listBoxAnswer);
            this.Controls.Add(this.textBoxMatrixSize);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ методами: разложения LU, прогонки, простой итерации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatrixSize;
        private System.Windows.Forms.ListBox listBoxAnswer;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLine;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxMemSize;
        private System.Windows.Forms.Button btnUPDmaxMemSize;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUPDB;
        private System.Windows.Forms.Button btnSimpleIteration;
        private System.Windows.Forms.Button btnPRGNK;
        private System.Windows.Forms.Button btnMinDelta;
        private System.Windows.Forms.TextBox textBoxMinDelta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHelp;
    }
}

