using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER_RMRecord
public class JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e : AbstractRESTStructure<RC_f53eb6300d410e7f0eaa48de8ddcca4e> {
[JsonProperty("PI_HEADER_RM")]
[JsonPropertyName("PI_HEADER_RM")]
public ssConectaProveedores.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure AttrPI_HEADER_RM;

public JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e() { }

public JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e (RC_f53eb6300d410e7f0eaa48de8ddcca4e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER_RM = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER_RM, new ST_cab398c7a09085084636430b80f5aa0dStructure(), ssConectaProveedores.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure, config);
  } else {
AttrPI_HEADER_RM = ssConectaProveedores.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure(s.ssSTPI_HEADER_RM, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e, RC_f53eb6300d410e7f0eaa48de8ddcca4e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e s) => ToStructure(s, config);
}
public static RC_f53eb6300d410e7f0eaa48de8ddcca4e ToStructure(ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e obj, IBehaviorsConfiguration config) { 
  RC_f53eb6300d410e7f0eaa48de8ddcca4e s = new RC_f53eb6300d410e7f0eaa48de8ddcca4e();
  if(obj != null) {
  s.ssSTPI_HEADER_RM = ssConectaProveedores.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.ToStructure(obj.AttrPI_HEADER_RM, config);
  }
  return s;
}

public static Func<RC_f53eb6300d410e7f0eaa48de8ddcca4e, ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f53eb6300d410e7f0eaa48de8ddcca4e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e FromStructure(RC_f53eb6300d410e7f0eaa48de8ddcca4e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f53eb6300d410e7f0eaa48de8ddcca4e(s, config);
}

}


