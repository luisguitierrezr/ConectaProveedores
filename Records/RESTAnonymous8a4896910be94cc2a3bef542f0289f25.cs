using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceCommentSARecord
public class RESTRC_c947fd25bedc3c8ec938df5b28c2643b : AbstractRESTStructure<RC_c947fd25bedc3c8ec938df5b28c2643b> {
[JsonProperty("InvoiceCommentSA")]
public ssConectaProveedores.RestRecords.RESTST_f1259a41db43b1c9d9faa83c38ada6a7Structure AttrInvoiceCommentSA;

public RESTRC_c947fd25bedc3c8ec938df5b28c2643b() { }

public RESTRC_c947fd25bedc3c8ec938df5b28c2643b (RC_c947fd25bedc3c8ec938df5b28c2643b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceCommentSA = ConvertToRestWithoutDefaults(s.ssSTInvoiceCommentSA, new ST_f1259a41db43b1c9d9faa83c38ada6a7Structure(), ssConectaProveedores.RestRecords.RESTST_f1259a41db43b1c9d9faa83c38ada6a7Structure.FromStructure, config);
  } else {
AttrInvoiceCommentSA = ssConectaProveedores.RestRecords.RESTST_f1259a41db43b1c9d9faa83c38ada6a7Structure.FromStructure(s.ssSTInvoiceCommentSA, config);
  }
}

public static RC_c947fd25bedc3c8ec938df5b28c2643b ToStructure(ssConectaProveedores.RestRecords.RESTRC_c947fd25bedc3c8ec938df5b28c2643b obj) { 
  RC_c947fd25bedc3c8ec938df5b28c2643b s = new RC_c947fd25bedc3c8ec938df5b28c2643b();
  if(obj != null) {
  s.ssSTInvoiceCommentSA = ssConectaProveedores.RestRecords.RESTST_f1259a41db43b1c9d9faa83c38ada6a7Structure.ToStructure(obj.AttrInvoiceCommentSA);
  }
  return s;
}

public static Func<RC_c947fd25bedc3c8ec938df5b28c2643b, ssConectaProveedores.RestRecords.RESTRC_c947fd25bedc3c8ec938df5b28c2643b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c947fd25bedc3c8ec938df5b28c2643b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c947fd25bedc3c8ec938df5b28c2643b FromStructure(RC_c947fd25bedc3c8ec938df5b28c2643b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c947fd25bedc3c8ec938df5b28c2643b(s, config);
}

}


