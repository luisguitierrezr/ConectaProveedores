using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Counter
public class JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure : AbstractRESTStructure<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> {
[JsonProperty("StatusLabel")]
[JsonPropertyName("StatusLabel")]
public string AttrStatusLabel;

[JsonProperty("Count")]
[JsonPropertyName("Count")]
public int? AttrCount;

public JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure() { }

public JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStatusLabel = ConvertToRestWithoutDefaults(s.ssStatusLabel, "");
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0);
  } else {
AttrStatusLabel = s.ssStatusLabel;
AttrCount = (int?) s.ssCount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure s) => ToStructure(s, config);
}
public static ST_bfed96b4bd29e9b06f0b06e901b1508bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure obj, IBehaviorsConfiguration config) { 
  ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s = new ST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
  if(obj != null) {
  s.ssStatusLabel = obj.AttrStatusLabel == null ? "" : obj.AttrStatusLabel;
  s.ssCount = obj.AttrCount == null ? 0 : obj.AttrCount.Value;
  }
  return s;
}

public static Func<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure, ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure FromStructure(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_bfed96b4bd29e9b06f0b06e901b1508bStructure(s, config);
}

}


