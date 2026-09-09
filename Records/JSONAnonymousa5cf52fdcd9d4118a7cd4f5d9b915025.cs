using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemInvoiceExtendedItemTaxRecord
public class JSONRC_25d357c844d16eb6579210aff3596f77 : AbstractRESTStructure<RC_25d357c844d16eb6579210aff3596f77> {
[JsonProperty("InvoiceExtendedItem")]
[JsonPropertyName("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

[JsonProperty("InvoiceExtendedItemTax")]
[JsonPropertyName("InvoiceExtendedItemTax")]
public ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord AttrInvoiceExtendedItemTax;

public JSONRC_25d357c844d16eb6579210aff3596f77() { }

public JSONRC_25d357c844d16eb6579210aff3596f77 (RC_25d357c844d16eb6579210aff3596f77 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
AttrInvoiceExtendedItemTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItemTax, new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
AttrInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure(s.ssENInvoiceExtendedItemTax, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77, RC_25d357c844d16eb6579210aff3596f77> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77 s) => ToStructure(s, config);
}
public static RC_25d357c844d16eb6579210aff3596f77 ToStructure(ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77 obj, IBehaviorsConfiguration config) { 
  RC_25d357c844d16eb6579210aff3596f77 s = new RC_25d357c844d16eb6579210aff3596f77();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem, config);
  s.ssENInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.ToStructure(obj.AttrInvoiceExtendedItemTax, config);
  }
  return s;
}

public static Func<RC_25d357c844d16eb6579210aff3596f77, ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_25d357c844d16eb6579210aff3596f77 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77 FromStructure(RC_25d357c844d16eb6579210aff3596f77 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_25d357c844d16eb6579210aff3596f77(s, config);
}

}


