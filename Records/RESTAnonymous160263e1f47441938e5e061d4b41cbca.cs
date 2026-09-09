using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_GL_ACC_GETDETAILReqRecord
public class RESTRC_e9778c0a791f25dad6b0c1f1b26da61c : AbstractRESTStructure<RC_e9778c0a791f25dad6b0c1f1b26da61c> {
[JsonProperty("BAPI_GL_ACC_GETDETAILReq")]
public ssConectaProveedores.RestRecords.RESTST_442654d6c8649545cfc0a9d6bfc9f12cStructure AttrBAPI_GL_ACC_GETDETAILReq;

public RESTRC_e9778c0a791f25dad6b0c1f1b26da61c() { }

public RESTRC_e9778c0a791f25dad6b0c1f1b26da61c (RC_e9778c0a791f25dad6b0c1f1b26da61c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_GL_ACC_GETDETAILReq = ConvertToRestWithoutDefaults(s.ssSTBAPI_GL_ACC_GETDETAILReq, new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure(), ssConectaProveedores.RestRecords.RESTST_442654d6c8649545cfc0a9d6bfc9f12cStructure.FromStructure, config);
  } else {
AttrBAPI_GL_ACC_GETDETAILReq = ssConectaProveedores.RestRecords.RESTST_442654d6c8649545cfc0a9d6bfc9f12cStructure.FromStructure(s.ssSTBAPI_GL_ACC_GETDETAILReq, config);
  }
}

public static RC_e9778c0a791f25dad6b0c1f1b26da61c ToStructure(ssConectaProveedores.RestRecords.RESTRC_e9778c0a791f25dad6b0c1f1b26da61c obj) { 
  RC_e9778c0a791f25dad6b0c1f1b26da61c s = new RC_e9778c0a791f25dad6b0c1f1b26da61c();
  if(obj != null) {
  s.ssSTBAPI_GL_ACC_GETDETAILReq = ssConectaProveedores.RestRecords.RESTST_442654d6c8649545cfc0a9d6bfc9f12cStructure.ToStructure(obj.AttrBAPI_GL_ACC_GETDETAILReq);
  }
  return s;
}

public static Func<RC_e9778c0a791f25dad6b0c1f1b26da61c, ssConectaProveedores.RestRecords.RESTRC_e9778c0a791f25dad6b0c1f1b26da61c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e9778c0a791f25dad6b0c1f1b26da61c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e9778c0a791f25dad6b0c1f1b26da61c FromStructure(RC_e9778c0a791f25dad6b0c1f1b26da61c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e9778c0a791f25dad6b0c1f1b26da61c(s, config);
}

}


