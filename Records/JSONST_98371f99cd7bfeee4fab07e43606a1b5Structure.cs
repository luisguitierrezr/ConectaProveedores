using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TimeZoneRecord
public class JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure : AbstractRESTStructure<ST_98371f99cd7bfeee4fab07e43606a1b5Structure> {
[JsonProperty("Identifier")]
[JsonPropertyName("Identifier")]
public string AttrIdentifier;

[JsonProperty("StandardName")]
[JsonPropertyName("StandardName")]
public string AttrStandardName;

[JsonProperty("DisplayName")]
[JsonPropertyName("DisplayName")]
public string AttrDisplayName;

[JsonProperty("UtcOffset")]
[JsonPropertyName("UtcOffset")]
public int? AttrUtcOffset;

[JsonProperty("SupportsDaylightSaving")]
[JsonPropertyName("SupportsDaylightSaving")]
public bool? AttrSupportsDaylightSaving;

[JsonProperty("IsDaylightSaving")]
[JsonPropertyName("IsDaylightSaving")]
public bool? AttrIsDaylightSaving;

public JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure() { }

public JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure (ST_98371f99cd7bfeee4fab07e43606a1b5Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIdentifier = ConvertToRestWithoutDefaults(s.ssIdentifier, "");
AttrStandardName = ConvertToRestWithoutDefaults(s.ssStandardName, "");
AttrDisplayName = ConvertToRestWithoutDefaults(s.ssDisplayName, "");
AttrUtcOffset = ConvertToRestWithoutDefaults(s.ssUtcOffset, 0);
AttrSupportsDaylightSaving = ConvertToRestWithoutDefaults(s.ssSupportsDaylightSaving, false);
AttrIsDaylightSaving = ConvertToRestWithoutDefaults(s.ssIsDaylightSaving, false);
  } else {
AttrIdentifier = s.ssIdentifier;
AttrStandardName = s.ssStandardName;
AttrDisplayName = s.ssDisplayName;
AttrUtcOffset = (int?) s.ssUtcOffset;
AttrSupportsDaylightSaving = (bool?) s.ssSupportsDaylightSaving;
AttrIsDaylightSaving = (bool?) s.ssIsDaylightSaving;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure, ST_98371f99cd7bfeee4fab07e43606a1b5Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure s) => ToStructure(s, config);
}
public static ST_98371f99cd7bfeee4fab07e43606a1b5Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure obj, IBehaviorsConfiguration config) { 
  ST_98371f99cd7bfeee4fab07e43606a1b5Structure s = new ST_98371f99cd7bfeee4fab07e43606a1b5Structure();
  if(obj != null) {
  s.ssIdentifier = obj.AttrIdentifier == null ? "" : obj.AttrIdentifier;
  s.ssStandardName = obj.AttrStandardName == null ? "" : obj.AttrStandardName;
  s.ssDisplayName = obj.AttrDisplayName == null ? "" : obj.AttrDisplayName;
  s.ssUtcOffset = obj.AttrUtcOffset == null ? 0 : obj.AttrUtcOffset.Value;
  s.ssSupportsDaylightSaving = obj.AttrSupportsDaylightSaving == null ? false : obj.AttrSupportsDaylightSaving.Value;
  s.ssIsDaylightSaving = obj.AttrIsDaylightSaving == null ? false : obj.AttrIsDaylightSaving.Value;
  }
  return s;
}

public static Func<ST_98371f99cd7bfeee4fab07e43606a1b5Structure, ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_98371f99cd7bfeee4fab07e43606a1b5Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure FromStructure(ST_98371f99cd7bfeee4fab07e43606a1b5Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_98371f99cd7bfeee4fab07e43606a1b5Structure(s, config);
}

}


