using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_CreatedByUser_UpdatedByFolioStatusFolioApprovalInvoiceFolioFolioApprovalLevelRecord
public class JSONRC_3c4405ea19e4fb66009c54078ab80e28 : AbstractRESTStructure<RC_3c4405ea19e4fb66009c54078ab80e28> {
[JsonProperty("User_CreatedBy")]
[JsonPropertyName("User_CreatedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_CreatedBy;

[JsonProperty("User_UpdatedBy")]
[JsonPropertyName("User_UpdatedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_UpdatedBy;

[JsonProperty("FolioStatus")]
[JsonPropertyName("FolioStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

[JsonProperty("FolioApproval")]
[JsonPropertyName("FolioApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioApprovalLevel")]
[JsonPropertyName("FolioApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFolioApprovalLevel;

public JSONRC_3c4405ea19e4fb66009c54078ab80e28() { }

public JSONRC_3c4405ea19e4fb66009c54078ab80e28 (RC_3c4405ea19e4fb66009c54078ab80e28 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_CreatedBy = ConvertToRestWithoutDefaults(s.ssENUser_CreatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_UpdatedBy = ConvertToRestWithoutDefaults(s.ssENUser_UpdatedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFolioApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrUser_CreatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_CreatedBy, config);
AttrUser_UpdatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_UpdatedBy, config);
AttrFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
AttrFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFolioApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28, RC_3c4405ea19e4fb66009c54078ab80e28> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28 s) => ToStructure(s, config);
}
public static RC_3c4405ea19e4fb66009c54078ab80e28 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28 obj, IBehaviorsConfiguration config) { 
  RC_3c4405ea19e4fb66009c54078ab80e28 s = new RC_3c4405ea19e4fb66009c54078ab80e28();
  if(obj != null) {
  s.ssENUser_CreatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_CreatedBy, config);
  s.ssENUser_UpdatedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_UpdatedBy, config);
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus, config);
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.JSONEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFolioApprovalLevel, config);
  }
  return s;
}

public static Func<RC_3c4405ea19e4fb66009c54078ab80e28, ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c4405ea19e4fb66009c54078ab80e28 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28 FromStructure(RC_3c4405ea19e4fb66009c54078ab80e28 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3c4405ea19e4fb66009c54078ab80e28(s, config);
}

}


