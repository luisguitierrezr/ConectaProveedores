using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFile
public class JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord : AbstractRESTStructure<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("NeedsApproval")]
[JsonPropertyName("NeedsApproval")]
public bool? AttrNeedsApproval;

[JsonProperty("IsApproved")]
[JsonPropertyName("IsApproved")]
public bool? AttrIsApproved;

[JsonProperty("IsRejected")]
[JsonPropertyName("IsRejected")]
public bool? AttrIsRejected;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("OrderAccConceptId")]
[JsonPropertyName("OrderAccConceptId")]
public long? AttrOrderAccConceptId;

[JsonProperty("IsFinancialFile")]
[JsonPropertyName("IsFinancialFile")]
public bool? AttrIsFinancialFile;

[JsonProperty("OrderContractFile")]
[JsonPropertyName("OrderContractFile")]
public long? AttrOrderContractFile;

[JsonProperty("NeedAccounting")]
[JsonPropertyName("NeedAccounting")]
public bool? AttrNeedAccounting;

public JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord() { }

public JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrNeedsApproval = ConvertToRestWithoutDefaults(s.ssNeedsApproval, false);
AttrIsApproved = ConvertToRestWithoutDefaults(s.ssIsApproved, false);
AttrIsRejected = ConvertToRestWithoutDefaults(s.ssIsRejected, false);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrOrderAccConceptId = ConvertToRestWithoutDefaults(s.ssOrderAccConceptId, 0L);
AttrIsFinancialFile = ConvertToRestWithoutDefaults(s.ssIsFinancialFile, false);
AttrOrderContractFile = ConvertToRestWithoutDefaults(s.ssOrderContractFile, 0L);
AttrNeedAccounting = ConvertToRestWithoutDefaults(s.ssNeedAccounting, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrFilename = s.ssFilename;
AttrStorageId = (long?) s.ssStorageId;
AttrDescription = s.ssDescription;
AttrNeedsApproval = (bool?) s.ssNeedsApproval;
AttrIsApproved = (bool?) s.ssIsApproved;
AttrIsRejected = (bool?) s.ssIsRejected;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrOrderAccConceptId = (long?) s.ssOrderAccConceptId;
AttrIsFinancialFile = (bool?) s.ssIsFinancialFile;
AttrOrderContractFile = (long?) s.ssOrderContractFile;
AttrNeedAccounting = (bool?) s.ssNeedAccounting;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord, EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord s) => ToStructure(s, config);
}
public static EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord s = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssNeedsApproval = obj.AttrNeedsApproval == null ? false : obj.AttrNeedsApproval.Value;
  s.ssIsApproved = obj.AttrIsApproved == null ? false : obj.AttrIsApproved.Value;
  s.ssIsRejected = obj.AttrIsRejected == null ? false : obj.AttrIsRejected.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssOrderAccConceptId = obj.AttrOrderAccConceptId == null ? 0L : obj.AttrOrderAccConceptId.Value;
  s.ssIsFinancialFile = obj.AttrIsFinancialFile == null ? false : obj.AttrIsFinancialFile.Value;
  s.ssOrderContractFile = obj.AttrOrderContractFile == null ? 0L : obj.AttrOrderContractFile.Value;
  s.ssNeedAccounting = obj.AttrNeedAccounting == null ? false : obj.AttrNeedAccounting.Value;
  }
  return s;
}

public static Func<EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord, ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord FromStructure(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(s, config);
}

}


