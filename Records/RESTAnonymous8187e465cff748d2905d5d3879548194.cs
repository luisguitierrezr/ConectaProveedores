using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceCommentRecord
public class RESTRC_85ff0b93155717e6346b97d39d3b0222 : AbstractRESTStructure<RC_85ff0b93155717e6346b97d39d3b0222> {
[JsonProperty("InvoiceComment")]
public ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment;

public RESTRC_85ff0b93155717e6346b97d39d3b0222() { }

public RESTRC_85ff0b93155717e6346b97d39d3b0222 (RC_85ff0b93155717e6346b97d39d3b0222 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceComment = ConvertToRestWithoutDefaults(s.ssENInvoiceComment, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
  } else {
AttrInvoiceComment = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment, config);
  }
}

public static RC_85ff0b93155717e6346b97d39d3b0222 ToStructure(ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222 obj) { 
  RC_85ff0b93155717e6346b97d39d3b0222 s = new RC_85ff0b93155717e6346b97d39d3b0222();
  if(obj != null) {
  s.ssENInvoiceComment = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment);
  }
  return s;
}

public static Func<RC_85ff0b93155717e6346b97d39d3b0222, ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85ff0b93155717e6346b97d39d3b0222 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222 FromStructure(RC_85ff0b93155717e6346b97d39d3b0222 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222(s, config);
}

}


