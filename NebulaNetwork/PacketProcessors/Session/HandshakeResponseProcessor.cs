using NebulaModel.Attributes;
using NebulaModel.Networking;
using NebulaModel.Packets;
using NebulaModel.Packets.Session;
using NebulaWorld;

namespace NebulaNetwork.PacketProcessors.Session
{
    [RegisterPacketProcessor]
    public class HandshakeResponseProcessor : PacketProcessor<HandshakeResponse>
    {
        public override void ProcessPacket(HandshakeResponse packet, NebulaConnection conn)
        {
            if (LocalPlayer.GS2_GSSettings != null && packet.CompressedGS2Settings.Length > 1) // if host does not use GS2 we send a null byte
            {
                LocalPlayer.GS2ApplySettings(packet.CompressedGS2Settings);
            }
            else if (LocalPlayer.GS2_GSSettings != null && packet.CompressedGS2Settings.Length == 1)
            {
                InGamePopup.ShowWarning("Nebula中文版", "服务器似乎没有使用银河规模。确保您的mod配置匹配。", "返回");
                return;
            }

            GameDesc gameDesc = new GameDesc();
            gameDesc.SetForNewGame(packet.AlgoVersion, packet.GalaxySeed, packet.StarCount, 1, packet.ResourceMultiplier);
            DSPGame.StartGameSkipPrologue(gameDesc);

            LocalPlayer.IsMasterClient = false;
            LocalPlayer.SetPlayerData(packet.LocalPlayerData);

            InGamePopup.ShowInfo("Nebula中文版", "正在加入到游戏中...", null);
        }
    }
}
