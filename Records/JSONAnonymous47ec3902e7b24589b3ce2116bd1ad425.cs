using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedTaxRecord
public class JSONRC_965912af30c7fbb7316f17bf8e331782 : AbstractRESTStructure<RC_965912af30c7fbb7316f17bf8e331782> {
[JsonProperty("InvoiceExtendedTax")]
[JsonPropertyName("InvoiceExtendedTax")]
public ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord AttrInvoiceExtendedTax;

public JSONRC_965912af30c7fbb7316f17bf8e331782() { }

public JSONRC_965912af30c7fbb7316f17bf8e331782 (RC_965912af30c7fbb7316f17bf8e331782 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedTax, new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedTax = ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure(s.ssENInvoiceExtendedTax, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782, RC_965912af30c7fbb7316f17bf8e331782> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782 s) => ToStructure(s, config);
}
public static RC_965912af30c7fbb7316f17bf8e331782 ToStructure(ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782 obj, IBehaviorsConfiguration config) { 
  RC_965912af30c7fbb7316f17bf8e331782 s = new RC_965912af30c7fbb7316f17bf8e331782();
  if(obj != null) {
  s.ssENInvoiceExtendedTax = ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.ToStructure(obj.AttrInvoiceExtendedTax, config);
  }
  return s;
}

public static Func<RC_965912af30c7fbb7316f17bf8e331782, ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_965912af30c7fbb7316f17bf8e331782 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782 FromStructure(RC_965912af30c7fbb7316f17bf8e331782 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_965912af30c7fbb7316f17bf8e331782(s, config);
}

}


