﻿namespace Lib_K_Relay.Networking.Packets.Server
{
    public class VerifyEmailPacket : Packet
    {
        public override PacketType Type
        { get { return PacketType.VERIFYEMAIL; } }

        public override void Read(PacketReader r)
        {
        }

        public override void Write(PacketWriter w)
        {
        }
    }
}
