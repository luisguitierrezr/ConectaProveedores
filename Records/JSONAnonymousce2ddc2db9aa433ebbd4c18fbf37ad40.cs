using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_COSMOZReqRecord
public class JSONRC_e6b9726aff274819952457f299ef917a : AbstractRESTStructure<RC_e6b9726aff274819952457f299ef917a> {
[JsonProperty("ZMXMIMMF_EM_COSMOZReq")]
[JsonPropertyName("ZMXMIMMF_EM_COSMOZReq")]
public ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure AttrZMXMIMMF_EM_COSMOZReq;

public JSONRC_e6b9726aff274819952457f299ef917a() { }

public JSONRC_e6b9726aff274819952457f299ef917a (RC_e6b9726aff274819952457f299ef917a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_COSMOZReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_COSMOZReq, new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure(), ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_COSMOZReq = ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure.FromStructure(s.ssSTZMXMIMMF_EM_COSMOZReq, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a, RC_e6b9726aff274819952457f299ef917a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a s) => ToStructure(s, config);
}
public static RC_e6b9726aff274819952457f299ef917a ToStructure(ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a obj, IBehaviorsConfiguration config) { 
  RC_e6b9726aff274819952457f299ef917a s = new RC_e6b9726aff274819952457f299ef917a();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_COSMOZReq = ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure.ToStructure(obj.AttrZMXMIMMF_EM_COSMOZReq, config);
  }
  return s;
}

public static Func<RC_e6b9726aff274819952457f299ef917a, ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e6b9726aff274819952457f299ef917a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a FromStructure(RC_e6b9726aff274819952457f299ef917a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e6b9726aff274819952457f299ef917a(s, config);
}

}


