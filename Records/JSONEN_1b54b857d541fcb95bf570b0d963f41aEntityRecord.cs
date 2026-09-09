using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractStatus
public class JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord : AbstractRESTStructure<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> {
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

[JsonProperty("Class")]
[JsonPropertyName("Class")]
public string AttrClass;

public JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord() { }

public JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrClass = s.ssClass;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s) => ToStructure(s, config);
}
public static EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s = new EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  }
  return s;
}

public static Func<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord FromStructure(EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord(s, config);
}

}


