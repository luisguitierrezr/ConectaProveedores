using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LegendLayout
public class RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord : AbstractRESTStructure<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> {
[JsonProperty("Layout")]
public string AttrLayout;

public RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord() { }

public RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLayout = s.ssLayout;
  } else {
AttrLayout = s.ssLayout;
  }
}

public static EN_f2ce8f552d142202c9a955104f8986e7EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord obj) { 
  EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s = new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord();
  if(obj != null) {
  s.ssLayout = obj.AttrLayout == null ? "" : obj.AttrLayout;
  }
  return s;
}

public static Func<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord, ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord FromStructure(EN_f2ce8f552d142202c9a955104f8986e7EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_f2ce8f552d142202c9a955104f8986e7EntityRecord(s, config);
}

}


