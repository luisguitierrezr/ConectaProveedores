using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioObservations
public class RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord : AbstractRESTStructure<EN_171b22187ea6e4b12c9f086502740307EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("FolioId")]
public long? AttrFolioId;

[JsonProperty("Observation")]
public string AttrObservation;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

public RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord() { }

public RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord (EN_171b22187ea6e4b12c9f086502740307EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrObservation = ConvertToRestWithoutDefaults(s.ssObservation, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrFolioId = (long?) s.ssFolioId;
AttrObservation = s.ssObservation;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static EN_171b22187ea6e4b12c9f086502740307EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord obj) { 
  EN_171b22187ea6e4b12c9f086502740307EntityRecord s = new EN_171b22187ea6e4b12c9f086502740307EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssObservation = obj.AttrObservation == null ? "" : obj.AttrObservation;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_171b22187ea6e4b12c9f086502740307EntityRecord, ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_171b22187ea6e4b12c9f086502740307EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord FromStructure(EN_171b22187ea6e4b12c9f086502740307EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord(s, config);
}

}


