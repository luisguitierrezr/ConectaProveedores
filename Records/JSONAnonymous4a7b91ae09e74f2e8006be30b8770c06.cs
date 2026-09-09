using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalLevelIdFolioIdFolioNumberRecord
public class JSONRC_6041e483640e901fd2a96b2a9af2a903 : AbstractRESTStructure<RC_6041e483640e901fd2a96b2a9af2a903> {
[JsonProperty("FolioApprovalLevelId")]
[JsonPropertyName("FolioApprovalLevelId")]
public long? AttrFolioApprovalLevelId;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("FolioNumber")]
[JsonPropertyName("FolioNumber")]
public string AttrFolioNumber;

public JSONRC_6041e483640e901fd2a96b2a9af2a903() { }

public JSONRC_6041e483640e901fd2a96b2a9af2a903 (RC_6041e483640e901fd2a96b2a9af2a903 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApprovalLevelId = ConvertToRestWithoutDefaults(s.ssFolioApprovalLevelId, 0L);
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrFolioNumber = ConvertToRestWithoutDefaults(s.ssFolioNumber, "");
  } else {
AttrFolioApprovalLevelId = (long?) s.ssFolioApprovalLevelId;
AttrFolioId = (long?) s.ssFolioId;
AttrFolioNumber = s.ssFolioNumber;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903, RC_6041e483640e901fd2a96b2a9af2a903> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903 s) => ToStructure(s, config);
}
public static RC_6041e483640e901fd2a96b2a9af2a903 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903 obj, IBehaviorsConfiguration config) { 
  RC_6041e483640e901fd2a96b2a9af2a903 s = new RC_6041e483640e901fd2a96b2a9af2a903();
  if(obj != null) {
  s.ssFolioApprovalLevelId = obj.AttrFolioApprovalLevelId == null ? 0L : obj.AttrFolioApprovalLevelId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssFolioNumber = obj.AttrFolioNumber == null ? "" : obj.AttrFolioNumber;
  }
  return s;
}

public static Func<RC_6041e483640e901fd2a96b2a9af2a903, ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6041e483640e901fd2a96b2a9af2a903 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903 FromStructure(RC_6041e483640e901fd2a96b2a9af2a903 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6041e483640e901fd2a96b2a9af2a903(s, config);
}

}


