using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationAccount
public class JSONST_1074864f28737110728a1225e98b6e34Structure : AbstractRESTStructure<ST_1074864f28737110728a1225e98b6e34Structure> {
[JsonProperty("CuentadeGasto")]
[JsonPropertyName("CuentadeGasto")]
public string AttrCuentadeGasto;

[JsonProperty("Desde")]
[JsonPropertyName("Desde")]
public string AttrDesde;

[JsonProperty("Hasta")]
[JsonPropertyName("Hasta")]
public string AttrHasta;

[JsonProperty("Space")]
[JsonPropertyName("Space")]
public string AttrSpace;

[JsonProperty("CuentadeGasto2")]
[JsonPropertyName("CuentadeGasto2")]
public string AttrCuentadeGasto2;

[JsonProperty("Desde2")]
[JsonPropertyName("Desde2")]
public string AttrDesde2;

[JsonProperty("Hasta2")]
[JsonPropertyName("Hasta2")]
public string AttrHasta2;

public JSONST_1074864f28737110728a1225e98b6e34Structure() { }

public JSONST_1074864f28737110728a1225e98b6e34Structure (ST_1074864f28737110728a1225e98b6e34Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCuentadeGasto = ConvertToRestWithoutDefaults(s.ssCuentadeGasto, "");
AttrDesde = ConvertToRestWithoutDefaults(s.ssDesde, "");
AttrHasta = ConvertToRestWithoutDefaults(s.ssHasta, "");
AttrSpace = ConvertToRestWithoutDefaults(s.ssSpace, "");
AttrCuentadeGasto2 = ConvertToRestWithoutDefaults(s.ssCuentadeGasto2, "");
AttrDesde2 = ConvertToRestWithoutDefaults(s.ssDesde2, "");
AttrHasta2 = ConvertToRestWithoutDefaults(s.ssHasta2, "");
  } else {
AttrCuentadeGasto = s.ssCuentadeGasto;
AttrDesde = s.ssDesde;
AttrHasta = s.ssHasta;
AttrSpace = s.ssSpace;
AttrCuentadeGasto2 = s.ssCuentadeGasto2;
AttrDesde2 = s.ssDesde2;
AttrHasta2 = s.ssHasta2;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure, ST_1074864f28737110728a1225e98b6e34Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure s) => ToStructure(s, config);
}
public static ST_1074864f28737110728a1225e98b6e34Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure obj, IBehaviorsConfiguration config) { 
  ST_1074864f28737110728a1225e98b6e34Structure s = new ST_1074864f28737110728a1225e98b6e34Structure();
  if(obj != null) {
  s.ssCuentadeGasto = obj.AttrCuentadeGasto == null ? "" : obj.AttrCuentadeGasto;
  s.ssDesde = obj.AttrDesde == null ? "" : obj.AttrDesde;
  s.ssHasta = obj.AttrHasta == null ? "" : obj.AttrHasta;
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssCuentadeGasto2 = obj.AttrCuentadeGasto2 == null ? "" : obj.AttrCuentadeGasto2;
  s.ssDesde2 = obj.AttrDesde2 == null ? "" : obj.AttrDesde2;
  s.ssHasta2 = obj.AttrHasta2 == null ? "" : obj.AttrHasta2;
  }
  return s;
}

public static Func<ST_1074864f28737110728a1225e98b6e34Structure, ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1074864f28737110728a1225e98b6e34Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure FromStructure(ST_1074864f28737110728a1225e98b6e34Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure(s, config);
}

}


