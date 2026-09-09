using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioRequisitionOrderMainInvoicePolizaFolioSocietyOrderSocietyReqSocietyRecord
public class RESTRC_60aeadfeb5acbf1f5997b0af030c3433 : AbstractRESTStructure<RC_60aeadfeb5acbf1f5997b0af030c3433> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("InvoicePoliza")]
public ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord AttrInvoicePoliza;

[JsonProperty("FolioSociety")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrFolioSociety;

[JsonProperty("OrderSociety")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrOrderSociety;

[JsonProperty("ReqSociety")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrReqSociety;

public RESTRC_60aeadfeb5acbf1f5997b0af030c3433() { }

public RESTRC_60aeadfeb5acbf1f5997b0af030c3433 (RC_60aeadfeb5acbf1f5997b0af030c3433 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrInvoicePoliza = ConvertToRestWithoutDefaults(s.ssENInvoicePoliza, new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure, config);
AttrFolioSociety = ConvertToRestWithoutDefaults(s.ssENFolioSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrOrderSociety = ConvertToRestWithoutDefaults(s.ssENOrderSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrReqSociety = ConvertToRestWithoutDefaults(s.ssENReqSociety, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure(s.ssENInvoicePoliza, config);
AttrFolioSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENFolioSociety, config);
AttrOrderSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENOrderSociety, config);
AttrReqSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENReqSociety, config);
  }
}

public static RC_60aeadfeb5acbf1f5997b0af030c3433 ToStructure(ssConectaProveedores.RestRecords.RESTRC_60aeadfeb5acbf1f5997b0af030c3433 obj) { 
  RC_60aeadfeb5acbf1f5997b0af030c3433 s = new RC_60aeadfeb5acbf1f5997b0af030c3433();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.ToStructure(obj.AttrInvoicePoliza);
  s.ssENFolioSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrFolioSociety);
  s.ssENOrderSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrOrderSociety);
  s.ssENReqSociety = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrReqSociety);
  }
  return s;
}

public static Func<RC_60aeadfeb5acbf1f5997b0af030c3433, ssConectaProveedores.RestRecords.RESTRC_60aeadfeb5acbf1f5997b0af030c3433> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_60aeadfeb5acbf1f5997b0af030c3433 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_60aeadfeb5acbf1f5997b0af030c3433 FromStructure(RC_60aeadfeb5acbf1f5997b0af030c3433 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_60aeadfeb5acbf1f5997b0af030c3433(s, config);
}

}


