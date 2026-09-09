using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER_MORecord
public class JSONRC_5c3ac3a9ea8d123d893bbdf956320e53 : AbstractRESTStructure<RC_5c3ac3a9ea8d123d893bbdf956320e53> {
[JsonProperty("PI_HEADER_MO")]
[JsonPropertyName("PI_HEADER_MO")]
public ssConectaProveedores.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure AttrPI_HEADER_MO;

public JSONRC_5c3ac3a9ea8d123d893bbdf956320e53() { }

public JSONRC_5c3ac3a9ea8d123d893bbdf956320e53 (RC_5c3ac3a9ea8d123d893bbdf956320e53 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER_MO = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER_MO, new ST_16a23b6e422231c222f34612ecd6c640Structure(), ssConectaProveedores.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.FromStructure, config);
  } else {
AttrPI_HEADER_MO = ssConectaProveedores.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.FromStructure(s.ssSTPI_HEADER_MO, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53, RC_5c3ac3a9ea8d123d893bbdf956320e53> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53 s) => ToStructure(s, config);
}
public static RC_5c3ac3a9ea8d123d893bbdf956320e53 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53 obj, IBehaviorsConfiguration config) { 
  RC_5c3ac3a9ea8d123d893bbdf956320e53 s = new RC_5c3ac3a9ea8d123d893bbdf956320e53();
  if(obj != null) {
  s.ssSTPI_HEADER_MO = ssConectaProveedores.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.ToStructure(obj.AttrPI_HEADER_MO, config);
  }
  return s;
}

public static Func<RC_5c3ac3a9ea8d123d893bbdf956320e53, ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5c3ac3a9ea8d123d893bbdf956320e53 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53 FromStructure(RC_5c3ac3a9ea8d123d893bbdf956320e53 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5c3ac3a9ea8d123d893bbdf956320e53(s, config);
}

}


