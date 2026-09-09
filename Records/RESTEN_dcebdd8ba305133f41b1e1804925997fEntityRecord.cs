using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileExtended
public class RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord : AbstractRESTStructure<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Filename")]
public string AttrFilename;

[JsonProperty("IsProcessed")]
public bool? AttrIsProcessed;

[JsonProperty("HasError")]
public bool? AttrHasError;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

[JsonProperty("UploadedBy")]
public string AttrUploadedBy;

[JsonProperty("UploadedOn")]
public String AttrUploadedOn;

public RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord() { }

public RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrIsProcessed = ConvertToRestWithoutDefaults(s.ssIsProcessed, false);
AttrHasError = ConvertToRestWithoutDefaults(s.ssHasError, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
AttrUploadedBy = ConvertToRestWithoutDefaults(s.ssUploadedBy, "");
AttrUploadedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUploadedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrFilename = s.ssFilename;
AttrIsProcessed = (bool?) s.ssIsProcessed;
AttrHasError = (bool?) s.ssHasError;
AttrErrorMessage = s.ssErrorMessage;
AttrUploadedBy = s.ssUploadedBy;
AttrUploadedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUploadedOn, config.DateTimeFormat);
  }
}

public static EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord obj) { 
  EN_dcebdd8ba305133f41b1e1804925997fEntityRecord s = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssIsProcessed = obj.AttrIsProcessed == null ? false : obj.AttrIsProcessed.Value;
  s.ssHasError = obj.AttrHasError == null ? false : obj.AttrHasError.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  s.ssUploadedBy = obj.AttrUploadedBy == null ? "" : obj.AttrUploadedBy;
  s.ssUploadedOn = obj.AttrUploadedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUploadedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_dcebdd8ba305133f41b1e1804925997fEntityRecord, ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord FromStructure(EN_dcebdd8ba305133f41b1e1804925997fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord(s, config);
}

}


