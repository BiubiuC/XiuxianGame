using System;
using System.Collections.Generic;
using System.Text;

namespace XiuxianGame.物品材料
{
    internal class Package
    {
        string name;
        int num;
        string descript;
        int wtype;

        public string Name { get => name; set => name = value; }
        public int Num { get => num; set => num = value; }
        public int Wtype { get => wtype; set => wtype = value; }
        public string Descript { get => descript; set => descript = value; }
    }
}
