using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalLevelRecord
public class JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f : AbstractRESTStructure<RC_ff8382bb6fb6cc7d57ecda7bb499922f> {
[JsonProperty("OrderApprovalLevel")]
[JsonPropertyName("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f() { }

public JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f (RC_ff8382bb6fb6cc7d57ecda7bb499922f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f, RC_ff8382bb6fb6cc7d57ecda7bb499922f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f s) => ToStructure(s, config);
}
public static RC_ff8382bb6fb6cc7d57ecda7bb499922f ToStructure(ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f obj, IBehaviorsConfiguration config) { 
  RC_ff8382bb6fb6cc7d57ecda7bb499922f s = new RC_ff8382bb6fb6cc7d57ecda7bb499922f();
  if(obj != null) {
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel, config);
  }
  return s;
}

public static Func<RC_ff8382bb6fb6cc7d57ecda7bb499922f, ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ff8382bb6fb6cc7d57ecda7bb499922f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f FromStructure(RC_ff8382bb6fb6cc7d57ecda7bb499922f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ff8382bb6fb6cc7d57ecda7bb499922f(s, config);
}

}


