﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace PADI_FS
{
    class MetadataServer
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8087);
            ChannelServices.RegisterChannel(channel, true);
            MyRemoteObject mo = new MyRemoteObject();
            RemotingServices.Marshal(mo,
                "MyRemoteObjectName",
                typeof(MyRemoteObject));
            System.Console.WriteLine("<enter> para sair do Metadata Server...");
            System.Console.ReadLine();
        }
    }

    public class MyRemoteObject : MarshalByRefObject
    {
        public string MetodoOla()
        {
            return "ola!";
        }
    }

   

    
}
