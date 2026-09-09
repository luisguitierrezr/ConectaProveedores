using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Origin
public class JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord : AbstractRESTStructure<EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord> {
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

public JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord() { }

public JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord (EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord, EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord s) => ToStructure(s, config);
}
public static EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord s = new EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord, ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord FromStructure(EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord(s, config);
}

}


