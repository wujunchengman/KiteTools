using System.Collections.Generic;

namespace KiteTools.ECharts.Model
{
    public class Line
    {
        public string Name { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Symbol为None时每个点没有小圆点
        /// 默认没有小圆点
        /// </summary>
        public string Symbol { get; set; } = "none";

        /// <summary>
        /// 当LineStyle = 1 时线条会变细，但是标准配置不是这么配置的
        /// </summary>
        public int LineStyle { get; set; }

        /// <summary>
        /// 平滑处理
        /// </summary>
        public float Smooth { get; set; } = 0;
        
        /// <summary>
        /// Y轴索引
        /// </summary>
        public int YAxisIndex { get; set; }

        public List<float> Data { get; set; } = new List<float>();
    }
}