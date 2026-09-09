using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationContentStruct
public class JSONST_6ac87b97c676cd17082ba2063283d4baStructure : AbstractRESTStructure<ST_6ac87b97c676cd17082ba2063283d4baStructure> {
[JsonProperty("NrOfRecordsAffected")]
[JsonPropertyName("NrOfRecordsAffected")]
public int? AttrNrOfRecordsAffected;

[JsonProperty("Title")]
[JsonPropertyName("Title")]
public string AttrTitle;

[JsonProperty("NrOfRecordsSuccessful")]
[JsonPropertyName("NrOfRecordsSuccessful")]
public int? AttrNrOfRecordsSuccessful;

[JsonProperty("NrOfRecordsUnsuccessful")]
[JsonPropertyName("NrOfRecordsUnsuccessful")]
public int? AttrNrOfRecordsUnsuccessful;

public JSONST_6ac87b97c676cd17082ba2063283d4baStructure() { }

public JSONST_6ac87b97c676cd17082ba2063283d4baStructure (ST_6ac87b97c676cd17082ba2063283d4baStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNrOfRecordsAffected = ConvertToRestWithoutDefaults(s.ssNrOfRecordsAffected, 0);
AttrTitle = ConvertToRestWithoutDefaults(s.ssTitle, "");
AttrNrOfRecordsSuccessful = ConvertToRestWithoutDefaults(s.ssNrOfRecordsSuccessful, 0);
AttrNrOfRecordsUnsuccessful = ConvertToRestWithoutDefaults(s.ssNrOfRecordsUnsuccessful, 0);
  } else {
AttrNrOfRecordsAffected = (int?) s.ssNrOfRecordsAffected;
AttrTitle = s.ssTitle;
AttrNrOfRecordsSuccessful = (int?) s.ssNrOfRecordsSuccessful;
AttrNrOfRecordsUnsuccessful = (int?) s.ssNrOfRecordsUnsuccessful;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure, ST_6ac87b97c676cd17082ba2063283d4baStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure s) => ToStructure(s, config);
}
public static ST_6ac87b97c676cd17082ba2063283d4baStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure obj, IBehaviorsConfiguration config) { 
  ST_6ac87b97c676cd17082ba2063283d4baStructure s = new ST_6ac87b97c676cd17082ba2063283d4baStructure();
  if(obj != null) {
  s.ssNrOfRecordsAffected = obj.AttrNrOfRecordsAffected == null ? 0 : obj.AttrNrOfRecordsAffected.Value;
  s.ssTitle = obj.AttrTitle == null ? "" : obj.AttrTitle;
  s.ssNrOfRecordsSuccessful = obj.AttrNrOfRecordsSuccessful == null ? 0 : obj.AttrNrOfRecordsSuccessful.Value;
  s.ssNrOfRecordsUnsuccessful = obj.AttrNrOfRecordsUnsuccessful == null ? 0 : obj.AttrNrOfRecordsUnsuccessful.Value;
  }
  return s;
}

public static Func<ST_6ac87b97c676cd17082ba2063283d4baStructure, ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6ac87b97c676cd17082ba2063283d4baStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure FromStructure(ST_6ac87b97c676cd17082ba2063283d4baStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6ac87b97c676cd17082ba2063283d4baStructure(s, config);
}

}


