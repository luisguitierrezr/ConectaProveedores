using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedCartaPorte
public class JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord : AbstractRESTStructure<EN_9bd576a05df3846c52ce88a606aff414EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Descripcion")]
[JsonPropertyName("Descripcion")]
public string AttrDescripcion;

[JsonProperty("ValorMercancia")]
[JsonPropertyName("ValorMercancia")]
public decimal? AttrValorMercancia;

[JsonProperty("CentroAtencion")]
[JsonPropertyName("CentroAtencion")]
public string AttrCentroAtencion;

[JsonProperty("Calle")]
[JsonPropertyName("Calle")]
public string AttrCalle;

[JsonProperty("NumeroExterior")]
[JsonPropertyName("NumeroExterior")]
public string AttrNumeroExterior;

[JsonProperty("CodigoPostal")]
[JsonPropertyName("CodigoPostal")]
public string AttrCodigoPostal;

public JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord() { }

public JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord (EN_9bd576a05df3846c52ce88a606aff414EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrDescripcion = ConvertToRestWithoutDefaults(s.ssDescripcion, "");
AttrValorMercancia = ConvertToRestWithoutDefaults(s.ssValorMercancia, 0.0M);
AttrCentroAtencion = ConvertToRestWithoutDefaults(s.ssCentroAtencion, "");
AttrCalle = ConvertToRestWithoutDefaults(s.ssCalle, "");
AttrNumeroExterior = ConvertToRestWithoutDefaults(s.ssNumeroExterior, "");
AttrCodigoPostal = ConvertToRestWithoutDefaults(s.ssCodigoPostal, "");
  } else {
AttrId = (long?) s.ssId;
AttrDescripcion = s.ssDescripcion;
AttrValorMercancia = (decimal?) s.ssValorMercancia;
AttrCentroAtencion = s.ssCentroAtencion;
AttrCalle = s.ssCalle;
AttrNumeroExterior = s.ssNumeroExterior;
AttrCodigoPostal = s.ssCodigoPostal;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord, EN_9bd576a05df3846c52ce88a606aff414EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord s) => ToStructure(s, config);
}
public static EN_9bd576a05df3846c52ce88a606aff414EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9bd576a05df3846c52ce88a606aff414EntityRecord s = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssDescripcion = obj.AttrDescripcion == null ? "" : obj.AttrDescripcion;
  s.ssValorMercancia = obj.AttrValorMercancia == null ? 0.0M : obj.AttrValorMercancia.Value;
  s.ssCentroAtencion = obj.AttrCentroAtencion == null ? "" : obj.AttrCentroAtencion;
  s.ssCalle = obj.AttrCalle == null ? "" : obj.AttrCalle;
  s.ssNumeroExterior = obj.AttrNumeroExterior == null ? "" : obj.AttrNumeroExterior;
  s.ssCodigoPostal = obj.AttrCodigoPostal == null ? "" : obj.AttrCodigoPostal;
  }
  return s;
}

public static Func<EN_9bd576a05df3846c52ce88a606aff414EntityRecord, ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9bd576a05df3846c52ce88a606aff414EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord FromStructure(EN_9bd576a05df3846c52ce88a606aff414EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord(s, config);
}

}


