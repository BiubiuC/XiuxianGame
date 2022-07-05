using System;
using System.Collections.Generic;
using System.Text;

namespace XiuxianGame.人物
{
    public class Player
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
        double baoJilv;  //暴击率
        double baoJiShangHai;    //暴击伤害

        //五行属性 TODO
        int jin;    //金
        int mu;     //木
        int shui;   //水
        int huo;    //火
        int tu;     //土

        public Player load()
        {
            //TODO:
            /* 先瞎几把弄点数据 begin */
            //基本属性
            name = "张三"; //姓名
            sex = "男"; //性别
            age = 18;    //年龄
            maxAge = 90; //寿命
            meiLi = 30;  //魅力

            //修行
            DJingJie = 2;   //大境界
            XJingJie = 1;   //小境界

            //天赋  TODO
            string[] tianfu;    //天赋

            //战斗属性
            hp = 1000; //生命
            maxhp = 1000;  //最大生命
            mp = 300; //灵力
            maxmp = 300;  //最大灵力
            nl = 100; //念力
            maxln = 100;  //最大念力
            gongJili = 15;   //攻击力
            fangYuli = 10;   //防御力
            baoJilv = 0.03f;  //暴击率
            baoJiShangHai = 1.2f;    //暴击伤害

            //五行属性 TODO
            jin = 5;    //金
            mu = 5;     //木
            shui = 5;   //水
            huo = 5;    //火
            tu = 5;     //土
            /* 先瞎几把弄点数据 end */
            return this;
        }

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public int MaxAge { get => maxAge; set => maxAge = value; }
        public int MeiLi { get => meiLi; set => meiLi = value; }
        public int DJingJie1 { get => DJingJie; set => DJingJie = value; }
        public int XJingJie1 { get => XJingJie; set => XJingJie = value; }
        public string[] Tianfu { get => tianfu; set => tianfu = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Maxhp { get => maxhp; set => maxhp = value; }
        public int Mp { get => mp; set => mp = value; }
        public int Maxmp { get => maxmp; set => maxmp = value; }
        public int Nl { get => nl; set => nl = value; }
        public int Maxln { get => maxln; set => maxln = value; }
        public int GongJili { get => gongJili; set => gongJili = value; }
        public int FangYuli { get => fangYuli; set => fangYuli = value; }
        public double BaoJilv { get => baoJilv; set => baoJilv = value; }
        public double BaoJiShangHai { get => baoJiShangHai; set => baoJiShangHai = value; }
        public int Jin { get => jin; set => jin = value; }
        public int Mu { get => mu; set => mu = value; }
        public int Shui { get => shui; set => shui = value; }
        public int Huo { get => huo; set => huo = value; }
        public int Tu { get => tu; set => tu = value; }
    }
}
