using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_6ApprovalRecord
public class RESTRC_e84f9c9bcc5a701ba8257c06770fe241 : AbstractRESTStructure<RC_e84f9c9bcc5a701ba8257c06770fe241> {
[JsonProperty("InvoicesReport48_6Approval")]
public ssConectaProveedores.RestRecords.RESTST_39962f5b1f9edd4db48277d9dcced378Structure AttrInvoicesReport48_6Approval;

public RESTRC_e84f9c9bcc5a701ba8257c06770fe241() { }

public RESTRC_e84f9c9bcc5a701ba8257c06770fe241 (RC_e84f9c9bcc5a701ba8257c06770fe241 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48_6Approval = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48_6Approval, new ST_39962f5b1f9edd4db48277d9dcced378Structure(), ssConectaProveedores.RestRecords.RESTST_39962f5b1f9edd4db48277d9dcced378Structure.FromStructure, config);
  } else {
AttrInvoicesReport48_6Approval = ssConectaProveedores.RestRecords.RESTST_39962f5b1f9edd4db48277d9dcced378Structure.FromStructure(s.ssSTInvoicesReport48_6Approval, config);
  }
}

public static RC_e84f9c9bcc5a701ba8257c06770fe241 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e84f9c9bcc5a701ba8257c06770fe241 obj) { 
  RC_e84f9c9bcc5a701ba8257c06770fe241 s = new RC_e84f9c9bcc5a701ba8257c06770fe241();
  if(obj != null) {
  s.ssSTInvoicesReport48_6Approval = ssConectaProveedores.RestRecords.RESTST_39962f5b1f9edd4db48277d9dcced378Structure.ToStructure(obj.AttrInvoicesReport48_6Approval);
  }
  return s;
}

public static Func<RC_e84f9c9bcc5a701ba8257c06770fe241, ssConectaProveedores.RestRecords.RESTRC_e84f9c9bcc5a701ba8257c06770fe241> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e84f9c9bcc5a701ba8257c06770fe241 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e84f9c9bcc5a701ba8257c06770fe241 FromStructure(RC_e84f9c9bcc5a701ba8257c06770fe241 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e84f9c9bcc5a701ba8257c06770fe241(s, config);
}

}


