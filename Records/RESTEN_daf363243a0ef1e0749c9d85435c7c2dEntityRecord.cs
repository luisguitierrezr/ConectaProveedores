using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Operator
public class RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord : AbstractRESTStructure<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> {
[JsonProperty("Operator")]
public string AttrOperator;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord() { }

public RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOperator = s.ssOperator;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrOperator = s.ssOperator;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord obj) { 
  EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s = new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord();
  if(obj != null) {
  s.ssOperator = obj.AttrOperator == null ? "" : obj.AttrOperator;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord FromStructure(EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord(s, config);
}

}


