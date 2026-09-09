using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantTelcelDirection
public class RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord : AbstractRESTStructure<EN_b4df52993ebe05898d08c65589336b17EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ApplicantId")]
public long? AttrApplicantId;

[JsonProperty("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord() { }

public RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord (EN_b4df52993ebe05898d08c65589336b17EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrApplicantId = ConvertToRestWithoutDefaults(s.ssApplicantId, 0L);
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrApplicantId = (long?) s.ssApplicantId;
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_b4df52993ebe05898d08c65589336b17EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord obj) { 
  EN_b4df52993ebe05898d08c65589336b17EntityRecord s = new EN_b4df52993ebe05898d08c65589336b17EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssApplicantId = obj.AttrApplicantId == null ? 0L : obj.AttrApplicantId.Value;
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_b4df52993ebe05898d08c65589336b17EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b4df52993ebe05898d08c65589336b17EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord FromStructure(EN_b4df52993ebe05898d08c65589336b17EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord(s, config);
}

}


