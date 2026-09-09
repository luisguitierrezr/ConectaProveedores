using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADERRecord
public class JSONRC_80ed1f1aac7037960518642f9bfa450d : AbstractRESTStructure<RC_80ed1f1aac7037960518642f9bfa450d> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure AttrPI_HEADER;

public JSONRC_80ed1f1aac7037960518642f9bfa450d() { }

public JSONRC_80ed1f1aac7037960518642f9bfa450d (RC_80ed1f1aac7037960518642f9bfa450d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER, new ST_f4885e4f480f4a52f6c05031eda6ef37Structure(), ssConectaProveedores.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.FromStructure(s.ssSTPI_HEADER, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d, RC_80ed1f1aac7037960518642f9bfa450d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d s) => ToStructure(s, config);
}
public static RC_80ed1f1aac7037960518642f9bfa450d ToStructure(ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d obj, IBehaviorsConfiguration config) { 
  RC_80ed1f1aac7037960518642f9bfa450d s = new RC_80ed1f1aac7037960518642f9bfa450d();
  if(obj != null) {
  s.ssSTPI_HEADER = ssConectaProveedores.RestRecords.JSONST_f4885e4f480f4a52f6c05031eda6ef37Structure.ToStructure(obj.AttrPI_HEADER, config);
  }
  return s;
}

public static Func<RC_80ed1f1aac7037960518642f9bfa450d, ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_80ed1f1aac7037960518642f9bfa450d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d FromStructure(RC_80ed1f1aac7037960518642f9bfa450d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_80ed1f1aac7037960518642f9bfa450d(s, config);
}

}


