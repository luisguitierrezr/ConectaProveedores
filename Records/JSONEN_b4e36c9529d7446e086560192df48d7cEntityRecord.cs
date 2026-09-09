using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerTimeFormat
public class JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord : AbstractRESTStructure<EN_b4e36c9529d7446e086560192df48d7cEntityRecord> {
[JsonProperty("Timeformat")]
[JsonPropertyName("Timeformat")]
public string AttrTimeformat;

public JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord() { }

public JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord (EN_b4e36c9529d7446e086560192df48d7cEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimeformat = s.ssTimeformat;
  } else {
AttrTimeformat = s.ssTimeformat;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord, EN_b4e36c9529d7446e086560192df48d7cEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord s) => ToStructure(s, config);
}
public static EN_b4e36c9529d7446e086560192df48d7cEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b4e36c9529d7446e086560192df48d7cEntityRecord s = new EN_b4e36c9529d7446e086560192df48d7cEntityRecord();
  if(obj != null) {
  s.ssTimeformat = obj.AttrTimeformat == null ? "" : obj.AttrTimeformat;
  }
  return s;
}

public static Func<EN_b4e36c9529d7446e086560192df48d7cEntityRecord, ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b4e36c9529d7446e086560192df48d7cEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord FromStructure(EN_b4e36c9529d7446e086560192df48d7cEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b4e36c9529d7446e086560192df48d7cEntityRecord(s, config);
}

}


