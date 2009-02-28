﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tibia.Packets.Incoming
{
    public class ContainerOpenPacket : IncomingPacket
    {

        public ushort ItemId { get; set; }
        public string Name { get; set; }
        public byte id { get; set; }
        public byte Capacity { get; set; }
        public byte HasParent { get; set; }
        public byte ItemCount { get; set; }
        public List<Objects.Item> Items { get; set; }

        public ContainerOpenPacket(Objects.Client c)
            : base(c)
        {
            Type = IncomingPacketType.ContainerOpen;
            Destination = PacketDestination.Client;
        }

        public override bool ParseMessage(NetworkMessage msg, PacketDestination destination)
        {
            int position = msg.Position;

            if (msg.GetByte() != (byte)IncomingPacketType.ContainerOpen)
                return false;

            Destination = destination;
            Type = IncomingPacketType.ContainerOpen;

            try
            {
                id = msg.GetByte();
                ItemId = msg.GetUInt16();
                Name = msg.GetString();
                Capacity = msg.GetByte();
                HasParent = msg.GetByte();
                ItemCount = msg.GetByte();

                Items = new List<Tibia.Objects.Item>(ItemCount);

                for (int i = 0; i < ItemCount; i++)
                {
                    Objects.Item item = new Tibia.Objects.Item(Client, msg.GetUInt16(), 0);

                    if (item.HasExtraByte)
                        item.Count = msg.GetByte();

                    item.Loc = Tibia.Objects.ItemLocation.FromContainer(id, (byte)i);
                    Items.Add(item);
                }
            }
            catch (Exception)
            {
                msg.Position = position;
                return false;
            }

            return true;
        }

        public override byte[] ToByteArray()
        {
            NetworkMessage msg = new NetworkMessage(Client, 0);

            msg.AddByte((byte)Type);

            msg.AddByte(id);
            msg.AddUInt16(ItemId);
            msg.AddString(Name);
            msg.AddByte(Capacity);
            msg.AddByte(HasParent);
            msg.AddByte((byte)Items.Count);


            foreach (Objects.Item i in Items)
            {
                msg.AddUInt16((ushort)i.Id);

                if (i.HasExtraByte)
                    msg.AddByte(i.Count);
            }

            return msg.Packet;
        }

        public static bool Send(Objects.Client client, byte id, ushort itemId, string name, byte capacity, byte hasParent, List<Objects.Item> items)
        {
            ContainerOpenPacket p = new ContainerOpenPacket(client);

            p.id = id;
            p.ItemId = itemId;
            p.Name = name;
            p.Capacity = capacity;
            p.HasParent = hasParent;
            p.Items = items;

            return p.Send();
        }
    }
}