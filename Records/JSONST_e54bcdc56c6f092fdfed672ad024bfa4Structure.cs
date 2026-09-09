using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioReject
public class JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure : AbstractRESTStructure<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> {
[JsonProperty("IsCancelEntry")]
[JsonPropertyName("IsCancelEntry")]
public bool? AttrIsCancelEntry;

[JsonProperty("IsCancelInvoice")]
[JsonPropertyName("IsCancelInvoice")]
public bool? AttrIsCancelInvoice;

[JsonProperty("IsCancelFolio")]
[JsonPropertyName("IsCancelFolio")]
public bool? AttrIsCancelFolio;

[JsonProperty("IsRejectInvoice")]
[JsonPropertyName("IsRejectInvoice")]
public bool? AttrIsRejectInvoice;

[JsonProperty("Reason")]
[JsonPropertyName("Reason")]
public string AttrReason;

public JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure() { }

public JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsCancelEntry = ConvertToRestWithoutDefaults(s.ssIsCancelEntry, false);
AttrIsCancelInvoice = ConvertToRestWithoutDefaults(s.ssIsCancelInvoice, false);
AttrIsCancelFolio = ConvertToRestWithoutDefaults(s.ssIsCancelFolio, false);
AttrIsRejectInvoice = ConvertToRestWithoutDefaults(s.ssIsRejectInvoice, false);
AttrReason = ConvertToRestWithoutDefaults(s.ssReason, "");
  } else {
AttrIsCancelEntry = (bool?) s.ssIsCancelEntry;
AttrIsCancelInvoice = (bool?) s.ssIsCancelInvoice;
AttrIsCancelFolio = (bool?) s.ssIsCancelFolio;
AttrIsRejectInvoice = (bool?) s.ssIsRejectInvoice;
AttrReason = s.ssReason;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure s) => ToStructure(s, config);
}
public static ST_e54bcdc56c6f092fdfed672ad024bfa4Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure obj, IBehaviorsConfiguration config) { 
  ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s = new ST_e54bcdc56c6f092fdfed672ad024bfa4Structure();
  if(obj != null) {
  s.ssIsCancelEntry = obj.AttrIsCancelEntry == null ? false : obj.AttrIsCancelEntry.Value;
  s.ssIsCancelInvoice = obj.AttrIsCancelInvoice == null ? false : obj.AttrIsCancelInvoice.Value;
  s.ssIsCancelFolio = obj.AttrIsCancelFolio == null ? false : obj.AttrIsCancelFolio.Value;
  s.ssIsRejectInvoice = obj.AttrIsRejectInvoice == null ? false : obj.AttrIsRejectInvoice.Value;
  s.ssReason = obj.AttrReason == null ? "" : obj.AttrReason;
  }
  return s;
}

public static Func<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure, ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure FromStructure(ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e54bcdc56c6f092fdfed672ad024bfa4Structure(s, config);
}

}


