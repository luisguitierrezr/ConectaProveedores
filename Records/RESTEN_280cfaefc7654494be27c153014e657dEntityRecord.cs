using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessTypeDatesAllowed
public class RESTEN_280cfaefc7654494be27c153014e657dEntityRecord : AbstractRESTStructure<EN_280cfaefc7654494be27c153014e657dEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessTypeCode")]
public string AttrProcessTypeCode;

[JsonProperty("DayOfWeekId")]
public int? AttrDayOfWeekId;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_280cfaefc7654494be27c153014e657dEntityRecord() { }

public RESTEN_280cfaefc7654494be27c153014e657dEntityRecord (EN_280cfaefc7654494be27c153014e657dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessTypeCode = ConvertToRestWithoutDefaults(s.ssProcessTypeCode, "");
AttrDayOfWeekId = ConvertToRestWithoutDefaults(s.ssDayOfWeekId, 0);
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrProcessTypeCode = s.ssProcessTypeCode;
AttrDayOfWeekId = (int?) s.ssDayOfWeekId;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_280cfaefc7654494be27c153014e657dEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord obj) { 
  EN_280cfaefc7654494be27c153014e657dEntityRecord s = new EN_280cfaefc7654494be27c153014e657dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssDayOfWeekId = obj.AttrDayOfWeekId == null ? 0 : obj.AttrDayOfWeekId.Value;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_280cfaefc7654494be27c153014e657dEntityRecord, ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_280cfaefc7654494be27c153014e657dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord FromStructure(EN_280cfaefc7654494be27c153014e657dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord(s, config);
}

}


