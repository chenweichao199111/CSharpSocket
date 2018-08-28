using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using UnityEngine.UI;

public class net : MonoBehaviour
{
    //与服务端的套接字
    Socket socket;
    //服务端的IP和端口
    public InputField hostInput;
    public InputField portInput;
    //文本框
    public Text recvText;
    public Text clientText;
    //接收缓冲区
    const int BUFFER_SIZE = 1024;
    byte[] readBuff = new byte[BUFFER_SIZE];

    public void Connetion()
    {
        //Socket
        socket = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream, ProtocolType.Tcp);
        //Connect
        string host = hostInput.text;
        int port = int.Parse(portInput.text);
        socket.Connect(host, port);
        clientText.text = "客户端地址 " + socket.LocalEndPoint.ToString();
        //Send
        string str = "Hello Unity!";
        byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
        socket.Send(bytes);
        //Recv
        int count = socket.Receive(readBuff);
        str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);
        recvText.text = str;
        //Close
        socket.Close();
    }
}