using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioRequisitionOrderMainInvoicePolizaFolioSocietyOrderSocietyReqSocietyRecord
public class JSONRC_60aeadfeb5acbf1f5997b0af030c3433 : AbstractRESTStructure<RC_60aeadfeb5acbf1f5997b0af030c3433> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("InvoicePoliza")]
[JsonPropertyName("InvoicePoliza")]
public ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord AttrInvoicePoliza;

[JsonProperty("FolioSociety")]
[JsonPropertyName("FolioSociety")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrFolioSociety;

[JsonProperty("OrderSociety")]
[JsonPropertyName("OrderSociety")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrOrderSociety;

[JsonProperty("ReqSociety")]
[JsonPropertyName("ReqSociety")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrReqSociety;

public JSONRC_60aeadfeb5acbf1f5997b0af030c3433() { }

public JSONRC_60aeadfeb5acbf1f5997b0af030c3433 (RC_60aeadfeb5acbf1f5997b0af030c3433 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrInvoicePoliza = ConvertToRestWithoutDefaults(s.ssENInvoicePoliza, new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure, config);
AttrFolioSociety = ConvertToRestWithoutDefaults(s.ssENFolioSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrOrderSociety = ConvertToRestWithoutDefaults(s.ssENOrderSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrReqSociety = ConvertToRestWithoutDefaults(s.ssENReqSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrInvoicePoliza = ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure(s.ssENInvoicePoliza, config);
AttrFolioSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENFolioSociety, config);
AttrOrderSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENOrderSociety, config);
AttrReqSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENReqSociety, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433, RC_60aeadfeb5acbf1f5997b0af030c3433> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433 s) => ToStructure(s, config);
}
public static RC_60aeadfeb5acbf1f5997b0af030c3433 ToStructure(ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433 obj, IBehaviorsConfiguration config) { 
  RC_60aeadfeb5acbf1f5997b0af030c3433 s = new RC_60aeadfeb5acbf1f5997b0af030c3433();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENInvoicePoliza = ssConectaProveedores.RestRecords.JSONEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.ToStructure(obj.AttrInvoicePoliza, config);
  s.ssENFolioSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrFolioSociety, config);
  s.ssENOrderSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrOrderSociety, config);
  s.ssENReqSociety = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrReqSociety, config);
  }
  return s;
}

public static Func<RC_60aeadfeb5acbf1f5997b0af030c3433, ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60aeadfeb5acbf1f5997b0af030c3433 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433 FromStructure(RC_60aeadfeb5acbf1f5997b0af030c3433 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_60aeadfeb5acbf1f5997b0af030c3433(s, config);
}

}


