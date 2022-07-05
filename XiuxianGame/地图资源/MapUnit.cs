using System;
using System.Collections.Generic;
using System.Text;
using XiuxianGame.物品材料;

namespace XiuxianGame.地图资源
{
    // 修改同步修改地图生成器
    internal class MapUnit
    {
        String[] players;//当前地点玩家
        String name; //地点名称
        int[] postion;//在大地图的位置

        Dictionary<Cailiao,Double> cailiaomap;//材料,基础发现率
    }
}
