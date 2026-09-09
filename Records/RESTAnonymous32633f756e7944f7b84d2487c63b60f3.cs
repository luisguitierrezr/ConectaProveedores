using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemTaxRecord
public class RESTRC_e7b4e13946d568a48ef39b6a3bfce595 : AbstractRESTStructure<RC_e7b4e13946d568a48ef39b6a3bfce595> {
[JsonProperty("InvoiceExtendedItemTax")]
public ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord AttrInvoiceExtendedItemTax;

public RESTRC_e7b4e13946d568a48ef39b6a3bfce595() { }

public RESTRC_e7b4e13946d568a48ef39b6a3bfce595 (RC_e7b4e13946d568a48ef39b6a3bfce595 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItemTax = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItemTax, new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructure(s.ssENInvoiceExtendedItemTax, config);
  }
}

public static RC_e7b4e13946d568a48ef39b6a3bfce595 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e7b4e13946d568a48ef39b6a3bfce595 obj) { 
  RC_e7b4e13946d568a48ef39b6a3bfce595 s = new RC_e7b4e13946d568a48ef39b6a3bfce595();
  if(obj != null) {
  s.ssENInvoiceExtendedItemTax = ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.ToStructure(obj.AttrInvoiceExtendedItemTax);
  }
  return s;
}

public static Func<RC_e7b4e13946d568a48ef39b6a3bfce595, ssConectaProveedores.RestRecords.RESTRC_e7b4e13946d568a48ef39b6a3bfce595> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e7b4e13946d568a48ef39b6a3bfce595 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e7b4e13946d568a48ef39b6a3bfce595 FromStructure(RC_e7b4e13946d568a48ef39b6a3bfce595 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e7b4e13946d568a48ef39b6a3bfce595(s, config);
}

}


