using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TimeZoneRecordRecord
public class JSONRC_cfaae8999ef94e08eeea036a2e8810d7 : AbstractRESTStructure<RC_cfaae8999ef94e08eeea036a2e8810d7> {
[JsonProperty("TimeZoneRecord")]
[JsonPropertyName("TimeZoneRecord")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure AttrTimeZoneRecord;

public JSONRC_cfaae8999ef94e08eeea036a2e8810d7() { }

public JSONRC_cfaae8999ef94e08eeea036a2e8810d7 (RC_cfaae8999ef94e08eeea036a2e8810d7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTimeZoneRecord = ConvertToRestWithoutDefaults(s.ssSTTimeZoneRecord, new ST_98371f99cd7bfeee4fab07e43606a1b5Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure.FromStructure, config);
  } else {
AttrTimeZoneRecord = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure.FromStructure(s.ssSTTimeZoneRecord, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7, RC_cfaae8999ef94e08eeea036a2e8810d7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7 s) => ToStructure(s, config);
}
public static RC_cfaae8999ef94e08eeea036a2e8810d7 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7 obj, IBehaviorsConfiguration config) { 
  RC_cfaae8999ef94e08eeea036a2e8810d7 s = new RC_cfaae8999ef94e08eeea036a2e8810d7();
  if(obj != null) {
  s.ssSTTimeZoneRecord = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure.ToStructure(obj.AttrTimeZoneRecord, config);
  }
  return s;
}

public static Func<RC_cfaae8999ef94e08eeea036a2e8810d7, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cfaae8999ef94e08eeea036a2e8810d7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7 FromStructure(RC_cfaae8999ef94e08eeea036a2e8810d7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_cfaae8999ef94e08eeea036a2e8810d7(s, config);
}

}


