using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAuditFilesListRecord
public class RESTRC_43d13231e92dc315679ee8f8afa7a620 : AbstractRESTStructure<RC_43d13231e92dc315679ee8f8afa7a620> {
[JsonProperty("InvoiceAuditFilesList")]
public ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure AttrInvoiceAuditFilesList;

public RESTRC_43d13231e92dc315679ee8f8afa7a620() { }

public RESTRC_43d13231e92dc315679ee8f8afa7a620 (RC_43d13231e92dc315679ee8f8afa7a620 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAuditFilesList = ConvertToRestWithoutDefaults(s.ssSTInvoiceAuditFilesList, new ST_15467825cb087ac1591b96b0d1989badStructure(), ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure.FromStructure, config);
  } else {
AttrInvoiceAuditFilesList = ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure.FromStructure(s.ssSTInvoiceAuditFilesList, config);
  }
}

public static RC_43d13231e92dc315679ee8f8afa7a620 ToStructure(ssConectaProveedores.RestRecords.RESTRC_43d13231e92dc315679ee8f8afa7a620 obj) { 
  RC_43d13231e92dc315679ee8f8afa7a620 s = new RC_43d13231e92dc315679ee8f8afa7a620();
  if(obj != null) {
  s.ssSTInvoiceAuditFilesList = ssConectaProveedores.RestRecords.RESTST_15467825cb087ac1591b96b0d1989badStructure.ToStructure(obj.AttrInvoiceAuditFilesList);
  }
  return s;
}

public static Func<RC_43d13231e92dc315679ee8f8afa7a620, ssConectaProveedores.RestRecords.RESTRC_43d13231e92dc315679ee8f8afa7a620> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_43d13231e92dc315679ee8f8afa7a620 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_43d13231e92dc315679ee8f8afa7a620 FromStructure(RC_43d13231e92dc315679ee8f8afa7a620 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_43d13231e92dc315679ee8f8afa7a620(s, config);
}

}


