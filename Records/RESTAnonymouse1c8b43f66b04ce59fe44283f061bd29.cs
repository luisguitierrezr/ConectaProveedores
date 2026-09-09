using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord
public class RESTRC_7bf0e8779480c1f841bf78e3626ee944 : AbstractRESTStructure<RC_7bf0e8779480c1f841bf78e3626ee944> {
[JsonProperty("LastApprover")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrLastApprover;

[JsonProperty("FolioStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("LastFolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrLastFolioApprovalLevel;

[JsonProperty("ApprovalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("CanApprove")]
public bool? AttrCanApprove;

[JsonProperty("DontShowAction")]
public bool? AttrDontShowAction;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

[JsonProperty("IsUserFromThisRegion")]
public bool? AttrIsUserFromThisRegion;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_7bf0e8779480c1f841bf78e3626ee944() { }

public RESTRC_7bf0e8779480c1f841bf78e3626ee944 (RC_7bf0e8779480c1f841bf78e3626ee944 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLastApprover = ConvertToRestWithoutDefaults(s.ssENLastApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrLastFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENLastFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCanApprove = ConvertToRestWithoutDefaults(s.ssCanApprove, false);
AttrDontShowAction = ConvertToRestWithoutDefaults(s.ssDontShowAction, false);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
AttrIsUserFromThisRegion = ConvertToRestWithoutDefaults(s.ssIsUserFromThisRegion, false);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrLastApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENLastApprover, config);
AttrFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrLastFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENLastFolioApprovalLevel, config);
AttrApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCanApprove = (bool?) s.ssCanApprove;
AttrDontShowAction = (bool?) s.ssDontShowAction;
AttrIsSelected = (bool?) s.ssIsSelected;
AttrIsUserFromThisRegion = (bool?) s.ssIsUserFromThisRegion;
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_7bf0e8779480c1f841bf78e3626ee944 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7bf0e8779480c1f841bf78e3626ee944 obj) { 
  RC_7bf0e8779480c1f841bf78e3626ee944 s = new RC_7bf0e8779480c1f841bf78e3626ee944();
  if(obj != null) {
  s.ssENLastApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrLastApprover);
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus);
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel);
  s.ssENLastFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrLastFolioApprovalLevel);
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssCanApprove = obj.AttrCanApprove == null ? false : obj.AttrCanApprove.Value;
  s.ssDontShowAction = obj.AttrDontShowAction == null ? false : obj.AttrDontShowAction.Value;
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  s.ssIsUserFromThisRegion = obj.AttrIsUserFromThisRegion == null ? false : obj.AttrIsUserFromThisRegion.Value;
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_7bf0e8779480c1f841bf78e3626ee944, ssConectaProveedores.RestRecords.RESTRC_7bf0e8779480c1f841bf78e3626ee944> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7bf0e8779480c1f841bf78e3626ee944 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7bf0e8779480c1f841bf78e3626ee944 FromStructure(RC_7bf0e8779480c1f841bf78e3626ee944 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7bf0e8779480c1f841bf78e3626ee944(s, config);
}

}


