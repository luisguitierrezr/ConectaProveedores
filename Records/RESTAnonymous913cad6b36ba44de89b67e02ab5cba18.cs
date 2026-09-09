using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceOrderMainInvoiceAccountingProcessCompanySupplierRecord
public class RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8 : AbstractRESTStructure<RC_dd31a6c81d63b4e265f3c3d56e3eabb8> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

[JsonProperty("Company")]
public ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8() { }

public RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8 (RC_dd31a6c81d63b4e265f3c3d56e3eabb8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
AttrCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_dd31a6c81d63b4e265f3c3d56e3eabb8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8 obj) { 
  RC_dd31a6c81d63b4e265f3c3d56e3eabb8 s = new RC_dd31a6c81d63b4e265f3c3d56e3eabb8();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  s.ssENCompany = ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_dd31a6c81d63b4e265f3c3d56e3eabb8, ssConectaProveedores.RestRecords.RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dd31a6c81d63b4e265f3c3d56e3eabb8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8 FromStructure(RC_dd31a6c81d63b4e265f3c3d56e3eabb8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dd31a6c81d63b4e265f3c3d56e3eabb8(s, config);
}

}


