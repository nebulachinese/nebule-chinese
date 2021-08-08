﻿using System;

namespace NebulaModel.Networking
{
    public struct DelayedPacket
    {
        public PendingPacket Packet { get; }
        public DateTime DueTime { get; }

        public DelayedPacket(PendingPacket packet, DateTime dueTime)
        {
            this.Packet = packet;
            this.DueTime = dueTime;
        }
    }
}
