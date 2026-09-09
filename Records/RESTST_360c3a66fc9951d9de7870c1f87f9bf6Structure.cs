using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidDateStruc
public class RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure : AbstractRESTStructure<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> {
[JsonProperty("IsValid")]
public bool? AttrIsValid;

[JsonProperty("Date")]
public String AttrDate;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

public RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure() { }

public RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsValid = ConvertToRestWithoutDefaults(s.ssIsValid, true);
AttrDate = ConvertDateToRestWithoutDefaults(s.ssDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrIsValid = (bool?) s.ssIsValid;
AttrDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDate);
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static ST_360c3a66fc9951d9de7870c1f87f9bf6Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure obj) { 
  ST_360c3a66fc9951d9de7870c1f87f9bf6Structure s = new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure();
  if(obj != null) {
  s.ssIsValid = obj.AttrIsValid == null ? true : obj.AttrIsValid.Value;
  s.ssDate = obj.AttrDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDate);
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure, ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_360c3a66fc9951d9de7870c1f87f9bf6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure FromStructure(ST_360c3a66fc9951d9de7870c1f87f9bf6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_360c3a66fc9951d9de7870c1f87f9bf6Structure(s, config);
}

}


