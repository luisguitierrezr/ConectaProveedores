using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Output2Record
public class RESTRC_29144121e66fe3c5dd5540583acfd891 : AbstractRESTStructure<RC_29144121e66fe3c5dd5540583acfd891> {
[JsonProperty("Output")]
public ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure AttrOutput2;

public RESTRC_29144121e66fe3c5dd5540583acfd891() { }

public RESTRC_29144121e66fe3c5dd5540583acfd891 (RC_29144121e66fe3c5dd5540583acfd891 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOutput2 = ConvertToRestWithoutDefaults(s.ssSTOutput2, new ST_346a76e47f982dbf41625f8a893affccStructure(), ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure.FromStructure, config);
  } else {
AttrOutput2 = ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure.FromStructure(s.ssSTOutput2, config);
  }
}

public static RC_29144121e66fe3c5dd5540583acfd891 ToStructure(ssConectaProveedores.RestRecords.RESTRC_29144121e66fe3c5dd5540583acfd891 obj) { 
  RC_29144121e66fe3c5dd5540583acfd891 s = new RC_29144121e66fe3c5dd5540583acfd891();
  if(obj != null) {
  s.ssSTOutput2 = ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure.ToStructure(obj.AttrOutput2);
  }
  return s;
}

public static Func<RC_29144121e66fe3c5dd5540583acfd891, ssConectaProveedores.RestRecords.RESTRC_29144121e66fe3c5dd5540583acfd891> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29144121e66fe3c5dd5540583acfd891 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_29144121e66fe3c5dd5540583acfd891 FromStructure(RC_29144121e66fe3c5dd5540583acfd891 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_29144121e66fe3c5dd5540583acfd891(s, config);
}

}


