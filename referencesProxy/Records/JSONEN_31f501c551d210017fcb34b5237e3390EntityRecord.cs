using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Region
public class JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord : AbstractRESTStructure<EN_31f501c551d210017fcb34b5237e3390EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Code")]
[JsonPropertyName("Code")]
public string AttrCode;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("DivisionFI")]
[JsonPropertyName("DivisionFI")]
public string AttrDivisionFI;

[JsonProperty("CentroRTP")]
[JsonPropertyName("CentroRTP")]
public string AttrCentroRTP;

[JsonProperty("CommissionRegion")]
[JsonPropertyName("CommissionRegion")]
public string AttrCommissionRegion;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("IsFsP")]
[JsonPropertyName("IsFsP")]
public bool? AttrIsFsP;

[JsonProperty("IsFcP")]
[JsonPropertyName("IsFcP")]
public bool? AttrIsFcP;

public JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord() { }

public JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord (EN_31f501c551d210017fcb34b5237e3390EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrName = s.ssName;
AttrDivisionFI = s.ssDivisionFI;
AttrCentroRTP = s.ssCentroRTP;
AttrCommissionRegion = ConvertToRestWithoutDefaults(s.ssCommissionRegion, "");
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrIsFsP = ConvertToRestWithoutDefaults(s.ssIsFsP, false);
AttrIsFcP = ConvertToRestWithoutDefaults(s.ssIsFcP, false);
  } else {
AttrId = (long?) s.ssId;
AttrCode = s.ssCode;
AttrName = s.ssName;
AttrDivisionFI = s.ssDivisionFI;
AttrCentroRTP = s.ssCentroRTP;
AttrCommissionRegion = s.ssCommissionRegion;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrIsFsP = (bool?) s.ssIsFsP;
AttrIsFcP = (bool?) s.ssIsFcP;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord, EN_31f501c551d210017fcb34b5237e3390EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord s) => ToStructure(s, config);
}
public static EN_31f501c551d210017fcb34b5237e3390EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_31f501c551d210017fcb34b5237e3390EntityRecord s = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDivisionFI = obj.AttrDivisionFI == null ? "" : obj.AttrDivisionFI;
  s.ssCentroRTP = obj.AttrCentroRTP == null ? "" : obj.AttrCentroRTP;
  s.ssCommissionRegion = obj.AttrCommissionRegion == null ? "" : obj.AttrCommissionRegion;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssIsFsP = obj.AttrIsFsP == null ? false : obj.AttrIsFsP.Value;
  s.ssIsFcP = obj.AttrIsFcP == null ? false : obj.AttrIsFcP.Value;
  }
  return s;
}

public static Func<EN_31f501c551d210017fcb34b5237e3390EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_31f501c551d210017fcb34b5237e3390EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord FromStructure(EN_31f501c551d210017fcb34b5237e3390EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord(s, config);
}

}


