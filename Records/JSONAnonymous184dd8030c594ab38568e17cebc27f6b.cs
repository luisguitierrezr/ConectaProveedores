using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderOrderApprovalLevelIdRecord
public class JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0 : AbstractRESTStructure<RC_6a01c4ef1c8f90eed41c7255c682f6e0> {
[JsonProperty("Order")]
[JsonPropertyName("Order")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrder;

[JsonProperty("OrderApprovalLevelId")]
[JsonPropertyName("OrderApprovalLevelId")]
public long? AttrOrderApprovalLevelId;

public JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0() { }

public JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0 (RC_6a01c4ef1c8f90eed41c7255c682f6e0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrder = ConvertToRestWithoutDefaults(s.ssENOrder, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderApprovalLevelId = ConvertToRestWithoutDefaults(s.ssOrderApprovalLevelId, 0L);
  } else {
AttrOrder = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrder, config);
AttrOrderApprovalLevelId = (long?) s.ssOrderApprovalLevelId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0, RC_6a01c4ef1c8f90eed41c7255c682f6e0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0 s) => ToStructure(s, config);
}
public static RC_6a01c4ef1c8f90eed41c7255c682f6e0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0 obj, IBehaviorsConfiguration config) { 
  RC_6a01c4ef1c8f90eed41c7255c682f6e0 s = new RC_6a01c4ef1c8f90eed41c7255c682f6e0();
  if(obj != null) {
  s.ssENOrder = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrder, config);
  s.ssOrderApprovalLevelId = obj.AttrOrderApprovalLevelId == null ? 0L : obj.AttrOrderApprovalLevelId.Value;
  }
  return s;
}

public static Func<RC_6a01c4ef1c8f90eed41c7255c682f6e0, ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6a01c4ef1c8f90eed41c7255c682f6e0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0 FromStructure(RC_6a01c4ef1c8f90eed41c7255c682f6e0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6a01c4ef1c8f90eed41c7255c682f6e0(s, config);
}

}


