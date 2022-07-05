using System;
using System.Collections.Generic;
using System.Text;

namespace XiuxianGame.人物
{
    internal class Player
    {
        //基本属性
        string name; //姓名
        string sex; //性别
        int age;    //年龄
        int maxAge; //寿命
        int meiLi;  //魅力

        //修行
        int DJingJie;   //大境界
        int XJingJie;   //小境界

        //天赋  TODO
        string[] tianfu;    //天赋

        //战斗属性
        int hp; //生命
        int maxhp;  //最大生命
        int mp; //灵力
        int maxmp;  //最大灵力
        int nl; //念力
        int maxln;  //最大念力
        int gongJili;   //攻击力
        int fangYuli;   //防御力
        float baoJilv;  //暴击率
        float baoJiShangHai;    //暴击伤害

        //五行属性 TODO
        int jin;    //金
        int mu;     //木
        int shui;   //水
        int huo;    //火
        int tu;     //土
    }
}
