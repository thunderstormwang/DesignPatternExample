using System;
using System.Reflection;

namespace SimpleFactorySample002
{
    public class CommucationAttribute : Attribute
    {
        public CommucationAttribute(Type type)
        {
            InstanceType = type;
        }

        public Type InstanceType
        {
            get; private set;
        }
    }

    public enum CommucationType
    {
        [Commucation(typeof(TcpCommunication))]
        Tcp,

        [Commucation(typeof(SerialCommunication))]
        SerialPort
    }

    /// <summary>
    /// 取得 enum CommucationType 上的 Attribute 中的 InstanceType 屬性值
    /// </summary>
    internal class CommunicationTypeHelper
    {
        internal static Type GetInstanceType(CommucationType type)
        {
            FieldInfo data = typeof(CommucationType).GetField(type.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(CommucationAttribute));
            CommucationAttribute result = (CommucationAttribute)attribute;
            return result.InstanceType;
        }
    }

    /// <summary>
    /// 運用 Attribute
    /// </summary>
    public class CommucationFactory
    {
        public static ICommunication GetInstance(CommucationType type)
        {
            Type t = CommunicationTypeHelper.GetInstanceType(type);
            return (ICommunication)Activator.CreateInstance(t);
        }
    }
}