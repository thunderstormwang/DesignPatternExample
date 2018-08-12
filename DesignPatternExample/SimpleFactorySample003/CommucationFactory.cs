using System;
using System.Collections.Generic;

namespace SimpleFactorySample003
{
    public enum CommucationType
    {
        Tcp,
        SerialPort
    }

    /// <summary>
    /// 運用 資源搜尋法
    /// </summary>
    public class CommucationFactory
    {
        public static ICommunication GetInstance(CommucationType type)
        {
            var t = CommucationResources.GetInstanceType(type);
            return (ICommunication)Activator.CreateInstance(t);
        }
    }

    /// <summary>
    /// 建立資源搜尋器
    /// </summary>
    public class CommucationResources
    {
        private static Dictionary<CommucationType, Type> _resources;

        static CommucationResources()
        {
            _resources = new Dictionary<CommucationType, Type>();
            _resources[CommucationType.Tcp] = typeof(TcpCommunication);
            _resources[CommucationType.SerialPort] = typeof(SerialCommunication);
        }

        public static Type GetInstanceType(CommucationType type)
        {
            if (_resources.ContainsKey(type))
            {
                return _resources[type];
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}