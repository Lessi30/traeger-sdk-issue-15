﻿using Opc.UaFx;
using Opc.UaFx.Server;
using Traeger.ComplexParameter.TraegerTypes;
namespace Traeger.ComplexParameter
{
    public class ArtemisNodeManager() : OpcNodeManager("http://artemis.com/Artemis/")
    {
        protected override IEnumerable<OpcNodeSet> ImportNodes()
        {
            this.NodeSetImportOptions = OpcNodeSetImportOptions.CompleteDataTypeDefinitionFields | OpcNodeSetImportOptions.CompleteDataTypeDefinitionDefaultEncoding;

            return[];
        }
        protected override IEnumerable<IOpcNode> CreateNodes(OpcNodeReferenceCollection references)
        {
            base.CreateNodes(references);
            
            yield return new OpcDataTypeNode<JobEntryData>();
            yield return new OpcDataTypeNode<NewJobData>();

            var methods = new OpcFolderNode(this.DefaultNamespace.GetName("Instance"));

            var instance = new JobListObjectNode(methods, "MyJobListInstance", "ns=2;s=JobListInstance", SystemContext);

            references.Add(methods, OpcObjectTypes.ObjectsFolder);

            yield return instance;
            yield return methods;
        }
    }
}
