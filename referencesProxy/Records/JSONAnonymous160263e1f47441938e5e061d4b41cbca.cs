using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BAPI_GL_ACC_GETDETAILReqRecord
public class JSONRC_e9778c0a791f25dad6b0c1f1b26da61c : AbstractRESTStructure<RC_e9778c0a791f25dad6b0c1f1b26da61c> {
[JsonProperty("BAPI_GL_ACC_GETDETAILReq")]
[JsonPropertyName("BAPI_GL_ACC_GETDETAILReq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure AttrBAPI_GL_ACC_GETDETAILReq;

public JSONRC_e9778c0a791f25dad6b0c1f1b26da61c() { }

public JSONRC_e9778c0a791f25dad6b0c1f1b26da61c (RC_e9778c0a791f25dad6b0c1f1b26da61c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_GL_ACC_GETDETAILReq = ConvertToRestWithoutDefaults(s.ssSTBAPI_GL_ACC_GETDETAILReq, new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure.FromStructure, config);
  } else {
AttrBAPI_GL_ACC_GETDETAILReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure.FromStructure(s.ssSTBAPI_GL_ACC_GETDETAILReq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c, RC_e9778c0a791f25dad6b0c1f1b26da61c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c s) => ToStructure(s, config);
}
public static RC_e9778c0a791f25dad6b0c1f1b26da61c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c obj, IBehaviorsConfiguration config) { 
  RC_e9778c0a791f25dad6b0c1f1b26da61c s = new RC_e9778c0a791f25dad6b0c1f1b26da61c();
  if(obj != null) {
  s.ssSTBAPI_GL_ACC_GETDETAILReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure.ToStructure(obj.AttrBAPI_GL_ACC_GETDETAILReq, config);
  }
  return s;
}

public static Func<RC_e9778c0a791f25dad6b0c1f1b26da61c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e9778c0a791f25dad6b0c1f1b26da61c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c FromStructure(RC_e9778c0a791f25dad6b0c1f1b26da61c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e9778c0a791f25dad6b0c1f1b26da61c(s, config);
}

}


