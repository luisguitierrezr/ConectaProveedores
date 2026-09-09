using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationPeriod
public class JSONST_3071806a59ac2d49d464c40254dbb5f2Structure : AbstractRESTStructure<ST_3071806a59ac2d49d464c40254dbb5f2Structure> {
[JsonProperty("Space")]
[JsonPropertyName("Space")]
public string AttrSpace;

[JsonProperty("Desde")]
[JsonPropertyName("Desde")]
public string AttrDesde;

[JsonProperty("Hasta")]
[JsonPropertyName("Hasta")]
public string AttrHasta;

[JsonProperty("Space2")]
[JsonPropertyName("Space2")]
public string AttrSpace2;

[JsonProperty("Desde2")]
[JsonPropertyName("Desde2")]
public string AttrDesde2;

[JsonProperty("Hasta2")]
[JsonPropertyName("Hasta2")]
public string AttrHasta2;

public JSONST_3071806a59ac2d49d464c40254dbb5f2Structure() { }

public JSONST_3071806a59ac2d49d464c40254dbb5f2Structure (ST_3071806a59ac2d49d464c40254dbb5f2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpace = ConvertToRestWithoutDefaults(s.ssSpace, "");
AttrDesde = ConvertToRestWithoutDefaults(s.ssDesde, "");
AttrHasta = ConvertToRestWithoutDefaults(s.ssHasta, "");
AttrSpace2 = ConvertToRestWithoutDefaults(s.ssSpace2, "");
AttrDesde2 = ConvertToRestWithoutDefaults(s.ssDesde2, "");
AttrHasta2 = ConvertToRestWithoutDefaults(s.ssHasta2, "");
  } else {
AttrSpace = s.ssSpace;
AttrDesde = s.ssDesde;
AttrHasta = s.ssHasta;
AttrSpace2 = s.ssSpace2;
AttrDesde2 = s.ssDesde2;
AttrHasta2 = s.ssHasta2;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure, ST_3071806a59ac2d49d464c40254dbb5f2Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure s) => ToStructure(s, config);
}
public static ST_3071806a59ac2d49d464c40254dbb5f2Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure obj, IBehaviorsConfiguration config) { 
  ST_3071806a59ac2d49d464c40254dbb5f2Structure s = new ST_3071806a59ac2d49d464c40254dbb5f2Structure();
  if(obj != null) {
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssDesde = obj.AttrDesde == null ? "" : obj.AttrDesde;
  s.ssHasta = obj.AttrHasta == null ? "" : obj.AttrHasta;
  s.ssSpace2 = obj.AttrSpace2 == null ? "" : obj.AttrSpace2;
  s.ssDesde2 = obj.AttrDesde2 == null ? "" : obj.AttrDesde2;
  s.ssHasta2 = obj.AttrHasta2 == null ? "" : obj.AttrHasta2;
  }
  return s;
}

public static Func<ST_3071806a59ac2d49d464c40254dbb5f2Structure, ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3071806a59ac2d49d464c40254dbb5f2Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure FromStructure(ST_3071806a59ac2d49d464c40254dbb5f2Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure(s, config);
}

}


