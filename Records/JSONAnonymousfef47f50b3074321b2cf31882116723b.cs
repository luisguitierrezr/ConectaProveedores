using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccountingInvoiceExtendedRecord
public class JSONRC_2c7478516bbd3eed6a35183496a9f500 : AbstractRESTStructure<RC_2c7478516bbd3eed6a35183496a9f500> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceExtendedReceiver")]
[JsonPropertyName("InvoiceExtendedReceiver")]
public ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord AttrInvoiceExtendedReceiver;

[JsonProperty("InvoiceExtendedCartaPorte")]
[JsonPropertyName("InvoiceExtendedCartaPorte")]
public ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord AttrInvoiceExtendedCartaPorte;

[JsonProperty("InvoiceExtendedIssuer")]
[JsonPropertyName("InvoiceExtendedIssuer")]
public ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord AttrInvoiceExtendedIssuer;

[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_2c7478516bbd3eed6a35183496a9f500() { }

public JSONRC_2c7478516bbd3eed6a35183496a9f500 (RC_2c7478516bbd3eed6a35183496a9f500 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceExtendedReceiver = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedReceiver, new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure, config);
AttrInvoiceExtendedCartaPorte = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedCartaPorte, new EN_9bd576a05df3846c52ce88a606aff414EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure, config);
AttrInvoiceExtendedIssuer = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedIssuer, new EN_1ca446167f1a5fee035306f622895668EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure, config);
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure(s.ssENInvoiceExtendedReceiver, config);
AttrInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure(s.ssENInvoiceExtendedCartaPorte, config);
AttrInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure(s.ssENInvoiceExtendedIssuer, config);
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500, RC_2c7478516bbd3eed6a35183496a9f500> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500 s) => ToStructure(s, config);
}
public static RC_2c7478516bbd3eed6a35183496a9f500 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500 obj, IBehaviorsConfiguration config) { 
  RC_2c7478516bbd3eed6a35183496a9f500 s = new RC_2c7478516bbd3eed6a35183496a9f500();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.ToStructure(obj.AttrInvoiceExtendedReceiver, config);
  s.ssENInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.ToStructure(obj.AttrInvoiceExtendedCartaPorte, config);
  s.ssENInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.ToStructure(obj.AttrInvoiceExtendedIssuer, config);
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_2c7478516bbd3eed6a35183496a9f500, ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2c7478516bbd3eed6a35183496a9f500 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500 FromStructure(RC_2c7478516bbd3eed6a35183496a9f500 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2c7478516bbd3eed6a35183496a9f500(s, config);
}

}


