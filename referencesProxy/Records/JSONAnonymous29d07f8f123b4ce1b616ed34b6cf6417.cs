using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_HEADER_EMRecord
public class JSONRC_e7cd27f178bb008051b405d4529062d2 : AbstractRESTStructure<RC_e7cd27f178bb008051b405d4529062d2> {
[JsonProperty("PI_HEADER_EM")]
[JsonPropertyName("PI_HEADER_EM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure AttrPI_HEADER_EM;

public JSONRC_e7cd27f178bb008051b405d4529062d2() { }

public JSONRC_e7cd27f178bb008051b405d4529062d2 (RC_e7cd27f178bb008051b405d4529062d2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER_EM = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER_EM, new ST_1186519ca5bb238ab9fc7126d4696469Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure, config);
  } else {
AttrPI_HEADER_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure(s.ssSTPI_HEADER_EM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2, RC_e7cd27f178bb008051b405d4529062d2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2 s) => ToStructure(s, config);
}
public static RC_e7cd27f178bb008051b405d4529062d2 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2 obj, IBehaviorsConfiguration config) { 
  RC_e7cd27f178bb008051b405d4529062d2 s = new RC_e7cd27f178bb008051b405d4529062d2();
  if(obj != null) {
  s.ssSTPI_HEADER_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1186519ca5bb238ab9fc7126d4696469Structure.ToStructure(obj.AttrPI_HEADER_EM, config);
  }
  return s;
}

public static Func<RC_e7cd27f178bb008051b405d4529062d2, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e7cd27f178bb008051b405d4529062d2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2 FromStructure(RC_e7cd27f178bb008051b405d4529062d2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e7cd27f178bb008051b405d4529062d2(s, config);
}

}


