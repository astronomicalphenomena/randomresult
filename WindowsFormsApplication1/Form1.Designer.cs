namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.microblogDataSet1 = new WindowsFormsApplication1.microblogDataSet();
            this.predataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predataTableAdapter = new WindowsFormsApplication1.microblogDataSetTableAdapters.predataTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.microblogDataSetTableAdapters.TableAdapterManager();
            this.trainTableAdapter = new WindowsFormsApplication1.microblogDataSetTableAdapters.trainTableAdapter();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.microblogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 208);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // microblogDataSet1
            // 
            this.microblogDataSet1.DataSetName = "microblogDataSet";
            this.microblogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predataBindingSource
            // 
            this.predataBindingSource.DataMember = "predata";
            this.predataBindingSource.DataSource = this.microblogDataSet1;
            // 
            // predataTableAdapter
            // 
            this.predataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.predataTableAdapter = this.predataTableAdapter;
            this.tableAdapterManager.trainTableAdapter = this.trainTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.microblogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "train";
            this.trainBindingSource.DataSource = this.microblogDataSet1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "今天选择的魔法种子";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "随机结果生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.microblogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private microblogDataSet microblogDataSet1;
        private System.Windows.Forms.BindingSource predataBindingSource;
        private microblogDataSetTableAdapters.predataTableAdapter predataTableAdapter;
        private microblogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private microblogDataSetTableAdapters.trainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

