namespace BadLuck
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._textBoxGameNum = new System.Windows.Forms.TextBox();
            this._buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._checkBoxGraph = new System.Windows.Forms.CheckBox();
            this._chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this._chartScore)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxGameNum
            // 
            this._textBoxGameNum.Location = new System.Drawing.Point(72, 54);
            this._textBoxGameNum.Name = "_textBoxGameNum";
            this._textBoxGameNum.Size = new System.Drawing.Size(100, 19);
            this._textBoxGameNum.TabIndex = 0;
            // 
            // _buttonStart
            // 
            this._buttonStart.Location = new System.Drawing.Point(178, 51);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(75, 23);
            this._buttonStart.TabIndex = 1;
            this._buttonStart.Text = "開始";
            this._buttonStart.UseVisualStyleBackColor = true;
            this._buttonStart.Click += new System.EventHandler(this._buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "半荘回数";
            // 
            // _textBoxResult
            // 
            this._textBoxResult.Location = new System.Drawing.Point(15, 123);
            this._textBoxResult.Multiline = true;
            this._textBoxResult.Name = "_textBoxResult";
            this._textBoxResult.Size = new System.Drawing.Size(488, 168);
            this._textBoxResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "結果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "1着50pt, 2着10pt, 3着-20pt, 4着-40ptを同確率で取得するシミュレータ";
            // 
            // _checkBoxGraph
            // 
            this._checkBoxGraph.AutoSize = true;
            this._checkBoxGraph.Location = new System.Drawing.Point(72, 81);
            this._checkBoxGraph.Name = "_checkBoxGraph";
            this._checkBoxGraph.Size = new System.Drawing.Size(163, 16);
            this._checkBoxGraph.TabIndex = 7;
            this._checkBoxGraph.Text = "スコア時系列グラフを表示する";
            this._checkBoxGraph.UseVisualStyleBackColor = true;
            // 
            // _chartScore
            // 
            chartArea1.Name = "ChartArea1";
            this._chartScore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this._chartScore.Legends.Add(legend1);
            this._chartScore.Location = new System.Drawing.Point(15, 297);
            this._chartScore.Name = "_chartScore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this._chartScore.Series.Add(series1);
            this._chartScore.Size = new System.Drawing.Size(488, 272);
            this._chartScore.TabIndex = 8;
            this._chartScore.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 581);
            this.Controls.Add(this._chartScore);
            this.Controls.Add(this._checkBoxGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonStart);
            this.Controls.Add(this._textBoxGameNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "お前はもう死んでいる　新小田主任";
            ((System.ComponentModel.ISupportInitialize)(this._chartScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxGameNum;
        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox _checkBoxGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartScore;
    }
}

