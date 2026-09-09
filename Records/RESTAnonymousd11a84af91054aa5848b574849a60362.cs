using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApprovalLevelRecord
public class RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f : AbstractRESTStructure<RC_ff8382bb6fb6cc7d57ecda7bb499922f> {
[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

public RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f() { }

public RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f (RC_ff8382bb6fb6cc7d57ecda7bb499922f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
  } else {
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
  }
}

public static RC_ff8382bb6fb6cc7d57ecda7bb499922f ToStructure(ssConectaProveedores.RestRecords.RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f obj) { 
  RC_ff8382bb6fb6cc7d57ecda7bb499922f s = new RC_ff8382bb6fb6cc7d57ecda7bb499922f();
  if(obj != null) {
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  }
  return s;
}

public static Func<RC_ff8382bb6fb6cc7d57ecda7bb499922f, ssConectaProveedores.RestRecords.RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ff8382bb6fb6cc7d57ecda7bb499922f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f FromStructure(RC_ff8382bb6fb6cc7d57ecda7bb499922f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ff8382bb6fb6cc7d57ecda7bb499922f(s, config);
}

}


