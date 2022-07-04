using System;
using System.Collections.Generic;
using System.Text;

namespace XiuxianGame.人物
{
    internal class Player
    {
        //基本属性
        String name;
        String sex;
        int age;
        int maxAge;
        int meiLi;

        //修行
        int DJingJie;
        int XJingJie;

        //天赋  TODO
        String[] tianfu;

        //战斗属性
        int gongJili;
        int fangYuli;
        float baoJilv;
        float baoJiShangHai;

        //五行属性 TODO
        int jin;
        int mu;
        int shui;
        int huo;
        int tu;
    }
}
