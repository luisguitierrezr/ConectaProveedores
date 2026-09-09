using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFilesAuditRecord
public class RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc : AbstractRESTStructure<RC_1a5b8cd0ef1115d2fdd242fac41124bc> {
[JsonProperty("InvoiceFilesAudit")]
public ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure AttrInvoiceFilesAudit;

public RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc() { }

public RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc (RC_1a5b8cd0ef1115d2fdd242fac41124bc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFilesAudit = ConvertToRestWithoutDefaults(s.ssSTInvoiceFilesAudit, new ST_29dc80a5deae2388e31181e1082143cfStructure(), ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure.FromStructure, config);
  } else {
AttrInvoiceFilesAudit = ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure.FromStructure(s.ssSTInvoiceFilesAudit, config);
  }
}

public static RC_1a5b8cd0ef1115d2fdd242fac41124bc ToStructure(ssConectaProveedores.RestRecords.RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc obj) { 
  RC_1a5b8cd0ef1115d2fdd242fac41124bc s = new RC_1a5b8cd0ef1115d2fdd242fac41124bc();
  if(obj != null) {
  s.ssSTInvoiceFilesAudit = ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure.ToStructure(obj.AttrInvoiceFilesAudit);
  }
  return s;
}

public static Func<RC_1a5b8cd0ef1115d2fdd242fac41124bc, ssConectaProveedores.RestRecords.RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1a5b8cd0ef1115d2fdd242fac41124bc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc FromStructure(RC_1a5b8cd0ef1115d2fdd242fac41124bc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1a5b8cd0ef1115d2fdd242fac41124bc(s, config);
}

}


