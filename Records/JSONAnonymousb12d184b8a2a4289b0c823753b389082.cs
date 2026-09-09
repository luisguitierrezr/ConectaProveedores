using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_6ApprovalRecord
public class JSONRC_e84f9c9bcc5a701ba8257c06770fe241 : AbstractRESTStructure<RC_e84f9c9bcc5a701ba8257c06770fe241> {
[JsonProperty("InvoicesReport48_6Approval")]
[JsonPropertyName("InvoicesReport48_6Approval")]
public ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure AttrInvoicesReport48_6Approval;

public JSONRC_e84f9c9bcc5a701ba8257c06770fe241() { }

public JSONRC_e84f9c9bcc5a701ba8257c06770fe241 (RC_e84f9c9bcc5a701ba8257c06770fe241 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48_6Approval = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48_6Approval, new ST_39962f5b1f9edd4db48277d9dcced378Structure(), ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure.FromStructure, config);
  } else {
AttrInvoicesReport48_6Approval = ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure.FromStructure(s.ssSTInvoicesReport48_6Approval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241, RC_e84f9c9bcc5a701ba8257c06770fe241> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241 s) => ToStructure(s, config);
}
public static RC_e84f9c9bcc5a701ba8257c06770fe241 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241 obj, IBehaviorsConfiguration config) { 
  RC_e84f9c9bcc5a701ba8257c06770fe241 s = new RC_e84f9c9bcc5a701ba8257c06770fe241();
  if(obj != null) {
  s.ssSTInvoicesReport48_6Approval = ssConectaProveedores.RestRecords.JSONST_39962f5b1f9edd4db48277d9dcced378Structure.ToStructure(obj.AttrInvoicesReport48_6Approval, config);
  }
  return s;
}

public static Func<RC_e84f9c9bcc5a701ba8257c06770fe241, ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e84f9c9bcc5a701ba8257c06770fe241 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241 FromStructure(RC_e84f9c9bcc5a701ba8257c06770fe241 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e84f9c9bcc5a701ba8257c06770fe241(s, config);
}

}


