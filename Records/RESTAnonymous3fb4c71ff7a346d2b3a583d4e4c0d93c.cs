using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessLines_F43Record
public class RESTRC_56dd61ddd73c9e3bf07414aa1c617494 : AbstractRESTStructure<RC_56dd61ddd73c9e3bf07414aa1c617494> {
[JsonProperty("InvoiceAccountingProcessLines_F43")]
public ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord AttrInvoiceAccountingProcessLines_F43;

public RESTRC_56dd61ddd73c9e3bf07414aa1c617494() { }

public RESTRC_56dd61ddd73c9e3bf07414aa1c617494 (RC_56dd61ddd73c9e3bf07414aa1c617494 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessLines_F43 = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessLines_F43, new EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessLines_F43 = ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord.FromStructure(s.ssENInvoiceAccountingProcessLines_F43, config);
  }
}

public static RC_56dd61ddd73c9e3bf07414aa1c617494 ToStructure(ssConectaProveedores.RestRecords.RESTRC_56dd61ddd73c9e3bf07414aa1c617494 obj) { 
  RC_56dd61ddd73c9e3bf07414aa1c617494 s = new RC_56dd61ddd73c9e3bf07414aa1c617494();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessLines_F43 = ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessLines_F43);
  }
  return s;
}

public static Func<RC_56dd61ddd73c9e3bf07414aa1c617494, ssConectaProveedores.RestRecords.RESTRC_56dd61ddd73c9e3bf07414aa1c617494> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_56dd61ddd73c9e3bf07414aa1c617494 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_56dd61ddd73c9e3bf07414aa1c617494 FromStructure(RC_56dd61ddd73c9e3bf07414aa1c617494 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_56dd61ddd73c9e3bf07414aa1c617494(s, config);
}

}


