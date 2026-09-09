using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Counter
public class RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure : AbstractRESTStructure<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> {
[JsonProperty("StatusLabel")]
public string AttrStatusLabel;

[JsonProperty("Count")]
public int? AttrCount;

public RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure() { }

public RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStatusLabel = ConvertToRestWithoutDefaults(s.ssStatusLabel, "");
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0);
  } else {
AttrStatusLabel = s.ssStatusLabel;
AttrCount = (int?) s.ssCount;
  }
}

public static ST_bfed96b4bd29e9b06f0b06e901b1508bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure obj) { 
  ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s = new ST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
  if(obj != null) {
  s.ssStatusLabel = obj.AttrStatusLabel == null ? "" : obj.AttrStatusLabel;
  s.ssCount = obj.AttrCount == null ? 0 : obj.AttrCount.Value;
  }
  return s;
}

public static Func<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure, ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure FromStructure(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_bfed96b4bd29e9b06f0b06e901b1508bStructure(s, config);
}

}


