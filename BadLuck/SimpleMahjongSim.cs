using System;
using System.Collections.Generic;

namespace BadLuck
{
    /// <summary>
    /// シンプル麻雀シミュレータ
    /// </summary>
    public class SimpleMahjongSim
    {
        /// <summary>
        /// 対局回数
        /// </summary>
        public int GameNum { get; private set; }

        /// <summary>
        /// トータルスコア
        /// </summary>
        public int Score { get; private set; }

        /// <summary>
        /// 最大スコア
        /// </summary>
        public int MaxScore { get; private set; }

        /// <summary>
        /// 最小スコア
        /// </summary>
        public int MinScore { get; private set; }

        /// <summary>
        /// 1着回数
        /// </summary>
        public uint NumOf1st { get; private set; }

        /// <summary>
        /// 2着回数
        /// </summary>
        public uint NumOf2nd { get; private set; }

        /// <summary>
        /// 3着回数
        /// </summary>
        public uint NumOf3rd { get; private set; }

        /// <summary>
        /// 4着回数
        /// </summary>
        public uint NumOf4th { get; private set; }

        /// <summary>
        /// 連続1位記録
        /// </summary>
        public uint NumofMaxStraight1st { get; private set; }

        /// <summary>
        /// 連続ラス記録
        /// </summary>
        public uint NumofMaxStraight4th { get; private set; }

        /// <summary>
        /// スコア時系列リスト
        /// </summary>
        public List<int> ScoreRecord { get; private set; }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="gameNum"></param>
        public SimpleMahjongSim(int gameNum)
        {
            GameNum = gameNum;
            Score = 0;
            NumOf1st = 0;
            NumOf2nd = 0;
            NumOf3rd = 0;
            NumOf4th = 0;
            MaxScore = 0;
            MinScore = 0;
            NumofMaxStraight1st = 0;
            NumofMaxStraight4th = 0;
            ScoreRecord = new List<int>();
            ScoreRecord.Add(0);
        }

        public void Run()
        {
            var rand = new Random();
            uint straight1st = 0; //連続トップ回数
            uint straight4th = 0; //連続ラス回数

            for (var j = 0; j < GameNum; j++)
            {
                var randVal = rand.Next(0, 4);
                if (randVal == 0)
                {
                    //1着
                    Score += 50;
                    NumOf1st += 1;
                    straight4th = 0;
                    straight1st += 1;
                    if (straight1st > NumofMaxStraight1st) NumofMaxStraight1st = straight1st;
                }
                else if (randVal == 1)
                {
                    //2着
                    Score += 10;
                    NumOf2nd += 1;
                    straight1st = 0;
                    straight4th = 0;
                }
                else if (randVal == 2)
                {
                    //3着
                    Score -= 20;
                    NumOf3rd += 1;
                    straight1st = 0;
                    straight4th = 0;
                }
                else if (randVal == 3)
                {
                    //4着
                    Score -= 40;
                    NumOf4th += 1;
                    straight1st = 0;
                    straight4th += 1;
                    if (straight4th > NumofMaxStraight4th) NumofMaxStraight4th = straight4th;
                }

                //最大スコア更新
                if (Score > MaxScore) MaxScore = Score;

                //最小スコア更新
                if (Score < MinScore) MinScore = Score;

                //時系列リストにスコア追加
                ScoreRecord.Add(Score);
            }
        }
    }
}
