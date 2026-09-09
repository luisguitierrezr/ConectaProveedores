using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HomepageKPI
public class RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure : AbstractRESTStructure<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> {
[JsonProperty("Count")]
public int? AttrCount;

[JsonProperty("Label")]
public string AttrLabel;

public RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure() { }

public RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0);
AttrLabel = ConvertToRestWithoutDefaults(s.ssLabel, "");
  } else {
AttrCount = (int?) s.ssCount;
AttrLabel = s.ssLabel;
  }
}

public static ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure obj) { 
  ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure s = new ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure();
  if(obj != null) {
  s.ssCount = obj.AttrCount == null ? 0 : obj.AttrCount.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure, ssConectaProveedores.RestRecords.RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure FromStructure(ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure(s, config);
}

}


