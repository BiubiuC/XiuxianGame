using System;
using System.Collections.Generic;
using System.Text;
using XiuxianGame.DBOper;

namespace XiuxianGame.人物
{
    public class Player
    {
        //基本属性
        int id;
        string name;
        string sex;
        int age;
        int maxage;
        int meili;
        int djingjie;
        int xjingjie;
        int jingyan;
        int hp;
        int maxhp;
        int mp;
        int maxmp;
        int tp;
        int maxtp;
        int actnum;
        int defnum;
        double baolinum;
        double baojiact;
        int jin;
        int mu;
        int shui;
        int huo;
        int tu;


        //背包
        int beibaodaxiao;
        int[] wupins;

        //DB操作
        static PlayerOper dbp = new PlayerOper();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public int Maxage { get => maxage; set => maxage = value; }
        public int Meili { get => meili; set => meili = value; }
        public int Djingjie { get => djingjie; set => djingjie = value; }
        public int Xjingjie { get => xjingjie; set => xjingjie = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Maxhp { get => maxhp; set => maxhp = value; }
        public int Mp { get => mp; set => mp = value; }
        public int Maxmp { get => maxmp; set => maxmp = value; }
        public int Tp { get => tp; set => tp = value; }
        public int Maxtp { get => maxtp; set => maxtp = value; }
        public int Actnum { get => actnum; set => actnum = value; }
        public int Defnum { get => defnum; set => defnum = value; }
        public double Baolinum { get => baolinum; set => baolinum = value; }
        public double Baojiact { get => baojiact; set => baojiact = value; }
        public int Jin { get => jin; set => jin = value; }
        public int Mu { get => mu; set => mu = value; }
        public int Shui { get => shui; set => shui = value; }
        public int Huo { get => huo; set => huo = value; }
        public int Tu { get => tu; set => tu = value; }
        public int Jingyan { get => jingyan; set => jingyan = value; }

        //测试用load
        public static Player load()
        {

            /*//TODO:
            *//* 先瞎几把弄点数据 begin *//*
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
            *//* 先瞎几把弄点数据 end */
            return dbp.getPlayer(1);
        }


    }
}
