using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IT_ATTACHMENT
public class JSONST_7816c3c943d129234de46d39c32a618eStructure : AbstractRESTStructure<ST_7816c3c943d129234de46d39c32a618eStructure> {
[JsonProperty("ARC_DOC_ID")]
[JsonPropertyName("ARC_DOC_ID")]
public string AttrARC_DOC_ID;

[JsonProperty("ARCHIV_ID")]
[JsonPropertyName("ARCHIV_ID")]
public string AttrARCHIV_ID;

public JSONST_7816c3c943d129234de46d39c32a618eStructure() { }

public JSONST_7816c3c943d129234de46d39c32a618eStructure (ST_7816c3c943d129234de46d39c32a618eStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrARC_DOC_ID = ConvertToRestWithoutDefaults(s.ssARC_DOC_ID, "");
AttrARCHIV_ID = ConvertToRestWithoutDefaults(s.ssARCHIV_ID, "");
  } else {
AttrARC_DOC_ID = s.ssARC_DOC_ID;
AttrARCHIV_ID = s.ssARCHIV_ID;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure, ST_7816c3c943d129234de46d39c32a618eStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure s) => ToStructure(s, config);
}
public static ST_7816c3c943d129234de46d39c32a618eStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure obj, IBehaviorsConfiguration config) { 
  ST_7816c3c943d129234de46d39c32a618eStructure s = new ST_7816c3c943d129234de46d39c32a618eStructure();
  if(obj != null) {
  s.ssARC_DOC_ID = obj.AttrARC_DOC_ID == null ? "" : obj.AttrARC_DOC_ID;
  s.ssARCHIV_ID = obj.AttrARCHIV_ID == null ? "" : obj.AttrARCHIV_ID;
  }
  return s;
}

public static Func<ST_7816c3c943d129234de46d39c32a618eStructure, ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7816c3c943d129234de46d39c32a618eStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure FromStructure(ST_7816c3c943d129234de46d39c32a618eStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_7816c3c943d129234de46d39c32a618eStructure(s, config);
}

}


