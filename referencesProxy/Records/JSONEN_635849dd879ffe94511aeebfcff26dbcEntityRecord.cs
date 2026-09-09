using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EntraDomain
public class JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord : AbstractRESTStructure<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord> {
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

[JsonProperty("Sufix")]
[JsonPropertyName("Sufix")]
public string AttrSufix;

public JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord() { }

public JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrSufix = ConvertToRestWithoutDefaults(s.ssSufix, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrSufix = s.ssSufix;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord, EN_635849dd879ffe94511aeebfcff26dbcEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord s) => ToStructure(s, config);
}
public static EN_635849dd879ffe94511aeebfcff26dbcEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s = new EN_635849dd879ffe94511aeebfcff26dbcEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssSufix = obj.AttrSufix == null ? "" : obj.AttrSufix;
  }
  return s;
}

public static Func<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord FromStructure(EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_635849dd879ffe94511aeebfcff26dbcEntityRecord(s, config);
}

}


