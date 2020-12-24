using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;

namespace BadLuck
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _chartScore.Series.Clear();
        }

        /// <summary>
        /// [開始]ボタンイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void _buttonStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(_textBoxGameNum.Text, out var gameNum))
            {
                MessageBox.Show("対局回数が不正です。","エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;
            var sim = new SimpleMahjongSim(gameNum);
            await Task.Run(() => sim.Run());
            Console.WriteLine("シミュレーション終了。");
            SetResultReport(sim);
            Application.DoEvents();
            Console.WriteLine("レポート表示終了。");

            if (_checkBoxGraph.Checked)
            {
                SetScoreRecordGraph(sim.ScoreRecord);
                Console.WriteLine("チャート表示終了。");
            }
            Cursor = Cursors.Default;
        }

        private void SetResultReport(SimpleMahjongSim sim)
        {
            var result = $"半荘回数：{sim.GameNum}" + Environment.NewLine;
            result += $"1着(+50pt)：{sim.NumOf1st}回 ({Math.Round((sim.NumOf1st / (double)sim.GameNum) * 100.0, 1, MidpointRounding.AwayFromZero)}%)" + Environment.NewLine;
            result += $"2着(+10pt)：{sim.NumOf2nd}回 ({Math.Round((sim.NumOf2nd / (double)sim.GameNum) * 100.0, 1, MidpointRounding.AwayFromZero)}%)" + Environment.NewLine;
            result += $"3着(-20pt)：{sim.NumOf3rd}回 ({Math.Round((sim.NumOf3rd / (double)sim.GameNum) * 100.0, 1, MidpointRounding.AwayFromZero)}%)" + Environment.NewLine;
            result += $"4着(-40pt)：{sim.NumOf4th}回 ({Math.Round((sim.NumOf4th / (double)sim.GameNum) * 100.0, 1, MidpointRounding.AwayFromZero)}%)" + Environment.NewLine;
            result += Environment.NewLine;
            result += $"最終スコア：{sim.Score}" + Environment.NewLine;
            result += $"最大スコア：{sim.MaxScore}" + Environment.NewLine;
            result += $"最小スコア：{sim.MinScore}" + Environment.NewLine;
            result += Environment.NewLine;
            result += $"連続1着記録：{sim.NumofMaxStraight1st}半荘" + Environment.NewLine;
            result += $"連続4着記録：{sim.NumofMaxStraight4th}半荘" + Environment.NewLine;
            _textBoxResult.Text = result;
        }

        private void SetScoreRecordGraph(List<int> score)
        {
            _chartScore.Series.Clear();
            _chartScore.ChartAreas.Clear();
            _chartScore.ChartAreas.Add(new ChartArea("aria"));
            _chartScore.ChartAreas[0].AxisX.Minimum = 0;
            _chartScore.ChartAreas[0].AxisX.Maximum = score.Count - 1;

            string legend1 = "スコア";
            _chartScore.Series.Add(legend1);
            _chartScore.Series[legend1].ChartType = SeriesChartType.Line;

            double x = 0;
            foreach (var val in score)
            {
                _chartScore.Series[legend1].Points.AddXY(x, val);
                x++;
            }
        }
    }
}
