namespace AiSD_pracadomowa_1
{
    partial class Form1
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
            this.BubbleSort = new System.Windows.Forms.Button();
            this.InsertSort = new System.Windows.Forms.Button();
            this.MergeSort = new System.Windows.Forms.Button();
            this.QuickSort = new System.Windows.Forms.Button();
            this.CountingSort = new System.Windows.Forms.Button();
            this.AddFirst = new System.Windows.Forms.Button();
            this.AddLast = new System.Windows.Forms.Button();
            this.RemoveFirst = new System.Windows.Forms.Button();
            this.RemoveLast = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(24, 23);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(153, 23);
            this.BubbleSort.TabIndex = 0;
            this.BubbleSort.Text = "Sortowanie Bąbelkowe";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // InsertSort
            // 
            this.InsertSort.Location = new System.Drawing.Point(24, 68);
            this.InsertSort.Name = "InsertSort";
            this.InsertSort.Size = new System.Drawing.Size(153, 23);
            this.InsertSort.TabIndex = 1;
            this.InsertSort.Text = "Sortowanie Przez Wstawianie";
            this.InsertSort.UseVisualStyleBackColor = true;
            this.InsertSort.Click += new System.EventHandler(this.InsertSort_Click);
            // 
            // MergeSort
            // 
            this.MergeSort.Location = new System.Drawing.Point(24, 114);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(153, 23);
            this.MergeSort.TabIndex = 2;
            this.MergeSort.Text = "Sortowanie Przez Scalanie";
            this.MergeSort.UseVisualStyleBackColor = true;
            this.MergeSort.Click += new System.EventHandler(this.MergeSort_Click);
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(24, 161);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(153, 23);
            this.QuickSort.TabIndex = 3;
            this.QuickSort.Text = "Szybkie Sortownie";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // CountingSort
            // 
            this.CountingSort.Location = new System.Drawing.Point(24, 208);
            this.CountingSort.Name = "CountingSort";
            this.CountingSort.Size = new System.Drawing.Size(153, 23);
            this.CountingSort.TabIndex = 4;
            this.CountingSort.Text = "Sortowanie Przez Zliczanie";
            this.CountingSort.UseVisualStyleBackColor = true;
            this.CountingSort.Click += new System.EventHandler(this.CountingSort_Click);
            // 
            // AddFirst
            // 
            this.AddFirst.Location = new System.Drawing.Point(220, 23);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(143, 23);
            this.AddFirst.TabIndex = 5;
            this.AddFirst.Text = "Wstawianie na początku";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // AddLast
            // 
            this.AddLast.Location = new System.Drawing.Point(220, 68);
            this.AddLast.Name = "AddLast";
            this.AddLast.Size = new System.Drawing.Size(143, 23);
            this.AddLast.TabIndex = 6;
            this.AddLast.Text = "Wstawianie na końcu";
            this.AddLast.UseVisualStyleBackColor = true;
            this.AddLast.Click += new System.EventHandler(this.AddLast_Click);
            // 
            // RemoveFirst
            // 
            this.RemoveFirst.Location = new System.Drawing.Point(220, 114);
            this.RemoveFirst.Name = "RemoveFirst";
            this.RemoveFirst.Size = new System.Drawing.Size(143, 23);
            this.RemoveFirst.TabIndex = 7;
            this.RemoveFirst.Text = "Usuwanie na początku";
            this.RemoveFirst.UseVisualStyleBackColor = true;
            this.RemoveFirst.Click += new System.EventHandler(this.RemoveFirst_Click);
            // 
            // RemoveLast
            // 
            this.RemoveLast.Location = new System.Drawing.Point(220, 161);
            this.RemoveLast.Name = "RemoveLast";
            this.RemoveLast.Size = new System.Drawing.Size(143, 23);
            this.RemoveLast.TabIndex = 8;
            this.RemoveLast.Text = "Usuwanie na końcu";
            this.RemoveLast.UseVisualStyleBackColor = true;
            this.RemoveLast.Click += new System.EventHandler(this.RemoveLast_Click);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(220, 208);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(143, 23);
            this.Get.TabIndex = 9;
            this.Get.Text = "Wstaw w ...";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.RemoveLast);
            this.Controls.Add(this.RemoveFirst);
            this.Controls.Add(this.AddLast);
            this.Controls.Add(this.AddFirst);
            this.Controls.Add(this.CountingSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.InsertSort);
            this.Controls.Add(this.BubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button InsertSort;
        private System.Windows.Forms.Button MergeSort;
        private System.Windows.Forms.Button QuickSort;
        private System.Windows.Forms.Button CountingSort;
        private System.Windows.Forms.Button AddFirst;
        private System.Windows.Forms.Button AddLast;
        private System.Windows.Forms.Button RemoveFirst;
        private System.Windows.Forms.Button RemoveLast;
        private System.Windows.Forms.Button Get;
    }
}

