using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json;
using KiteTools.ECharts.Model;

namespace KiteTools.ECharts
{
    public static class OptionBuilder
    {
        /// <summary>
        /// 获得双Y轴折线图
        /// </summary>
        /// <returns></returns>
        public static string GenerateDoubleYLineChart(
            string title,List<string> legendData, string gridTopValue,
            List<string> xAxisData,int interval,
            List<Line> seriesData, bool incline = true)
        {
            var series = new List<object>();
            foreach (var z in seriesData)
            {
                series.Add(z);
            }
            var json = new
            {
                Title = new
                {
                    left = "center",
                    text = title,
                },
                animation = false,
                Tooltip = new { Trigger = "axis" },
                Legend = new
                {
                    top = "5%",
                    data = legendData,
                    icon = "rect",
                    itemHeight = 1
                },
                grid = new
                {
                    Top = gridTopValue,
                    Left = "5%",
                    right = "4%",
                    bottom = "3%",
                    containLabel = true
                },
                xAxis = new
                {
                    Type = "category",
                    // Type = "time",
                    boundaryGap = false,
                    AxisLabel = new
                    {
                        interval = interval,
                        showMaxLabel = true,
                        rotate = 60
                    },
                    Data = xAxisData
                },
                yAxis = new List<object>()
                {
                    new {
                        Type = "value",
                        // Name = "单位：℃"
                        AxisLabel = new
                        {
                            Formatter = "{value}℃"
                        },
                    },
                    new {
                        Type = "value",
                        // Name = "单位：%"
                        AxisLabel = new
                        {
                            Formatter = "{value}%"
                        },
                    }
                    
                },
                Series = series,

                Color = new List<string>()
                {
                    "#FFCC00",
                    "#6495ED",
                    "#006633",
                    "#00CC66",
                    "#330099",
                    "#3366CC",
                    "#33CCFF",
                    "#663300",
                    "#669933",
                    "#66FF66",
                    "#993399",
                    "#9999CC",
                    "#99FFFF",
                    "#CC6600",
                    "#CCFF33",
                    "#FF3366",
                    "#FF9999",
                    // "#FFFFCC",
                    "#FF33FF",
                    "#CCFFCC",
                    "#009999",
                    "#FF9966",
                    "#CC9999",
                    "#FF66CC",
                    "#0033FF",
                    "#003300",
                    "#FFCC66",
                    "#003399"
                }
            };

            // 序列化选项
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            };
            // 序列化
            string optionString = JsonSerializer.Serialize(json, serializeOptions);
            return optionString;
        }
    }
}