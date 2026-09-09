using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedByUser_UpdatedByFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelRecord
public class RESTRC_3c4405ea19e4fb66009c54078ab80e28 : AbstractRESTStructure<RC_3c4405ea19e4fb66009c54078ab80e28> {
[JsonProperty("User_CreatedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_CreatedBy;

[JsonProperty("User_UpdatedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_UpdatedBy;

[JsonProperty("FolioStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public RESTRC_3c4405ea19e4fb66009c54078ab80e28() { }

public RESTRC_3c4405ea19e4fb66009c54078ab80e28 (RC_3c4405ea19e4fb66009c54078ab80e28 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_CreatedBy = ConvertToRestWithoutDefaults(s.ssENUser_CreatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_UpdatedBy = ConvertToRestWithoutDefaults(s.ssENUser_UpdatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrUser_CreatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_CreatedBy, config);
AttrUser_UpdatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_UpdatedBy, config);
AttrFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static RC_3c4405ea19e4fb66009c54078ab80e28 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28 obj) { 
  RC_3c4405ea19e4fb66009c54078ab80e28 s = new RC_3c4405ea19e4fb66009c54078ab80e28();
  if(obj != null) {
  s.ssENUser_CreatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_CreatedBy);
  s.ssENUser_UpdatedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_UpdatedBy);
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus);
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel);
  }
  return s;
}

public static Func<RC_3c4405ea19e4fb66009c54078ab80e28, ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c4405ea19e4fb66009c54078ab80e28 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28 FromStructure(RC_3c4405ea19e4fb66009c54078ab80e28 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28(s, config);
}

}


