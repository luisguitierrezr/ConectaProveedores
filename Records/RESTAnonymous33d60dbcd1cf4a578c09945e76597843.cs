using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceCommentRecord
public class RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac : AbstractRESTStructure<RC_e3f679a5677e9bcd15fc4cdbc37afdac> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("InvoiceComment")]
public ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment;

public RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac() { }

public RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac (RC_e3f679a5677e9bcd15fc4cdbc37afdac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoiceComment = ConvertToRestWithoutDefaults(s.ssENInvoiceComment, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceComment = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment, config);
  }
}

public static RC_e3f679a5677e9bcd15fc4cdbc37afdac ToStructure(ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac obj) { 
  RC_e3f679a5677e9bcd15fc4cdbc37afdac s = new RC_e3f679a5677e9bcd15fc4cdbc37afdac();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoiceComment = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment);
  }
  return s;
}

public static Func<RC_e3f679a5677e9bcd15fc4cdbc37afdac, ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3f679a5677e9bcd15fc4cdbc37afdac s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac FromStructure(RC_e3f679a5677e9bcd15fc4cdbc37afdac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e3f679a5677e9bcd15fc4cdbc37afdac(s, config);
}

}


