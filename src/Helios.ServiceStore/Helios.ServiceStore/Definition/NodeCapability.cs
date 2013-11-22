﻿namespace Helios.ServiceStore.Definition
{
    /// <summary>
    /// Describes some of the capabilities of the node
    /// </summary>
    public class NodeCapability
    {
        /// <summary>
        /// The port number of this node's capability
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// The name of this capability. I.E. "Thrift", "RDP", "SSH", "FTP", etc...
        /// </summary>
        public string Capability { get; set; }

        public static NodeCapability Create(int portNum, string capabilityName)
        {
            return new NodeCapability() {Capability = capabilityName, Port = portNum};
        }
    }
}