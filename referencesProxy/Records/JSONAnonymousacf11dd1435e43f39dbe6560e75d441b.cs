using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Output2Record
public class JSONRC_29144121e66fe3c5dd5540583acfd891 : AbstractRESTStructure<RC_29144121e66fe3c5dd5540583acfd891> {
[JsonProperty("Output")]
[JsonPropertyName("Output")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure AttrOutput2;

public JSONRC_29144121e66fe3c5dd5540583acfd891() { }

public JSONRC_29144121e66fe3c5dd5540583acfd891 (RC_29144121e66fe3c5dd5540583acfd891 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOutput2 = ConvertToRestWithoutDefaults(s.ssSTOutput2, new ST_346a76e47f982dbf41625f8a893affccStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.FromStructure, config);
  } else {
AttrOutput2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.FromStructure(s.ssSTOutput2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891, RC_29144121e66fe3c5dd5540583acfd891> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891 s) => ToStructure(s, config);
}
public static RC_29144121e66fe3c5dd5540583acfd891 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891 obj, IBehaviorsConfiguration config) { 
  RC_29144121e66fe3c5dd5540583acfd891 s = new RC_29144121e66fe3c5dd5540583acfd891();
  if(obj != null) {
  s.ssSTOutput2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.ToStructure(obj.AttrOutput2, config);
  }
  return s;
}

public static Func<RC_29144121e66fe3c5dd5540583acfd891, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29144121e66fe3c5dd5540583acfd891 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891 FromStructure(RC_29144121e66fe3c5dd5540583acfd891 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_29144121e66fe3c5dd5540583acfd891(s, config);
}

}


