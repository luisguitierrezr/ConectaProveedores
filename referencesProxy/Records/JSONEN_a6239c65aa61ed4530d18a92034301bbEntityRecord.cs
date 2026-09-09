using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Frequency
public class JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord : AbstractRESTStructure<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord> {
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

public JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord() { }

public JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord, EN_a6239c65aa61ed4530d18a92034301bbEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord s) => ToStructure(s, config);
}
public static EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord FromStructure(EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord(s, config);
}

}


