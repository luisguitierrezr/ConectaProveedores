using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemInvoiceExtendedItemTaxRecord
public class RESTRC_25d357c844d16eb6579210aff3596f77 : AbstractRESTStructure<RC_25d357c844d16eb6579210aff3596f77> {
[JsonProperty("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

[JsonProperty("InvoiceExtendedItemTax")]
public ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord AttrInvoiceExtendedItemTax;

public RESTRC_25d357c844d16eb6579210aff3596f77() { }

public RESTRC_25d357c844d16eb6579210aff3596f77 (RC_25d357c844d16eb6579210aff3596f77 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
AttrInvoiceExtendedItemTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItemTax, new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
AttrInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure(s.ssENInvoiceExtendedItemTax, config);
  }
}

public static RC_25d357c844d16eb6579210aff3596f77 ToStructure(ssConectaProveedores.RestRecords.RESTRC_25d357c844d16eb6579210aff3596f77 obj) { 
  RC_25d357c844d16eb6579210aff3596f77 s = new RC_25d357c844d16eb6579210aff3596f77();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem);
  s.ssENInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.ToStructure(obj.AttrInvoiceExtendedItemTax);
  }
  return s;
}

public static Func<RC_25d357c844d16eb6579210aff3596f77, ssConectaProveedores.RestRecords.RESTRC_25d357c844d16eb6579210aff3596f77> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_25d357c844d16eb6579210aff3596f77 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_25d357c844d16eb6579210aff3596f77 FromStructure(RC_25d357c844d16eb6579210aff3596f77 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_25d357c844d16eb6579210aff3596f77(s, config);
}

}


