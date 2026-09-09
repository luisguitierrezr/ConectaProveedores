using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PaperSizeRecord
public class JSONRC_6748c146370600806f2500c8b8a2cb25 : AbstractRESTStructure<RC_6748c146370600806f2500c8b8a2cb25> {
[JsonProperty("PaperSize")]
[JsonPropertyName("PaperSize")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord AttrPaperSize;

public JSONRC_6748c146370600806f2500c8b8a2cb25() { }

public JSONRC_6748c146370600806f2500c8b8a2cb25 (RC_6748c146370600806f2500c8b8a2cb25 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaperSize = ConvertToRestWithoutDefaults(s.ssENPaperSize, new EN_7f47ecde673669f1866fae1765d30761EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord.FromStructure, config);
  } else {
AttrPaperSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord.FromStructure(s.ssENPaperSize, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25, RC_6748c146370600806f2500c8b8a2cb25> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25 s) => ToStructure(s, config);
}
public static RC_6748c146370600806f2500c8b8a2cb25 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25 obj, IBehaviorsConfiguration config) { 
  RC_6748c146370600806f2500c8b8a2cb25 s = new RC_6748c146370600806f2500c8b8a2cb25();
  if(obj != null) {
  s.ssENPaperSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f47ecde673669f1866fae1765d30761EntityRecord.ToStructure(obj.AttrPaperSize, config);
  }
  return s;
}

public static Func<RC_6748c146370600806f2500c8b8a2cb25, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6748c146370600806f2500c8b8a2cb25 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25 FromStructure(RC_6748c146370600806f2500c8b8a2cb25 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6748c146370600806f2500c8b8a2cb25(s, config);
}

}


