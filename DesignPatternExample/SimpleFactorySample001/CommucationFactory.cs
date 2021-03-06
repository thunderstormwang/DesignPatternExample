﻿using System;

namespace SimpleFactorySample001
{
    public enum CommucationType
    {
        Tcp,
        SerialPort
    }

    /// <summary>
    /// 使用簡單分支運算
    /// </summary>
    public class CommucationFactory
    {
        public static ICommunication GetInstance(CommucationType type)
        {
            switch (type)
            {
                case CommucationType.Tcp:
                    return new TcpCommunication();

                case CommucationType.SerialPort:
                    return new SerialCommunication();

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}