using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerRangeOptionalConfigs
public class RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure : AbstractRESTStructure<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> {
[JsonProperty("InitialStartDate")]
public String AttrInitialStartDate;

[JsonProperty("InitialEndDate")]
public String AttrInitialEndDate;

[JsonProperty("MinDate")]
public String AttrMinDate;

[JsonProperty("MaxDate")]
public String AttrMaxDate;

[JsonProperty("FirstWeekDay")]
public int? AttrFirstWeekDay;

[JsonProperty("ShowWeekNumbers")]
public bool? AttrShowWeekNumbers;

public RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure() { }

public RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInitialStartDate = ConvertDateToRestWithoutDefaults(s.ssInitialStartDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrInitialEndDate = ConvertDateToRestWithoutDefaults(s.ssInitialEndDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMinDate = ConvertDateToRestWithoutDefaults(s.ssMinDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrMaxDate = ConvertDateToRestWithoutDefaults(s.ssMaxDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrFirstWeekDay = ConvertToRestWithoutDefaults(s.ssFirstWeekDay, RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerRangeOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay);
AttrShowWeekNumbers = ConvertToRestWithoutDefaults(s.ssShowWeekNumbers, false);
  } else {
AttrInitialStartDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssInitialStartDate);
AttrInitialEndDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssInitialEndDate);
AttrMinDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssMinDate);
AttrMaxDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssMaxDate);
AttrFirstWeekDay = (int?) s.ssFirstWeekDay;
AttrShowWeekNumbers = (bool?) s.ssShowWeekNumbers;
  }
}

public static ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure obj) { 
  ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure s = new ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure();
  if(obj != null) {
  s.ssInitialStartDate = obj.AttrInitialStartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInitialStartDate);
  s.ssInitialEndDate = obj.AttrInitialEndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInitialEndDate);
  s.ssMinDate = obj.AttrMinDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrMinDate);
  s.ssMaxDate = obj.AttrMaxDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrMaxDate);
  s.ssFirstWeekDay = obj.AttrFirstWeekDay == null ? RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerRangeOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay : obj.AttrFirstWeekDay.Value;
  s.ssShowWeekNumbers = obj.AttrShowWeekNumbers == null ? false : obj.AttrShowWeekNumbers.Value;
  }
  return s;
}

public static Func<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure, ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure FromStructure(ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure(s, config);
}

}


