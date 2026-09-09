using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CFDITypeRecord
public class RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4 : AbstractRESTStructure<RC_2cc384f6ee3d7a04dad15c303ce7a7a4> {
[JsonProperty("CFDIType")]
public ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord AttrCFDIType;

public RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4() { }

public RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4 (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCFDIType = ConvertToRestWithoutDefaults(s.ssENCFDIType, new EN_f6b1999c25654417411e080987a56a77EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord.FromStructure, config);
  } else {
AttrCFDIType = ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord.FromStructure(s.ssENCFDIType, config);
  }
}

public static RC_2cc384f6ee3d7a04dad15c303ce7a7a4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4 obj) { 
  RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s = new RC_2cc384f6ee3d7a04dad15c303ce7a7a4();
  if(obj != null) {
  s.ssENCFDIType = ssConectaProveedores.RestRecords.RESTEN_f6b1999c25654417411e080987a56a77EntityRecord.ToStructure(obj.AttrCFDIType);
  }
  return s;
}

public static Func<RC_2cc384f6ee3d7a04dad15c303ce7a7a4, ssConectaProveedores.RestRecords.RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4 FromStructure(RC_2cc384f6ee3d7a04dad15c303ce7a7a4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2cc384f6ee3d7a04dad15c303ce7a7a4(s, config);
}

}


