using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessRecord
public class JSONRC_d01c9a070ebc097e32a128e1b4125cc2 : AbstractRESTStructure<RC_d01c9a070ebc097e32a128e1b4125cc2> {
[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_d01c9a070ebc097e32a128e1b4125cc2() { }

public JSONRC_d01c9a070ebc097e32a128e1b4125cc2 (RC_d01c9a070ebc097e32a128e1b4125cc2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2, RC_d01c9a070ebc097e32a128e1b4125cc2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2 s) => ToStructure(s, config);
}
public static RC_d01c9a070ebc097e32a128e1b4125cc2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2 obj, IBehaviorsConfiguration config) { 
  RC_d01c9a070ebc097e32a128e1b4125cc2 s = new RC_d01c9a070ebc097e32a128e1b4125cc2();
  if(obj != null) {
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_d01c9a070ebc097e32a128e1b4125cc2, ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d01c9a070ebc097e32a128e1b4125cc2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2 FromStructure(RC_d01c9a070ebc097e32a128e1b4125cc2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d01c9a070ebc097e32a128e1b4125cc2(s, config);
}

}


