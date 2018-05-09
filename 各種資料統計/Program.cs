using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 各種資料統計
{
    class Program
    {
        static void Main(string[] args)
        {
            // 輸入全班基本資料
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 0, 168, 173, 0, 0, 0, 0, 0 };
            string[] name = { "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋 遊戲虛寶序號免費送ヾ(◎´・ω・｀)ノ", "周詮", "王湘婷", "蕭宇成", "張家銘", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新小嗨星", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "徐偉哲 錯誤代碼CB48", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮", "施 續保", "世新黃紀瑜", "世新蕭宇成", "世新鍾維辰", "彭子軒" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "男", "女", "男", "男", "男", "男", "男", "男" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "", "射手", "金牛", "處女", "", "", "天秤", "" };
            string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "", "A", "O", "AB", "", "", "O", "" };

            // 宣告男女人數  
            double boy = 0;
            double girl = 0;

            // 從陣列中算出男女實際人數
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "男")
                {
                    boy++;
                }
                if (gender[i] == "女")
                {
                    girl++;
                }
            }

            // 宣告班級人數
            double classgender = gender.Length;

            //計算男女比例
            double boyRate = (boy / classgender) * 100;
            double girlRate = (girl / classgender) * 100;

            // 宣告血型
            double bloodA = 0;
            double bloodB = 0;
            double bloodO = 0;
            double bloodAB = 0;

            // 計算各血型人數
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "A")
                {
                    bloodA++;
                }
                else if (bloodtype[i] == "B")
                {
                    bloodB++;
                }
                else if (bloodtype[i] == "O")
                {
                    bloodO++;
                }
                else if (bloodtype[i] == "AB")
                {
                    bloodAB++;
                }
            }

            // 宣告男生人數及男生全體身高總合
            double boyCount = 0;
            double boyTotalHeight = 0;

            // 排除數值異常的男生再顯示出最高男生身高
            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "男")
                {
                    if (height[i] < 200 && height[i] > 140)
                    {
                        boyTotalHeight += height[i];
                        boyCount += 1;
                    }

                }
            }

            // 宣告女生人數及女生全體身高總合
            double girlCount = 0;
            double girlTotalHeight = 0;

            // 排除數值異常的女生再顯示出最高女生身高
            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "女")
                {
                    if (height[i] < 200 && height[i] > 140)
                    {
                        girlTotalHeight += height[i];
                        girlCount += 1;
                    }

                }
            }

            // 宣告血型總數
            double bloodtypeTotal = bloodtype.Length;

            // 宣告血型比例並計算
            double chanceA = (bloodA / bloodtypeTotal) * 100;
            double chanceB = (bloodB / bloodtypeTotal) * 100;
            double chanceO = (bloodO / bloodtypeTotal) * 100;
            double chanceAB = (bloodAB / bloodtypeTotal) * 100;

            // 宣告天蠍座同學姓名            
            string nameScorpio = " ";

            // 列出符合條件的人數和名字
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "O")
                {
                    if (zodiac[i] == "天蠍")
                    {
                        nameScorpio += name[i] + " ";
                    }
                }
            }

            // 宣告最高的人和最矮的人
            double Highest = 0;
            double Shortest = 999;

            // 選出班上最高和最矮的身高
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    if (height[i] > Highest)
                    {
                        Highest = height[i];
                    }

                    if (height[i] < Shortest)
                    {
                        Shortest = height[i];
                    }
                }
            }

            // 顯示結果
            Console.WriteLine("男生人數: " + boyCount);
            Console.WriteLine("百分比: " + boyRate + "%");

            Console.WriteLine("女生人數: " + girlCount);
            Console.WriteLine("百分比: " + girlRate + "%");

            Console.WriteLine("A型人數:" + bloodA);
            Console.WriteLine("百分比:" + chanceA + "%");

            Console.WriteLine("B型人數: " + bloodB);
            Console.WriteLine("百分比: " + chanceB + "%");

            Console.WriteLine("O型人數: " + bloodO);
            Console.WriteLine("百分比: " + chanceO + "%");

            Console.WriteLine("AB型人數: " + bloodAB);
            Console.WriteLine("百分比: " + chanceAB + "%");

            Console.WriteLine("是天蠍座且為O型的人: " + nameScorpio);

            Console.WriteLine("男生身高平均: " + boyTotalHeight / boyCount);
            Console.WriteLine("女生身高平均: " + girlTotalHeight / girlCount);
            Console.WriteLine("全部身高平均: " + (boyTotalHeight + girlTotalHeight) / (boyCount + girlCount));

            Console.WriteLine("身高最矮是: " + Shortest);
            Console.WriteLine("身高最高是: " + Highest);

            // 停止畫面
            Console.ReadLine();
        }
    }
}
