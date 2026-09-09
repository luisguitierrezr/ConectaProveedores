using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedTaxRecord
public class RESTRC_965912af30c7fbb7316f17bf8e331782 : AbstractRESTStructure<RC_965912af30c7fbb7316f17bf8e331782> {
[JsonProperty("InvoiceExtendedTax")]
public ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord AttrInvoiceExtendedTax;

public RESTRC_965912af30c7fbb7316f17bf8e331782() { }

public RESTRC_965912af30c7fbb7316f17bf8e331782 (RC_965912af30c7fbb7316f17bf8e331782 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedTax, new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedTax = ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.FromStructure(s.ssENInvoiceExtendedTax, config);
  }
}

public static RC_965912af30c7fbb7316f17bf8e331782 ToStructure(ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782 obj) { 
  RC_965912af30c7fbb7316f17bf8e331782 s = new RC_965912af30c7fbb7316f17bf8e331782();
  if(obj != null) {
  s.ssENInvoiceExtendedTax = ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord.ToStructure(obj.AttrInvoiceExtendedTax);
  }
  return s;
}

public static Func<RC_965912af30c7fbb7316f17bf8e331782, ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_965912af30c7fbb7316f17bf8e331782 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782 FromStructure(RC_965912af30c7fbb7316f17bf8e331782 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_965912af30c7fbb7316f17bf8e331782(s, config);
}

}


