﻿using NebulaModel.Attributes;
using NebulaModel.Networking.Serialization;

namespace NebulaModel.DataStructures
{
    [RegisterNestedType]
    public struct Double3 : INetSerializable
    {
        public double x;
        public double y;
        public double z;

        public Double3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Serialize(NetDataWriter writer)
        {
            writer.Put(x);
            writer.Put(y);
            writer.Put(z);
        }

        public void Deserialize(NetDataReader reader)
        {
            x = reader.GetDouble();
            y = reader.GetDouble();
            z = reader.GetDouble();
        }


        public override string ToString()
        {
            return $"x: {x}, y: {y}, z: {z}";
        }
    }
}
