using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ContractStatus
public class RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord : AbstractRESTStructure<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("Class")]
public string AttrClass;

public RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord() { }

public RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord obj) { 
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

public static Func<EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord FromStructure(EN_1b54b857d541fcb95bf570b0d963f41aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1b54b857d541fcb95bf570b0d963f41aEntityRecord(s, config);
}

}


