using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportAuthorization
public class JSONST_2667ad63792f2349dc9e4a818559d9ecStructure : AbstractRESTStructure<ST_2667ad63792f2349dc9e4a818559d9ecStructure> {
[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Field")]
[JsonPropertyName("Field")]
public string AttrField;

[JsonProperty("Date")]
[JsonPropertyName("Date")]
public string AttrDate;

[JsonProperty("Hour")]
[JsonPropertyName("Hour")]
public string AttrHour;

public JSONST_2667ad63792f2349dc9e4a818559d9ecStructure() { }

public JSONST_2667ad63792f2349dc9e4a818559d9ecStructure (ST_2667ad63792f2349dc9e4a818559d9ecStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrField = ConvertToRestWithoutDefaults(s.ssField, "");
AttrDate = ConvertToRestWithoutDefaults(s.ssDate, "");
AttrHour = ConvertToRestWithoutDefaults(s.ssHour, "");
  } else {
AttrName = s.ssName;
AttrField = s.ssField;
AttrDate = s.ssDate;
AttrHour = s.ssHour;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure, ST_2667ad63792f2349dc9e4a818559d9ecStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure s) => ToStructure(s, config);
}
public static ST_2667ad63792f2349dc9e4a818559d9ecStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure obj, IBehaviorsConfiguration config) { 
  ST_2667ad63792f2349dc9e4a818559d9ecStructure s = new ST_2667ad63792f2349dc9e4a818559d9ecStructure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssField = obj.AttrField == null ? "" : obj.AttrField;
  s.ssDate = obj.AttrDate == null ? "" : obj.AttrDate;
  s.ssHour = obj.AttrHour == null ? "" : obj.AttrHour;
  }
  return s;
}

public static Func<ST_2667ad63792f2349dc9e4a818559d9ecStructure, ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_2667ad63792f2349dc9e4a818559d9ecStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure FromStructure(ST_2667ad63792f2349dc9e4a818559d9ecStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure(s, config);
}

}


