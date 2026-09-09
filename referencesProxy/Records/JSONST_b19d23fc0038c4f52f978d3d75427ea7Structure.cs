using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// T_DAT_PROV_In
public class JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure : AbstractRESTStructure<ST_b19d23fc0038c4f52f978d3d75427ea7Structure> {
[JsonProperty("LIFNR")]
[JsonPropertyName("LIFNR")]
public string AttrLIFNR;

[JsonProperty("NAME1")]
[JsonPropertyName("NAME1")]
public string AttrNAME1;

[JsonProperty("NAME2")]
[JsonPropertyName("NAME2")]
public string AttrNAME2;

public JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure() { }

public JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure (ST_b19d23fc0038c4f52f978d3d75427ea7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLIFNR = ConvertToRestWithoutDefaults(s.ssLIFNR, "");
AttrNAME1 = ConvertToRestWithoutDefaults(s.ssNAME1, "");
AttrNAME2 = ConvertToRestWithoutDefaults(s.ssNAME2, "");
  } else {
AttrLIFNR = s.ssLIFNR;
AttrNAME1 = s.ssNAME1;
AttrNAME2 = s.ssNAME2;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure, ST_b19d23fc0038c4f52f978d3d75427ea7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure s) => ToStructure(s, config);
}
public static ST_b19d23fc0038c4f52f978d3d75427ea7Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure obj, IBehaviorsConfiguration config) { 
  ST_b19d23fc0038c4f52f978d3d75427ea7Structure s = new ST_b19d23fc0038c4f52f978d3d75427ea7Structure();
  if(obj != null) {
  s.ssLIFNR = obj.AttrLIFNR == null ? "" : obj.AttrLIFNR;
  s.ssNAME1 = obj.AttrNAME1 == null ? "" : obj.AttrNAME1;
  s.ssNAME2 = obj.AttrNAME2 == null ? "" : obj.AttrNAME2;
  }
  return s;
}

public static Func<ST_b19d23fc0038c4f52f978d3d75427ea7Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b19d23fc0038c4f52f978d3d75427ea7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure FromStructure(ST_b19d23fc0038c4f52f978d3d75427ea7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b19d23fc0038c4f52f978d3d75427ea7Structure(s, config);
}

}


