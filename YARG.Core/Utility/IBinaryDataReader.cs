﻿using System;

namespace YARG.Core.Utility
{
    public interface IBinaryDataReader : IDisposable
    {

        public int Read();
        public int Read(byte[] buffer, int index, int count);
        public int Read(char[] buffer, int index, int count);
        public bool ReadBoolean();
        public byte ReadByte();
        public byte[] ReadBytes(int count);
        public char ReadChar();
        public char[] ReadChars(int count);
        public decimal ReadDecimal();
        public double ReadDouble();
        public short ReadInt16();
        public int ReadInt32();
        public long ReadInt64();
        public sbyte ReadSByte();
        public float ReadSingle();
        public string ReadString();
        public ushort ReadUInt16();
        public uint ReadUInt32();
        public ulong ReadUInt64();

    }
}