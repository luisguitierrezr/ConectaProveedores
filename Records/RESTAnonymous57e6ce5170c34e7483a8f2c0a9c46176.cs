using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoice_CNInvoiceStatusFolioOrderMainSupplierRegionRecord
public class RESTRC_306956f424b25ba445c85694148eaa7a : AbstractRESTStructure<RC_306956f424b25ba445c85694148eaa7a> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Invoice_CN")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice_CN;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_306956f424b25ba445c85694148eaa7a() { }

public RESTRC_306956f424b25ba445c85694148eaa7a (RC_306956f424b25ba445c85694148eaa7a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoice_CN = ConvertToRestWithoutDefaults(s.ssENInvoice_CN, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice_CN, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_306956f424b25ba445c85694148eaa7a ToStructure(ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a obj) { 
  RC_306956f424b25ba445c85694148eaa7a s = new RC_306956f424b25ba445c85694148eaa7a();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice_CN);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_306956f424b25ba445c85694148eaa7a, ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_306956f424b25ba445c85694148eaa7a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a FromStructure(RC_306956f424b25ba445c85694148eaa7a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_306956f424b25ba445c85694148eaa7a(s, config);
}

}


