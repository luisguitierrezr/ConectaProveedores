using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedReceiver
public class JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord : AbstractRESTStructure<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RFC")]
[JsonPropertyName("RFC")]
public string AttrRFC;

[JsonProperty("Nombre")]
[JsonPropertyName("Nombre")]
public string AttrNombre;

[JsonProperty("RegimenFiscal")]
[JsonPropertyName("RegimenFiscal")]
public string AttrRegimenFiscal;

[JsonProperty("CodigoPostal")]
[JsonPropertyName("CodigoPostal")]
public string AttrCodigoPostal;

public JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord() { }

public JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRFC = ConvertToRestWithoutDefaults(s.ssRFC, "");
AttrNombre = ConvertToRestWithoutDefaults(s.ssNombre, "");
AttrRegimenFiscal = ConvertToRestWithoutDefaults(s.ssRegimenFiscal, "");
AttrCodigoPostal = ConvertToRestWithoutDefaults(s.ssCodigoPostal, "");
  } else {
AttrId = (long?) s.ssId;
AttrRFC = s.ssRFC;
AttrNombre = s.ssNombre;
AttrRegimenFiscal = s.ssRegimenFiscal;
AttrCodigoPostal = s.ssCodigoPostal;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord, EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord s) => ToStructure(s, config);
}
public static EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord s = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRFC = obj.AttrRFC == null ? "" : obj.AttrRFC;
  s.ssNombre = obj.AttrNombre == null ? "" : obj.AttrNombre;
  s.ssRegimenFiscal = obj.AttrRegimenFiscal == null ? "" : obj.AttrRegimenFiscal;
  s.ssCodigoPostal = obj.AttrCodigoPostal == null ? "" : obj.AttrCodigoPostal;
  }
  return s;
}

public static Func<EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord, ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord FromStructure(EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord(s, config);
}

}


