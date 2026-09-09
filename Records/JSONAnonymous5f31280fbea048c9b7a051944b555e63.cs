using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER3Record
public class JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38 : AbstractRESTStructure<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> {
[JsonProperty("PI_HEADER3")]
[JsonPropertyName("PI_HEADER3")]
public ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure AttrPI_HEADER3;

public JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38() { }

public JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38 (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER3 = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER3, new ST_f6501ee18e176493154e18d361367656Structure(), ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.FromStructure, config);
  } else {
AttrPI_HEADER3 = ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.FromStructure(s.ssSTPI_HEADER3, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38, RC_6c8d2ba4baf7bbeee16e4c122dfe9b38> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38 s) => ToStructure(s, config);
}
public static RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38 obj, IBehaviorsConfiguration config) { 
  RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 s = new RC_6c8d2ba4baf7bbeee16e4c122dfe9b38();
  if(obj != null) {
  s.ssSTPI_HEADER3 = ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.ToStructure(obj.AttrPI_HEADER3, config);
  }
  return s;
}

public static Func<RC_6c8d2ba4baf7bbeee16e4c122dfe9b38, ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38 FromStructure(RC_6c8d2ba4baf7bbeee16e4c122dfe9b38 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6c8d2ba4baf7bbeee16e4c122dfe9b38(s, config);
}

}


