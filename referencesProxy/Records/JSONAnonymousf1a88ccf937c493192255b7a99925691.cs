using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// MarginSizeRecord
public class JSONRC_1fb80539f98a7ca912363f5e5c822271 : AbstractRESTStructure<RC_1fb80539f98a7ca912363f5e5c822271> {
[JsonProperty("MarginSize")]
[JsonPropertyName("MarginSize")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord AttrMarginSize;

public JSONRC_1fb80539f98a7ca912363f5e5c822271() { }

public JSONRC_1fb80539f98a7ca912363f5e5c822271 (RC_1fb80539f98a7ca912363f5e5c822271 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarginSize = ConvertToRestWithoutDefaults(s.ssENMarginSize, new EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.FromStructure, config);
  } else {
AttrMarginSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.FromStructure(s.ssENMarginSize, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271, RC_1fb80539f98a7ca912363f5e5c822271> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271 s) => ToStructure(s, config);
}
public static RC_1fb80539f98a7ca912363f5e5c822271 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271 obj, IBehaviorsConfiguration config) { 
  RC_1fb80539f98a7ca912363f5e5c822271 s = new RC_1fb80539f98a7ca912363f5e5c822271();
  if(obj != null) {
  s.ssENMarginSize = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.ToStructure(obj.AttrMarginSize, config);
  }
  return s;
}

public static Func<RC_1fb80539f98a7ca912363f5e5c822271, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1fb80539f98a7ca912363f5e5c822271 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271 FromStructure(RC_1fb80539f98a7ca912363f5e5c822271 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_1fb80539f98a7ca912363f5e5c822271(s, config);
}

}


