using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Frequency
public class RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord : AbstractRESTStructure<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord() { }

public RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord obj) { 
  EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord FromStructure(EN_a6239c65aa61ed4530d18a92034301bbEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord(s, config);
}

}


