using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceCommentRecord
public class JSONRC_85ff0b93155717e6346b97d39d3b0222 : AbstractRESTStructure<RC_85ff0b93155717e6346b97d39d3b0222> {
[JsonProperty("InvoiceComment")]
[JsonPropertyName("InvoiceComment")]
public ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment;

public JSONRC_85ff0b93155717e6346b97d39d3b0222() { }

public JSONRC_85ff0b93155717e6346b97d39d3b0222 (RC_85ff0b93155717e6346b97d39d3b0222 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceComment = ConvertToRestWithoutDefaults(s.ssENInvoiceComment, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
  } else {
AttrInvoiceComment = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222, RC_85ff0b93155717e6346b97d39d3b0222> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222 s) => ToStructure(s, config);
}
public static RC_85ff0b93155717e6346b97d39d3b0222 ToStructure(ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222 obj, IBehaviorsConfiguration config) { 
  RC_85ff0b93155717e6346b97d39d3b0222 s = new RC_85ff0b93155717e6346b97d39d3b0222();
  if(obj != null) {
  s.ssENInvoiceComment = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment, config);
  }
  return s;
}

public static Func<RC_85ff0b93155717e6346b97d39d3b0222, ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85ff0b93155717e6346b97d39d3b0222 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222 FromStructure(RC_85ff0b93155717e6346b97d39d3b0222 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_85ff0b93155717e6346b97d39d3b0222(s, config);
}

}


