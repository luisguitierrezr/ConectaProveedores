using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AdvancePaymentType
public class JSONEN_485b44f219737098b3b1029e90069935EntityRecord : AbstractRESTStructure<EN_485b44f219737098b3b1029e90069935EntityRecord> {
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

public JSONEN_485b44f219737098b3b1029e90069935EntityRecord() { }

public JSONEN_485b44f219737098b3b1029e90069935EntityRecord (EN_485b44f219737098b3b1029e90069935EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord, EN_485b44f219737098b3b1029e90069935EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord s) => ToStructure(s, config);
}
public static EN_485b44f219737098b3b1029e90069935EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_485b44f219737098b3b1029e90069935EntityRecord s = new EN_485b44f219737098b3b1029e90069935EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_485b44f219737098b3b1029e90069935EntityRecord, ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_485b44f219737098b3b1029e90069935EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord FromStructure(EN_485b44f219737098b3b1029e90069935EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord(s, config);
}

}


