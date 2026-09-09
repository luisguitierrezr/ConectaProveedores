using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationSupplier
public class JSONST_c1e66f019db37ad740f84fa58db915f9Structure : AbstractRESTStructure<ST_c1e66f019db37ad740f84fa58db915f9Structure> {
[JsonProperty("NumerodeProveedor")]
[JsonPropertyName("NumerodeProveedor")]
public string AttrNumerodeProveedor;

[JsonProperty("NombreoRazonSocial")]
[JsonPropertyName("NombreoRazonSocial")]
public string AttrNombreoRazonSocial;

[JsonProperty("Desde")]
[JsonPropertyName("Desde")]
public string AttrDesde;

[JsonProperty("Hasta")]
[JsonPropertyName("Hasta")]
public string AttrHasta;

[JsonProperty("Space")]
[JsonPropertyName("Space")]
public string AttrSpace;

[JsonProperty("NumerodeProveedor2")]
[JsonPropertyName("NumerodeProveedor2")]
public string AttrNumerodeProveedor2;

[JsonProperty("NombreoRazonSocial2")]
[JsonPropertyName("NombreoRazonSocial2")]
public string AttrNombreoRazonSocial2;

[JsonProperty("Desde2")]
[JsonPropertyName("Desde2")]
public string AttrDesde2;

[JsonProperty("Hasta2")]
[JsonPropertyName("Hasta2")]
public string AttrHasta2;

public JSONST_c1e66f019db37ad740f84fa58db915f9Structure() { }

public JSONST_c1e66f019db37ad740f84fa58db915f9Structure (ST_c1e66f019db37ad740f84fa58db915f9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrNumerodeProveedor = ConvertToRestWithoutDefaults(s.ssNumerodeProveedor, "");
AttrNombreoRazonSocial = ConvertToRestWithoutDefaults(s.ssNombreoRazonSocial, "");
AttrDesde = ConvertToRestWithoutDefaults(s.ssDesde, "");
AttrHasta = ConvertToRestWithoutDefaults(s.ssHasta, "");
AttrSpace = ConvertToRestWithoutDefaults(s.ssSpace, "");
AttrNumerodeProveedor2 = ConvertToRestWithoutDefaults(s.ssNumerodeProveedor2, "");
AttrNombreoRazonSocial2 = ConvertToRestWithoutDefaults(s.ssNombreoRazonSocial2, "");
AttrDesde2 = ConvertToRestWithoutDefaults(s.ssDesde2, "");
AttrHasta2 = ConvertToRestWithoutDefaults(s.ssHasta2, "");
  } else {
AttrNumerodeProveedor = s.ssNumerodeProveedor;
AttrNombreoRazonSocial = s.ssNombreoRazonSocial;
AttrDesde = s.ssDesde;
AttrHasta = s.ssHasta;
AttrSpace = s.ssSpace;
AttrNumerodeProveedor2 = s.ssNumerodeProveedor2;
AttrNombreoRazonSocial2 = s.ssNombreoRazonSocial2;
AttrDesde2 = s.ssDesde2;
AttrHasta2 = s.ssHasta2;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure, ST_c1e66f019db37ad740f84fa58db915f9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure s) => ToStructure(s, config);
}
public static ST_c1e66f019db37ad740f84fa58db915f9Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure obj, IBehaviorsConfiguration config) { 
  ST_c1e66f019db37ad740f84fa58db915f9Structure s = new ST_c1e66f019db37ad740f84fa58db915f9Structure();
  if(obj != null) {
  s.ssNumerodeProveedor = obj.AttrNumerodeProveedor == null ? "" : obj.AttrNumerodeProveedor;
  s.ssNombreoRazonSocial = obj.AttrNombreoRazonSocial == null ? "" : obj.AttrNombreoRazonSocial;
  s.ssDesde = obj.AttrDesde == null ? "" : obj.AttrDesde;
  s.ssHasta = obj.AttrHasta == null ? "" : obj.AttrHasta;
  s.ssSpace = obj.AttrSpace == null ? "" : obj.AttrSpace;
  s.ssNumerodeProveedor2 = obj.AttrNumerodeProveedor2 == null ? "" : obj.AttrNumerodeProveedor2;
  s.ssNombreoRazonSocial2 = obj.AttrNombreoRazonSocial2 == null ? "" : obj.AttrNombreoRazonSocial2;
  s.ssDesde2 = obj.AttrDesde2 == null ? "" : obj.AttrDesde2;
  s.ssHasta2 = obj.AttrHasta2 == null ? "" : obj.AttrHasta2;
  }
  return s;
}

public static Func<ST_c1e66f019db37ad740f84fa58db915f9Structure, ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c1e66f019db37ad740f84fa58db915f9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure FromStructure(ST_c1e66f019db37ad740f84fa58db915f9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_c1e66f019db37ad740f84fa58db915f9Structure(s, config);
}

}


