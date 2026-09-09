using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalRecord
public class JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374 : AbstractRESTStructure<RC_8ecd20e9afb5cd14c3f1aea1a6262374> {
[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

public JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374() { }

public JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374 (RC_8ecd20e9afb5cd14c3f1aea1a6262374 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
  } else {
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374, RC_8ecd20e9afb5cd14c3f1aea1a6262374> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374 s) => ToStructure(s, config);
}
public static RC_8ecd20e9afb5cd14c3f1aea1a6262374 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374 obj, IBehaviorsConfiguration config) { 
  RC_8ecd20e9afb5cd14c3f1aea1a6262374 s = new RC_8ecd20e9afb5cd14c3f1aea1a6262374();
  if(obj != null) {
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  }
  return s;
}

public static Func<RC_8ecd20e9afb5cd14c3f1aea1a6262374, ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8ecd20e9afb5cd14c3f1aea1a6262374 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374 FromStructure(RC_8ecd20e9afb5cd14c3f1aea1a6262374 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8ecd20e9afb5cd14c3f1aea1a6262374(s, config);
}

}


