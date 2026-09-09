using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessType
public class JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord : AbstractRESTStructure<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Label_ES")]
[JsonPropertyName("Label_ES")]
public string AttrLabel_ES;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord() { }

public JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrLabel_ES = ConvertToRestWithoutDefaults(s.ssLabel_ES, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrLabel_ES = s.ssLabel_ES;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord s) => ToStructure(s, config);
}
public static EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord s = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssLabel_ES = obj.AttrLabel_ES == null ? "" : obj.AttrLabel_ES;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord FromStructure(EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_51146e8018c571ce25065b00ce0d3a4dEntityRecord(s, config);
}

}


