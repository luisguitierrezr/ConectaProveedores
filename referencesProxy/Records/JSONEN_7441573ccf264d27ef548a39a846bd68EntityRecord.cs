using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Steps
public class JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord : AbstractRESTStructure<EN_7441573ccf264d27ef548a39a846bd68EntityRecord> {
[JsonProperty("Steps")]
[JsonPropertyName("Steps")]
public string AttrSteps;

public JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord() { }

public JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord (EN_7441573ccf264d27ef548a39a846bd68EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSteps = s.ssSteps;
  } else {
AttrSteps = s.ssSteps;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord, EN_7441573ccf264d27ef548a39a846bd68EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord s) => ToStructure(s, config);
}
public static EN_7441573ccf264d27ef548a39a846bd68EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7441573ccf264d27ef548a39a846bd68EntityRecord s = new EN_7441573ccf264d27ef548a39a846bd68EntityRecord();
  if(obj != null) {
  s.ssSteps = obj.AttrSteps == null ? "" : obj.AttrSteps;
  }
  return s;
}

public static Func<EN_7441573ccf264d27ef548a39a846bd68EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7441573ccf264d27ef548a39a846bd68EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord FromStructure(EN_7441573ccf264d27ef548a39a846bd68EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord(s, config);
}

}


