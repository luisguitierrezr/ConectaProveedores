using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerOptionalConfigs
public class RESTST_bc4abb4233d9ce894e855c520a20c76fStructure : AbstractRESTStructure<ST_bc4abb4233d9ce894e855c520a20c76fStructure> {
[JsonProperty("InitialDate")]
public String AttrInitialDate;

[JsonProperty("MinDate")]
public String AttrMinDate;

[JsonProperty("MaxDate")]
public String AttrMaxDate;

[JsonProperty("FirstWeekDay")]
public int? AttrFirstWeekDay;

[JsonProperty("ShowWeekNumbers")]
public bool? AttrShowWeekNumbers;

public RESTST_bc4abb4233d9ce894e855c520a20c76fStructure() { }

public RESTST_bc4abb4233d9ce894e855c520a20c76fStructure (ST_bc4abb4233d9ce894e855c520a20c76fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInitialDate = ConvertDateTimeToRestWithoutDefaults(s.ssInitialDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMinDate = ConvertDateTimeToRestWithoutDefaults(s.ssMinDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrMaxDate = ConvertDateTimeToRestWithoutDefaults(s.ssMaxDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFirstWeekDay = ConvertToRestWithoutDefaults(s.ssFirstWeekDay, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay);
AttrShowWeekNumbers = ConvertToRestWithoutDefaults(s.ssShowWeekNumbers, false);
  } else {
AttrInitialDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssInitialDate, config.DateTimeFormat);
AttrMinDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMinDate, config.DateTimeFormat);
AttrMaxDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssMaxDate, config.DateTimeFormat);
AttrFirstWeekDay = (int?) s.ssFirstWeekDay;
AttrShowWeekNumbers = (bool?) s.ssShowWeekNumbers;
  }
}

public static ST_bc4abb4233d9ce894e855c520a20c76fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure obj) { 
  ST_bc4abb4233d9ce894e855c520a20c76fStructure s = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
  if(obj != null) {
  s.ssInitialDate = obj.AttrInitialDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrInitialDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMinDate = obj.AttrMinDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMinDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssMaxDate = obj.AttrMaxDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrMaxDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssFirstWeekDay = obj.AttrFirstWeekDay == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay : obj.AttrFirstWeekDay.Value;
  s.ssShowWeekNumbers = obj.AttrShowWeekNumbers == null ? false : obj.AttrShowWeekNumbers.Value;
  }
  return s;
}

public static Func<ST_bc4abb4233d9ce894e855c520a20c76fStructure, ssConectaProveedores.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bc4abb4233d9ce894e855c520a20c76fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure FromStructure(ST_bc4abb4233d9ce894e855c520a20c76fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_bc4abb4233d9ce894e855c520a20c76fStructure(s, config);
}

}


