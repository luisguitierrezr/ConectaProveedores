using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceCommentRecord
public class JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac : AbstractRESTStructure<RC_e3f679a5677e9bcd15fc4cdbc37afdac> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("InvoiceComment")]
[JsonPropertyName("InvoiceComment")]
public ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment;

public JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac() { }

public JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac (RC_e3f679a5677e9bcd15fc4cdbc37afdac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoiceComment = ConvertToRestWithoutDefaults(s.ssENInvoiceComment, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceComment = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac, RC_e3f679a5677e9bcd15fc4cdbc37afdac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac s) => ToStructure(s, config);
}
public static RC_e3f679a5677e9bcd15fc4cdbc37afdac ToStructure(ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac obj, IBehaviorsConfiguration config) { 
  RC_e3f679a5677e9bcd15fc4cdbc37afdac s = new RC_e3f679a5677e9bcd15fc4cdbc37afdac();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoiceComment = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment, config);
  }
  return s;
}

public static Func<RC_e3f679a5677e9bcd15fc4cdbc37afdac, ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3f679a5677e9bcd15fc4cdbc37afdac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac FromStructure(RC_e3f679a5677e9bcd15fc4cdbc37afdac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e3f679a5677e9bcd15fc4cdbc37afdac(s, config);
}

}


