using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionServiceInvoiceUsageRecord
public class JSONRC_6dd7b29a235be8701ea943f35694df35 : AbstractRESTStructure<RC_6dd7b29a235be8701ea943f35694df35> {
[JsonProperty("RequisitionService")]
[JsonPropertyName("RequisitionService")]
public ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord AttrRequisitionService;

[JsonProperty("InvoiceUsage")]
[JsonPropertyName("InvoiceUsage")]
public ssConectaProveedores.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord AttrInvoiceUsage;

public JSONRC_6dd7b29a235be8701ea943f35694df35() { }

public JSONRC_6dd7b29a235be8701ea943f35694df35 (RC_6dd7b29a235be8701ea943f35694df35 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionService = ConvertToRestWithoutDefaults(s.ssENRequisitionService, new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure, config);
AttrInvoiceUsage = ConvertToRestWithoutDefaults(s.ssENInvoiceUsage, new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure, config);
  } else {
AttrRequisitionService = ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.FromStructure(s.ssENRequisitionService, config);
AttrInvoiceUsage = ssConectaProveedores.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure(s.ssENInvoiceUsage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35, RC_6dd7b29a235be8701ea943f35694df35> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35 s) => ToStructure(s, config);
}
public static RC_6dd7b29a235be8701ea943f35694df35 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35 obj, IBehaviorsConfiguration config) { 
  RC_6dd7b29a235be8701ea943f35694df35 s = new RC_6dd7b29a235be8701ea943f35694df35();
  if(obj != null) {
  s.ssENRequisitionService = ssConectaProveedores.RestRecords.JSONEN_455768e63ed34ad2746f7c539b65e1caEntityRecord.ToStructure(obj.AttrRequisitionService, config);
  s.ssENInvoiceUsage = ssConectaProveedores.RestRecords.JSONEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.ToStructure(obj.AttrInvoiceUsage, config);
  }
  return s;
}

public static Func<RC_6dd7b29a235be8701ea943f35694df35, ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6dd7b29a235be8701ea943f35694df35 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35 FromStructure(RC_6dd7b29a235be8701ea943f35694df35 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6dd7b29a235be8701ea943f35694df35(s, config);
}

}


