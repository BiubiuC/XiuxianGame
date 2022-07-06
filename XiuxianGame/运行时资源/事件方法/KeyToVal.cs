using System;
using System.Collections.Generic;
using System.Text;

namespace XiuxianGame.运行时资源.事件方法
{
    public class KeyToVal
    {
        public static string JingJie(int i,int j)
        {
            string big = "";
            string sml = "";
            switch (i)
            {
                case 0: big = "凡人"; break;
                case 1: big = "练气"; break;
                case 2: big = "筑基"; break;
                case 3: big = "金丹"; break;
                case 4: big = "元婴"; break;
                //case 5: big = "凡人"; break;
            }
            switch(j)
            {
                case 0: sml = "初期"; break;
                case 1: sml = "中期"; break;
                case 2: sml = "后期"; break;
            }

            return big + sml;
        }
        public static int UpExpCalc(int i,int j)
        {
            int big = 0;
            int sml = 0;
            switch (i)
            {
                /*case 0: big = "凡人"; break;
                case 1: big = "练气"; break;
                case 2: big = "筑基"; break;
                case 3: big = "金丹"; break;
                case 4: big = "元婴"; break;*/
                case 0: big = 300; break;
                case 1: big = 3000; break;
                case 2: big = 30000; break;
                case 3: big = 300000; break;
                case 4: big = 3000000; break;
                    //case 5: big = "凡人"; break;
            }
            switch (j)
            {
                case 0: sml = big / 3; break;
                case 1: sml = big / 3; break;
                case 2: sml = big / 3; break;
            }

            return big + sml;
        }
    }
}
