using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalInvoiceApprovalLevelRecord
public class JSONRC_bc68025e789d69992aef27aed0947c65 : AbstractRESTStructure<RC_bc68025e789d69992aef27aed0947c65> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_bc68025e789d69992aef27aed0947c65() { }

public JSONRC_bc68025e789d69992aef27aed0947c65 (RC_bc68025e789d69992aef27aed0947c65 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65, RC_bc68025e789d69992aef27aed0947c65> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65 s) => ToStructure(s, config);
}
public static RC_bc68025e789d69992aef27aed0947c65 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65 obj, IBehaviorsConfiguration config) { 
  RC_bc68025e789d69992aef27aed0947c65 s = new RC_bc68025e789d69992aef27aed0947c65();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_bc68025e789d69992aef27aed0947c65, ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bc68025e789d69992aef27aed0947c65 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65 FromStructure(RC_bc68025e789d69992aef27aed0947c65 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bc68025e789d69992aef27aed0947c65(s, config);
}

}


