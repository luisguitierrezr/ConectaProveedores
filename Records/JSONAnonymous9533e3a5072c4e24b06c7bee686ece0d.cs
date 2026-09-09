using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_GL_ACC_GETDETAILRespRecord
public class JSONRC_027dc494fad7472a5ec9709173f161a6 : AbstractRESTStructure<RC_027dc494fad7472a5ec9709173f161a6> {
[JsonProperty("BAPI_GL_ACC_GETDETAILResp")]
[JsonPropertyName("BAPI_GL_ACC_GETDETAILResp")]
public ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure AttrBAPI_GL_ACC_GETDETAILResp;

public JSONRC_027dc494fad7472a5ec9709173f161a6() { }

public JSONRC_027dc494fad7472a5ec9709173f161a6 (RC_027dc494fad7472a5ec9709173f161a6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_GL_ACC_GETDETAILResp = ConvertToRestWithoutDefaults(s.ssSTBAPI_GL_ACC_GETDETAILResp, new ST_0f0d90fe4adeeddf082edffc80174eb8Structure(), ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure.FromStructure, config);
  } else {
AttrBAPI_GL_ACC_GETDETAILResp = ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure.FromStructure(s.ssSTBAPI_GL_ACC_GETDETAILResp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6, RC_027dc494fad7472a5ec9709173f161a6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6 s) => ToStructure(s, config);
}
public static RC_027dc494fad7472a5ec9709173f161a6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6 obj, IBehaviorsConfiguration config) { 
  RC_027dc494fad7472a5ec9709173f161a6 s = new RC_027dc494fad7472a5ec9709173f161a6();
  if(obj != null) {
  s.ssSTBAPI_GL_ACC_GETDETAILResp = ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure.ToStructure(obj.AttrBAPI_GL_ACC_GETDETAILResp, config);
  }
  return s;
}

public static Func<RC_027dc494fad7472a5ec9709173f161a6, ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_027dc494fad7472a5ec9709173f161a6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6 FromStructure(RC_027dc494fad7472a5ec9709173f161a6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_027dc494fad7472a5ec9709173f161a6(s, config);
}

}


