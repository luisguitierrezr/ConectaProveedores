using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CreatedByRevokedBySourceUserTargetUserFolioReassignmentsFolioApprovalLevelOrderMainRecord
public class RESTRC_234ff55477e8affa6c928b8c8c03aedb : AbstractRESTStructure<RC_234ff55477e8affa6c928b8c8c03aedb> {
[JsonProperty("CreatedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrCreatedBy;

[JsonProperty("RevokedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrRevokedBy;

[JsonProperty("SourceUser")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrSourceUser;

[JsonProperty("TargetUser")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrTargetUser;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("Reassignments")]
public ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

[JsonProperty("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_234ff55477e8affa6c928b8c8c03aedb() { }

public RESTRC_234ff55477e8affa6c928b8c8c03aedb (RC_234ff55477e8affa6c928b8c8c03aedb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssENCreatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRevokedBy = ConvertToRestWithoutDefaults(s.ssENRevokedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrSourceUser = ConvertToRestWithoutDefaults(s.ssENSourceUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrTargetUser = ConvertToRestWithoutDefaults(s.ssENTargetUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrCreatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENCreatedBy, config);
AttrRevokedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENRevokedBy, config);
AttrSourceUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENSourceUser, config);
AttrTargetUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENTargetUser, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_234ff55477e8affa6c928b8c8c03aedb ToStructure(ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb obj) { 
  RC_234ff55477e8affa6c928b8c8c03aedb s = new RC_234ff55477e8affa6c928b8c8c03aedb();
  if(obj != null) {
  s.ssENCreatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrCreatedBy);
  s.ssENRevokedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrRevokedBy);
  s.ssENSourceUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrSourceUser);
  s.ssENTargetUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrTargetUser);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_234ff55477e8affa6c928b8c8c03aedb, ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_234ff55477e8affa6c928b8c8c03aedb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb FromStructure(RC_234ff55477e8affa6c928b8c8c03aedb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb(s, config);
}

}


