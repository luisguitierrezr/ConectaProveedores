using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MarginSizeRecord
public class RESTRC_1fb80539f98a7ca912363f5e5c822271 : AbstractRESTStructure<RC_1fb80539f98a7ca912363f5e5c822271> {
[JsonProperty("MarginSize")]
public ssConectaProveedores.RestRecords.RESTEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord AttrMarginSize;

public RESTRC_1fb80539f98a7ca912363f5e5c822271() { }

public RESTRC_1fb80539f98a7ca912363f5e5c822271 (RC_1fb80539f98a7ca912363f5e5c822271 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMarginSize = ConvertToRestWithoutDefaults(s.ssENMarginSize, new EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.FromStructure, config);
  } else {
AttrMarginSize = ssConectaProveedores.RestRecords.RESTEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.FromStructure(s.ssENMarginSize, config);
  }
}

public static RC_1fb80539f98a7ca912363f5e5c822271 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1fb80539f98a7ca912363f5e5c822271 obj) { 
  RC_1fb80539f98a7ca912363f5e5c822271 s = new RC_1fb80539f98a7ca912363f5e5c822271();
  if(obj != null) {
  s.ssENMarginSize = ssConectaProveedores.RestRecords.RESTEN_bc12735cadf5fd97cab6601d74d436e8EntityRecord.ToStructure(obj.AttrMarginSize);
  }
  return s;
}

public static Func<RC_1fb80539f98a7ca912363f5e5c822271, ssConectaProveedores.RestRecords.RESTRC_1fb80539f98a7ca912363f5e5c822271> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1fb80539f98a7ca912363f5e5c822271 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1fb80539f98a7ca912363f5e5c822271 FromStructure(RC_1fb80539f98a7ca912363f5e5c822271 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1fb80539f98a7ca912363f5e5c822271(s, config);
}

}


