using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Distribution
public class JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord : AbstractRESTStructure<EN_88460e7eac2a65d244abb23fe44af0adEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord() { }

public JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord, EN_88460e7eac2a65d244abb23fe44af0adEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord s) => ToStructure(s, config);
}
public static EN_88460e7eac2a65d244abb23fe44af0adEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_88460e7eac2a65d244abb23fe44af0adEntityRecord s = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_88460e7eac2a65d244abb23fe44af0adEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord FromStructure(EN_88460e7eac2a65d244abb23fe44af0adEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord(s, config);
}

}


