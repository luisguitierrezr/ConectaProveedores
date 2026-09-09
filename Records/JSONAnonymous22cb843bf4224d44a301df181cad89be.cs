using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CFDITypeRecord
public class JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4 : AbstractRESTStructure<RC_2cc384f6ee3d7a04dad15c303ce7a7a4> {
[JsonProperty("CFDIType")]
[JsonPropertyName("CFDIType")]
public ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord AttrCFDIType;

public JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4() { }

public JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4 (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCFDIType = ConvertToRestWithoutDefaults(s.ssENCFDIType, new EN_f6b1999c25654417411e080987a56a77EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord.FromStructure, config);
  } else {
AttrCFDIType = ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord.FromStructure(s.ssENCFDIType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4, RC_2cc384f6ee3d7a04dad15c303ce7a7a4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4 s) => ToStructure(s, config);
}
public static RC_2cc384f6ee3d7a04dad15c303ce7a7a4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4 obj, IBehaviorsConfiguration config) { 
  RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s = new RC_2cc384f6ee3d7a04dad15c303ce7a7a4();
  if(obj != null) {
  s.ssENCFDIType = ssConectaProveedores.RestRecords.JSONEN_f6b1999c25654417411e080987a56a77EntityRecord.ToStructure(obj.AttrCFDIType, config);
  }
  return s;
}

public static Func<RC_2cc384f6ee3d7a04dad15c303ce7a7a4, ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4 FromStructure(RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2cc384f6ee3d7a04dad15c303ce7a7a4(s, config);
}

}


