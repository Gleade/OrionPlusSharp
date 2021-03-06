
using System.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualBasic;


using ASFW.Network;
using System.Windows.Forms;
using Engine;


namespace Engine
{
    internal sealed class C_NetworkConfig
    {
        internal static ASFW.Network.Client Socket;

        internal static void InitNetwork()
        {
            if (!ReferenceEquals(Socket, null))
            {
                return;
            }
            Socket = new ASFW.Network.Client((System.Int32)Packets.ServerPackets.COUNT);
            C_NetworkReceive.PacketRouter();
        }

        internal static void Connect()
        {
            Socket.Connect(C_Types.Options.Ip, C_Types.Options.Port);
        }

        internal static void DestroyNetwork()
        {
            // Calling a disconnect is not necessary when using destroy network as
            // Dispose already calls it and cleans up the memory internally.
            Socket.Dispose();
        }

        #region  Events

        private static void Socket_ConnectionSuccess()
        {

        }

        private static void Socket_ConnectionFailed()
        {

        }

        private static void Socket_ConnectionLost()
        {
            MessageBox.Show("Connection was terminated!");
            DestroyNetwork();
            C_General.DestroyGame();
        }

        private static void Socket_CrashReport(string err)
        {
            MessageBox.Show("There was a network error -> Report: " + err);
            DestroyNetwork();
            C_General.DestroyGame();
        }
        #endregion
    }
}
