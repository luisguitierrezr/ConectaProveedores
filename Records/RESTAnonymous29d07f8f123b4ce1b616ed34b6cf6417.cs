using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER_EMRecord
public class RESTRC_e7cd27f178bb008051b405d4529062d2 : AbstractRESTStructure<RC_e7cd27f178bb008051b405d4529062d2> {
[JsonProperty("PI_HEADER_EM")]
public ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure AttrPI_HEADER_EM;

public RESTRC_e7cd27f178bb008051b405d4529062d2() { }

public RESTRC_e7cd27f178bb008051b405d4529062d2 (RC_e7cd27f178bb008051b405d4529062d2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER_EM = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER_EM, new ST_1186519ca5bb238ab9fc7126d4696469Structure(), ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure, config);
  } else {
AttrPI_HEADER_EM = ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.FromStructure(s.ssSTPI_HEADER_EM, config);
  }
}

public static RC_e7cd27f178bb008051b405d4529062d2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e7cd27f178bb008051b405d4529062d2 obj) { 
  RC_e7cd27f178bb008051b405d4529062d2 s = new RC_e7cd27f178bb008051b405d4529062d2();
  if(obj != null) {
  s.ssSTPI_HEADER_EM = ssConectaProveedores.RestRecords.RESTST_1186519ca5bb238ab9fc7126d4696469Structure.ToStructure(obj.AttrPI_HEADER_EM);
  }
  return s;
}

public static Func<RC_e7cd27f178bb008051b405d4529062d2, ssConectaProveedores.RestRecords.RESTRC_e7cd27f178bb008051b405d4529062d2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e7cd27f178bb008051b405d4529062d2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e7cd27f178bb008051b405d4529062d2 FromStructure(RC_e7cd27f178bb008051b405d4529062d2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e7cd27f178bb008051b405d4529062d2(s, config);
}

}


