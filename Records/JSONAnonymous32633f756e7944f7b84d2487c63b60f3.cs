using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemTaxRecord
public class JSONRC_e7b4e13946d568a48ef39b6a3bfce595 : AbstractRESTStructure<RC_e7b4e13946d568a48ef39b6a3bfce595> {
[JsonProperty("InvoiceExtendedItemTax")]
[JsonPropertyName("InvoiceExtendedItemTax")]
public ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord AttrInvoiceExtendedItemTax;

public JSONRC_e7b4e13946d568a48ef39b6a3bfce595() { }

public JSONRC_e7b4e13946d568a48ef39b6a3bfce595 (RC_e7b4e13946d568a48ef39b6a3bfce595 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItemTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItemTax, new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure(s.ssENInvoiceExtendedItemTax, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595, RC_e7b4e13946d568a48ef39b6a3bfce595> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595 s) => ToStructure(s, config);
}
public static RC_e7b4e13946d568a48ef39b6a3bfce595 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595 obj, IBehaviorsConfiguration config) { 
  RC_e7b4e13946d568a48ef39b6a3bfce595 s = new RC_e7b4e13946d568a48ef39b6a3bfce595();
  if(obj != null) {
  s.ssENInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.ToStructure(obj.AttrInvoiceExtendedItemTax, config);
  }
  return s;
}

public static Func<RC_e7b4e13946d568a48ef39b6a3bfce595, ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e7b4e13946d568a48ef39b6a3bfce595 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595 FromStructure(RC_e7b4e13946d568a48ef39b6a3bfce595 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e7b4e13946d568a48ef39b6a3bfce595(s, config);
}

}


