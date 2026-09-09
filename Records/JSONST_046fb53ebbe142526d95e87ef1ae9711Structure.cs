using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Output
public class JSONST_046fb53ebbe142526d95e87ef1ae9711Structure : AbstractRESTStructure<ST_046fb53ebbe142526d95e87ef1ae9711Structure> {
[JsonProperty("IsSuccess")]
[JsonPropertyName("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

[JsonProperty("Lines")]
[JsonPropertyName("Lines")]
public int? AttrLines;

public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure() { }

public JSONST_046fb53ebbe142526d95e87ef1ae9711Structure (ST_046fb53ebbe142526d95e87ef1ae9711Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrLines = ConvertToRestWithoutDefaults(s.ssLines, 0);
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrMessage = s.ssMessage;
AttrLines = (int?) s.ssLines;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure, ST_046fb53ebbe142526d95e87ef1ae9711Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure s) => ToStructure(s, config);
}
public static ST_046fb53ebbe142526d95e87ef1ae9711Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure obj, IBehaviorsConfiguration config) { 
  ST_046fb53ebbe142526d95e87ef1ae9711Structure s = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssLines = obj.AttrLines == null ? 0 : obj.AttrLines.Value;
  }
  return s;
}

public static Func<ST_046fb53ebbe142526d95e87ef1ae9711Structure, ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_046fb53ebbe142526d95e87ef1ae9711Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure FromStructure(ST_046fb53ebbe142526d95e87ef1ae9711Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure(s, config);
}

}


