using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceCommentSARecord
public class JSONRC_c947fd25bedc3c8ec938df5b28c2643b : AbstractRESTStructure<RC_c947fd25bedc3c8ec938df5b28c2643b> {
[JsonProperty("InvoiceCommentSA")]
[JsonPropertyName("InvoiceCommentSA")]
public ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure AttrInvoiceCommentSA;

public JSONRC_c947fd25bedc3c8ec938df5b28c2643b() { }

public JSONRC_c947fd25bedc3c8ec938df5b28c2643b (RC_c947fd25bedc3c8ec938df5b28c2643b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceCommentSA = ConvertToRestWithoutDefaults(s.ssSTInvoiceCommentSA, new ST_f1259a41db43b1c9d9faa83c38ada6a7Structure(), ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure.FromStructure, config);
  } else {
AttrInvoiceCommentSA = ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure.FromStructure(s.ssSTInvoiceCommentSA, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b, RC_c947fd25bedc3c8ec938df5b28c2643b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b s) => ToStructure(s, config);
}
public static RC_c947fd25bedc3c8ec938df5b28c2643b ToStructure(ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b obj, IBehaviorsConfiguration config) { 
  RC_c947fd25bedc3c8ec938df5b28c2643b s = new RC_c947fd25bedc3c8ec938df5b28c2643b();
  if(obj != null) {
  s.ssSTInvoiceCommentSA = ssConectaProveedores.RestRecords.JSONST_f1259a41db43b1c9d9faa83c38ada6a7Structure.ToStructure(obj.AttrInvoiceCommentSA, config);
  }
  return s;
}

public static Func<RC_c947fd25bedc3c8ec938df5b28c2643b, ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c947fd25bedc3c8ec938df5b28c2643b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b FromStructure(RC_c947fd25bedc3c8ec938df5b28c2643b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c947fd25bedc3c8ec938df5b28c2643b(s, config);
}

}


