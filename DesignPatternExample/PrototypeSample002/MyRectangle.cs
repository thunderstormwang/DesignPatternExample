using System;

namespace ProtytypeSample002
{
    // 用 C# 定義好的介面, 和使用預設的 MemberwiseClone 函式

    public class MyRectangle : ICloneable
    {
        public int Height { get; set; }

        public int Width { get; set; }

        /// <summary>
        /// 這只是為了證明 MemberwiseClone 不會呼叫建構式
        /// </summary>
        public MyRectangle()
        {
            Console.WriteLine("呼叫建構式");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}