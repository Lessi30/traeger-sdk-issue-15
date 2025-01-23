using Opc.UaFx;

namespace Traeger.ComplexParameter.TraegerTypes
{
    /// <summary>
    /// Inital data of the job for other method calls.
    /// </summary>
    [OpcDataTypeAttribute("ns=2;i=3028")]
    [OpcDataTypeEncodingAttribute("ns=2;i=5014", Type = Opc.UaFx.OpcEncodingType.Binary, NamespaceUri = "http://artemis.com/Artemis/")]
    [OpcDataTypeEncodingAttribute("ns=2;i=5044", Type = Opc.UaFx.OpcEncodingType.Xml, NamespaceUri = "http://artemis.com/Artemis/")]
    public class JobEntryData
    {
        public string JobIdentifier
        {
            get;
            set;
        }

        public string JobName
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Data for adding a new job.
    /// </summary>
    [OpcDataTypeAttribute("ns=2;i=3029")]
    [OpcDataTypeEncodingAttribute("ns=2;i=5056", Type = Opc.UaFx.OpcEncodingType.Binary, NamespaceUri = "http://artemis.com/Artemis/")]
    [OpcDataTypeEncodingAttribute("ns=2;i=5057", Type = Opc.UaFx.OpcEncodingType.Xml, NamespaceUri = "http://artemis.com/Artemis/")]
    public class NewJobData : JobEntryData
    {
        public string ArticleIdentifier
        {
            get;
            set;
        }

        public uint JobQuantity
        {
            get;
            set;
        }

        public uint BatchQuantity
        {
            get;
            set;
        }
    }
}
