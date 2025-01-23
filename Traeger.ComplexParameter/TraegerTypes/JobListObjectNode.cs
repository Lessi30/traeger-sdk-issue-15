using Opc.Ua;
using Opc.UaFx;

namespace Traeger.ComplexParameter.TraegerTypes
{
    internal sealed class JobListObjectNode : OpcObjectNode
    {
        public OpcMethodNode AddJobNode { get; }

        #region ---------- Public constructors ----------
        
        public JobListObjectNode(IOpcNode parent, OpcName name, OpcNodeId id, OpcContext context)
            : base(parent, name, id)
        {
            AddJobNode = new OpcMethodNode(
                parent: this,
                name: "AddJob",
                id: "ns=2;i=7013",
                callback: new Func<NewJobData, uint>(AddJob));

            this.AddChild(context, AddJobNode);
        }

        #endregion

        #region ---------- Protected properties ----------

        protected override OpcNodeId DefaultTypeDefinitionId
        {
            get => "ns=2;i=1022";
        }

        protected override OpcNodeId DefaultReferenceTypeId
        {
            get => ReferenceTypeIds.HasTypeDefinition;
        }

        #endregion

        #region ---------- Private methods ----------

        private uint AddJob(NewJobData job)
        {
            return 0;
        }
        private (uint Status, List<JobEntryData> Jobs) ListJobs()
        {
            return (0, new List<JobEntryData>());
        }

        #endregion
    }
}
