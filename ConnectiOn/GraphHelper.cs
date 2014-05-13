using System.Collections.Generic;
using System.Linq;
using IcsManagerLibrary;

namespace ConnectiOn
{
    class GraphHelper
    {
        public int GraphPointCount = 300;
        public object Synchro = new object();
        private Dictionary<string, long> _graphLastBytesReceived = new Dictionary<string, long>();
        private Dictionary<string, long> _graphLastBytesSent = new Dictionary<string, long>();
        public Dictionary<string, List<long>> GraphBytesReceived = new Dictionary<string, List<long>>();
        public Dictionary<string, List<long>> GraphBytesSent = new Dictionary<string, List<long>>();

        public void Reset()
        {
            lock (Synchro)
            {
                GraphBytesReceived.Clear();
                GraphBytesSent.Clear();
                _graphLastBytesReceived.Clear();
                _graphLastBytesSent.Clear();
                foreach (var nic in IcsManager.GetIPv4EthernetAndWirelessInterfaces())
                {
                    GraphBytesReceived.Add(nic.Id, new List<long>());
                    GraphBytesSent.Add(nic.Id, new List<long>());
                    _graphLastBytesReceived.Add(nic.Id, nic.GetIPv4Statistics().BytesReceived);
                    _graphLastBytesSent.Add(nic.Id, nic.GetIPv4Statistics().BytesSent);
                    for (int i = 0; i < GraphPointCount; i++)
                    {
                        GraphBytesReceived[nic.Id].Add(0);
                        GraphBytesSent[nic.Id].Add(0);
                    }
                }
            }
        }

        public void Refresh()
        {
            lock (Synchro)
            {
                foreach (var nic in IcsManager.GetIPv4EthernetAndWirelessInterfaces()
                                              .Where(nic => _graphLastBytesReceived.ContainsKey(nic.Id))
                    )
                {
                    GraphBytesReceived[nic.Id].RemoveAt(0);
                    GraphBytesReceived[nic.Id].Add(nic.GetIPv4Statistics().BytesReceived -
                                                   _graphLastBytesReceived[nic.Id]);
                    _graphLastBytesReceived[nic.Id] = nic.GetIPv4Statistics().BytesReceived;

                    GraphBytesSent[nic.Id].RemoveAt(0);
                    GraphBytesSent[nic.Id].Add(nic.GetIPv4Statistics().BytesSent - _graphLastBytesSent[nic.Id]);
                    _graphLastBytesSent[nic.Id] = nic.GetIPv4Statistics().BytesSent;
                }
            }
        }
    }
}
