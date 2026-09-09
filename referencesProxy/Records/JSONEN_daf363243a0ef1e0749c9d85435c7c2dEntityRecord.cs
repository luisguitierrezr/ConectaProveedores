using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Operator
public class JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord : AbstractRESTStructure<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> {
[JsonProperty("Operator")]
[JsonPropertyName("Operator")]
public string AttrOperator;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord() { }

public JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s) => ToStructure(s, config);
}
public static EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s = new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord();
  if(obj != null) {
  s.ssOperator = obj.AttrOperator == null ? "" : obj.AttrOperator;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord FromStructure(EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord(s, config);
}

}


