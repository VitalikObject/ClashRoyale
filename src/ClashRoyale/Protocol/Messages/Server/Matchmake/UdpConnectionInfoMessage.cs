﻿using ClashRoyale.Logic;
using ClashRoyale.Utilities.Netty;

namespace ClashRoyale.Protocol.Messages.Server
{
    public class UdpConnectionInfoMessage : PiranhaMessage
    {
        public UdpConnectionInfoMessage(Device device) : base(device)
        {
            Id = 24112;
        }

        public int ServerPort { get; set; }
        public string ServerHost { get; set; }
        public byte[] SessionId { get; set; }
        public string Nonce { get; set; }

        public override void Encode()
        {
            Writer.WriteVInt(ServerPort);
            Writer.WriteScString(ServerHost);
            Writer.WriteBytes(SessionId);
            Writer.WriteScString(Nonce);
        }
    }
}