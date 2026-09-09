using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceOrderAccountingOrderMainOrderDetailInvoiceExtendedCompanySupplierProject_Asset_ServicePaymentMethodsRegionRecord
public class RESTRC_bd42fd4399da47c92c88d912cd87df67 : AbstractRESTStructure<RC_bd42fd4399da47c92c88d912cd87df67> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Project_Asset_Service")]
public ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord AttrProject_Asset_Service;

[JsonProperty("PaymentMethods")]
public ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_bd42fd4399da47c92c88d912cd87df67() { }

public RESTRC_bd42fd4399da47c92c88d912cd87df67 (RC_bd42fd4399da47c92c88d912cd87df67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrProject_Asset_Service = ConvertToRestWithoutDefaults(s.ssENProject_Asset_Service, new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure, config);
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.FromStructure(s.ssENProject_Asset_Service, config);
AttrPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_bd42fd4399da47c92c88d912cd87df67 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bd42fd4399da47c92c88d912cd87df67 obj) { 
  RC_bd42fd4399da47c92c88d912cd87df67 s = new RC_bd42fd4399da47c92c88d912cd87df67();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENProject_Asset_Service = ssConectaProveedores.RestRecords.RESTEN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord.ToStructure(obj.AttrProject_Asset_Service);
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_bd42fd4399da47c92c88d912cd87df67, ssConectaProveedores.RestRecords.RESTRC_bd42fd4399da47c92c88d912cd87df67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bd42fd4399da47c92c88d912cd87df67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bd42fd4399da47c92c88d912cd87df67 FromStructure(RC_bd42fd4399da47c92c88d912cd87df67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bd42fd4399da47c92c88d912cd87df67(s, config);
}

}


