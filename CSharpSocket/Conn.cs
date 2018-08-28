using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace CSharpSocket
{
    public class Conn
    {
        public const int BUFFER_SIZE = 1024;
        // Socket
        public Socket socket;
        // 是否使用
        public bool isUse = false;
        // 缓冲区
        public byte[] readBuff;
        public int buffCount = 0;

        public Conn()
        {
            readBuff = new byte[BUFFER_SIZE];
        }

        // 初始化Socket
        public void Init(Socket socket)
        {
            this.socket = socket;
            isUse = true;
            buffCount = 0;
        }

        // 获取缓冲区剩余的字节数
        public int BuffRemain()
        {
            return BUFFER_SIZE - buffCount;
        }

        // 获取客户端地址
        public string GetAdress()
        {
            if (!isUse) return "无法获取地址";
            return socket.RemoteEndPoint.ToString();
        }

        // 关闭
        public void Close()
        {
            if (!isUse) return;
            Console.WriteLine("[断开连接]" + GetAdress());
            socket.Close();
            isUse = false;
        }

    }
}
