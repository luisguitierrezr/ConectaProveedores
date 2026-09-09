using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CustomSettingValue
public class RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord : AbstractRESTStructure<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("CustomSettingId")]
public int? AttrCustomSettingId;

[JsonProperty("Value")]
public string AttrValue;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord() { }

public RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCustomSettingId = ConvertToRestWithoutDefaults(s.ssCustomSettingId, 0);
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrCustomSettingId = (int?) s.ssCustomSettingId;
AttrValue = s.ssValue;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord obj) { 
  EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord s = new EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCustomSettingId = obj.AttrCustomSettingId == null ? 0 : obj.AttrCustomSettingId.Value;
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord, ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord FromStructure(EN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_ed4c8de87f39a0c4c5e65b9db53df136EntityRecord(s, config);
}

}


