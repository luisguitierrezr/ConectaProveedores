using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LogsAccountingSubject
public class JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord : AbstractRESTStructure<EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord> {
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

public JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord() { }

public JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord (EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord, EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord s) => ToStructure(s, config);
}
public static EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord s = new EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord, ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord FromStructure(EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord(s, config);
}

}


