using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BusinessValueSubcategory
public class RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord : AbstractRESTStructure<EN_f296fc330d9916f9de4aae18321e8388EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("CategoryId")]
public long? AttrCategoryId;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord() { }

public RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord (EN_f296fc330d9916f9de4aae18321e8388EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCategoryId = ConvertToRestWithoutDefaults(s.ssCategoryId, 0L);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescription = s.ssDescription;
AttrCategoryId = (long?) s.ssCategoryId;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_f296fc330d9916f9de4aae18321e8388EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord obj) { 
  EN_f296fc330d9916f9de4aae18321e8388EntityRecord s = new EN_f296fc330d9916f9de4aae18321e8388EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCategoryId = obj.AttrCategoryId == null ? 0L : obj.AttrCategoryId.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_f296fc330d9916f9de4aae18321e8388EntityRecord, ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f296fc330d9916f9de4aae18321e8388EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord FromStructure(EN_f296fc330d9916f9de4aae18321e8388EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord(s, config);
}

}


