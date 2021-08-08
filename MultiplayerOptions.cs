using NebulaModel.Attributes;
using System;
using System.ComponentModel;

namespace NebulaModel
{
    [System.Serializable]
    public class MultiplayerOptions : ICloneable
    {
        [DisplayName("游戏名称")]
        public string Nickname { get; set; } = string.Empty;

        [DisplayName("机甲颜色 - 红")]
        [UIRange(0, 255, true)]
        public float MechaColorR { get; set; } = 255;

        [DisplayName("机甲颜色 - 绿")]
        [UIRange(0, 255, true)]
        public float MechaColorG { get; set; } = 255;

        [DisplayName("机甲颜色 - 蓝")]
        [UIRange(0, 255, true)]
        public float MechaColorB { get; set; } = 255;

        [DisplayName("房主端口")]
        [UIRange(1, ushort.MaxValue)]
        public ushort HostPort { get; set; } = 6666;


        [DisplayName("记住上个游戏")]
        public bool RememberLastIP { get; set; } = true;

        [DisplayName("汉化说明:")]
       
        public bool aboutwe { get; set; } = true;


        [DisplayName("汉化人员: 智子 and SMYT")]

        public bool aboutwes { get; set; } = true;


        [DisplayName("QQ群：956026091 [0.3.1编译]")]

        public bool aboutwess { get; set; } = true;



        [DisplayName("原nebula地址:https://github.com/hubastard/nebula")]
        public bool aboutenglish { get; set; } = true;

        [DisplayName("nebula中文版地址:https://github.com/nebulachinese/nebule-chinese")]
        public bool aboutchinese { get; set; } = true;

        public string LastIP { get; set; } = string.Empty;

        //汉化说明: 
        // Detail function group buttons
        public bool PowerGridEnabled { get; set; } = false;
        public bool VeinDistributionEnabled { get; set; } = false;
        public bool SpaceNavigationEnabled { get; set; } = true;
        public bool BuildingWarningEnabled { get; set; } = true;
        public bool BuildingIconEnabled { get; set; } = true;
        public bool GuidingLightEnabled { get; set; } = true;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
