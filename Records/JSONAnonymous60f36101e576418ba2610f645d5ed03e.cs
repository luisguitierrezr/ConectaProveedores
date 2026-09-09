using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CreatedByRevokedBySourceUserTargetUserFolioReassignmentsFolioApprovalLevelOrderMainRecord
public class JSONRC_234ff55477e8affa6c928b8c8c03aedb : AbstractRESTStructure<RC_234ff55477e8affa6c928b8c8c03aedb> {
[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrCreatedBy;

[JsonProperty("RevokedBy")]
[JsonPropertyName("RevokedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrRevokedBy;

[JsonProperty("SourceUser")]
[JsonPropertyName("SourceUser")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrSourceUser;

[JsonProperty("TargetUser")]
[JsonPropertyName("TargetUser")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrTargetUser;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("Reassignments")]
[JsonPropertyName("Reassignments")]
public ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_234ff55477e8affa6c928b8c8c03aedb() { }

public JSONRC_234ff55477e8affa6c928b8c8c03aedb (RC_234ff55477e8affa6c928b8c8c03aedb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssENCreatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRevokedBy = ConvertToRestWithoutDefaults(s.ssENRevokedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrSourceUser = ConvertToRestWithoutDefaults(s.ssENSourceUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrTargetUser = ConvertToRestWithoutDefaults(s.ssENTargetUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrCreatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENCreatedBy, config);
AttrRevokedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENRevokedBy, config);
AttrSourceUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENSourceUser, config);
AttrTargetUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENTargetUser, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb, RC_234ff55477e8affa6c928b8c8c03aedb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb s) => ToStructure(s, config);
}
public static RC_234ff55477e8affa6c928b8c8c03aedb ToStructure(ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb obj, IBehaviorsConfiguration config) { 
  RC_234ff55477e8affa6c928b8c8c03aedb s = new RC_234ff55477e8affa6c928b8c8c03aedb();
  if(obj != null) {
  s.ssENCreatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrCreatedBy, config);
  s.ssENRevokedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrRevokedBy, config);
  s.ssENSourceUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrSourceUser, config);
  s.ssENTargetUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrTargetUser, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_234ff55477e8affa6c928b8c8c03aedb, ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_234ff55477e8affa6c928b8c8c03aedb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb FromStructure(RC_234ff55477e8affa6c928b8c8c03aedb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_234ff55477e8affa6c928b8c8c03aedb(s, config);
}

}


