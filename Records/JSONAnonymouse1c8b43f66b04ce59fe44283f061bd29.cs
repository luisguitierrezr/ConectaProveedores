using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord
public class JSONRC_7bf0e8779480c1f841bf78e3626ee944 : AbstractRESTStructure<RC_7bf0e8779480c1f841bf78e3626ee944> {
[JsonProperty("LastApprover")]
[JsonPropertyName("LastApprover")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrLastApprover;

[JsonProperty("FolioStatus")]
[JsonPropertyName("FolioStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("LastFolioApprovalLevel")]
[JsonPropertyName("LastFolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrLastFolioApprovalLevel;

[JsonProperty("ApprovalStatus")]
[JsonPropertyName("ApprovalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("CanApprove")]
[JsonPropertyName("CanApprove")]
public bool? AttrCanApprove;

[JsonProperty("DontShowAction")]
[JsonPropertyName("DontShowAction")]
public bool? AttrDontShowAction;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("IsUserFromThisRegion")]
[JsonPropertyName("IsUserFromThisRegion")]
public bool? AttrIsUserFromThisRegion;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_7bf0e8779480c1f841bf78e3626ee944() { }

public JSONRC_7bf0e8779480c1f841bf78e3626ee944 (RC_7bf0e8779480c1f841bf78e3626ee944 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLastApprover = ConvertToRestWithoutDefaults(s.ssENLastApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrLastFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENLastFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCanApprove = ConvertToRestWithoutDefaults(s.ssCanApprove, false);
AttrDontShowAction = ConvertToRestWithoutDefaults(s.ssDontShowAction, false);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrIsUserFromThisRegion = ConvertToRestWithoutDefaults(s.ssIsUserFromThisRegion, false);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrLastApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENLastApprover, config);
AttrFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrLastFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENLastFolioApprovalLevel, config);
AttrApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCanApprove = (bool?) s.ssCanApprove;
AttrDontShowAction = (bool?) s.ssDontShowAction;
AttrIsSelected = (bool?) s.ssIsSelected;
AttrIsUserFromThisRegion = (bool?) s.ssIsUserFromThisRegion;
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944, RC_7bf0e8779480c1f841bf78e3626ee944> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944 s) => ToStructure(s, config);
}
public static RC_7bf0e8779480c1f841bf78e3626ee944 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944 obj, IBehaviorsConfiguration config) { 
  RC_7bf0e8779480c1f841bf78e3626ee944 s = new RC_7bf0e8779480c1f841bf78e3626ee944();
  if(obj != null) {
  s.ssENLastApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrLastApprover, config);
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus, config);
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  s.ssENLastFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrLastFolioApprovalLevel, config);
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.JSONEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssCanApprove = obj.AttrCanApprove == null ? false : obj.AttrCanApprove.Value;
  s.ssDontShowAction = obj.AttrDontShowAction == null ? false : obj.AttrDontShowAction.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssIsUserFromThisRegion = obj.AttrIsUserFromThisRegion == null ? false : obj.AttrIsUserFromThisRegion.Value;
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_7bf0e8779480c1f841bf78e3626ee944, ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7bf0e8779480c1f841bf78e3626ee944 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944 FromStructure(RC_7bf0e8779480c1f841bf78e3626ee944 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7bf0e8779480c1f841bf78e3626ee944(s, config);
}

}


