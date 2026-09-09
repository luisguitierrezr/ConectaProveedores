using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioReject
public class RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure : AbstractRESTStructure<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure> {
[JsonProperty("IsCancelEntry")]
public bool? AttrIsCancelEntry;

[JsonProperty("IsCancelInvoice")]
public bool? AttrIsCancelInvoice;

[JsonProperty("IsCancelFolio")]
public bool? AttrIsCancelFolio;

[JsonProperty("IsRejectInvoice")]
public bool? AttrIsRejectInvoice;

[JsonProperty("Reason")]
public string AttrReason;

public RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure() { }

public RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s, IBehaviorsConfiguration config) {
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

public static ST_e54bcdc56c6f092fdfed672ad024bfa4Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure obj) { 
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

public static Func<ST_e54bcdc56c6f092fdfed672ad024bfa4Structure, ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure FromStructure(ST_e54bcdc56c6f092fdfed672ad024bfa4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure(s, config);
}

}


