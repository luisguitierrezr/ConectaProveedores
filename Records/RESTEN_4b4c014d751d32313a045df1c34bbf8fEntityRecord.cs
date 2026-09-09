using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceUsage
public class RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord : AbstractRESTStructure<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("IsAppliedToObjectivePerson")]
public bool? AttrIsAppliedToObjectivePerson;

[JsonProperty("IsAppliedToMoralPerson")]
public bool? AttrIsAppliedToMoralPerson;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord() { }

public RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsAppliedToObjectivePerson = ConvertToRestWithoutDefaults(s.ssIsAppliedToObjectivePerson, false);
AttrIsAppliedToMoralPerson = ConvertToRestWithoutDefaults(s.ssIsAppliedToMoralPerson, false);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrKey = s.ssKey;
AttrDescription = s.ssDescription;
AttrIsAppliedToObjectivePerson = (bool?) s.ssIsAppliedToObjectivePerson;
AttrIsAppliedToMoralPerson = (bool?) s.ssIsAppliedToMoralPerson;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord obj) { 
  EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord s = new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsAppliedToObjectivePerson = obj.AttrIsAppliedToObjectivePerson == null ? false : obj.AttrIsAppliedToObjectivePerson.Value;
  s.ssIsAppliedToMoralPerson = obj.AttrIsAppliedToMoralPerson == null ? false : obj.AttrIsAppliedToMoralPerson.Value;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord, ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord FromStructure(EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord(s, config);
}

}


