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
    }
}
