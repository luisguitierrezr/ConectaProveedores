using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_GL_ACC_GETDETAILReq
public class JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure : AbstractRESTStructure<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> {
[JsonProperty("COMPANYCODE")]
[JsonPropertyName("COMPANYCODE")]
public string AttrCOMPANYCODE;

[JsonProperty("GLACCT")]
[JsonPropertyName("GLACCT")]
public string AttrGLACCT;

[JsonProperty("LANGUAGE")]
[JsonPropertyName("LANGUAGE")]
public string AttrLANGUAGE;

[JsonProperty("LANGUAGE_ISO")]
[JsonPropertyName("LANGUAGE_ISO")]
public string AttrLANGUAGE_ISO;

[JsonProperty("TEXT_ONLY")]
[JsonPropertyName("TEXT_ONLY")]
public string AttrTEXT_ONLY;

public JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure() { }

public JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCOMPANYCODE = s.ssCOMPANYCODE;
AttrGLACCT = s.ssGLACCT;
AttrLANGUAGE = ConvertToRestWithoutDefaults(s.ssLANGUAGE, "");
AttrLANGUAGE_ISO = ConvertToRestWithoutDefaults(s.ssLANGUAGE_ISO, "");
AttrTEXT_ONLY = ConvertToRestWithoutDefaults(s.ssTEXT_ONLY, "");
  } else {
AttrCOMPANYCODE = s.ssCOMPANYCODE;
AttrGLACCT = s.ssGLACCT;
AttrLANGUAGE = s.ssLANGUAGE;
AttrLANGUAGE_ISO = s.ssLANGUAGE_ISO;
AttrTEXT_ONLY = s.ssTEXT_ONLY;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure, ST_442654d6c8649545cfc0a9d6bfc9f12cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure s) => ToStructure(s, config);
}
public static ST_442654d6c8649545cfc0a9d6bfc9f12cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure obj, IBehaviorsConfiguration config) { 
  ST_442654d6c8649545cfc0a9d6bfc9f12cStructure s = new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure();
  if(obj != null) {
  s.ssCOMPANYCODE = obj.AttrCOMPANYCODE == null ? "" : obj.AttrCOMPANYCODE;
  s.ssGLACCT = obj.AttrGLACCT == null ? "" : obj.AttrGLACCT;
  s.ssLANGUAGE = obj.AttrLANGUAGE == null ? "" : obj.AttrLANGUAGE;
  s.ssLANGUAGE_ISO = obj.AttrLANGUAGE_ISO == null ? "" : obj.AttrLANGUAGE_ISO;
  s.ssTEXT_ONLY = obj.AttrTEXT_ONLY == null ? "" : obj.AttrTEXT_ONLY;
  }
  return s;
}

public static Func<ST_442654d6c8649545cfc0a9d6bfc9f12cStructure, ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure FromStructure(ST_442654d6c8649545cfc0a9d6bfc9f12cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure(s, config);
}

}


