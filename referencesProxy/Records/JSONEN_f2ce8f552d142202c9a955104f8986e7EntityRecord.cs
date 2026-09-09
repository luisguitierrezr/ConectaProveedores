using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// LegendLayout
public class JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord : AbstractRESTStructure<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> {
[JsonProperty("Layout")]
[JsonPropertyName("Layout")]
public string AttrLayout;

public JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord() { }

public JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLayout = s.ssLayout;
  } else {
AttrLayout = s.ssLayout;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord, EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord s) => ToStructure(s, config);
}
public static EN_f2ce8f552d142202c9a955104f8986e7EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s = new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord();
  if(obj != null) {
  s.ssLayout = obj.AttrLayout == null ? "" : obj.AttrLayout;
  }
  return s;
}

public static Func<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord FromStructure(EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f2ce8f552d142202c9a955104f8986e7EntityRecord(s, config);
}

}


