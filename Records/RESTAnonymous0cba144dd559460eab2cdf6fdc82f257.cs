using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessRecord
public class RESTRC_d01c9a070ebc097e32a128e1b4125cc2 : AbstractRESTStructure<RC_d01c9a070ebc097e32a128e1b4125cc2> {
[JsonProperty("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public RESTRC_d01c9a070ebc097e32a128e1b4125cc2() { }

public RESTRC_d01c9a070ebc097e32a128e1b4125cc2 (RC_d01c9a070ebc097e32a128e1b4125cc2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static RC_d01c9a070ebc097e32a128e1b4125cc2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d01c9a070ebc097e32a128e1b4125cc2 obj) { 
  RC_d01c9a070ebc097e32a128e1b4125cc2 s = new RC_d01c9a070ebc097e32a128e1b4125cc2();
  if(obj != null) {
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.RESTEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess);
  }
  return s;
}

public static Func<RC_d01c9a070ebc097e32a128e1b4125cc2, ssConectaProveedores.RestRecords.RESTRC_d01c9a070ebc097e32a128e1b4125cc2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d01c9a070ebc097e32a128e1b4125cc2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d01c9a070ebc097e32a128e1b4125cc2 FromStructure(RC_d01c9a070ebc097e32a128e1b4125cc2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d01c9a070ebc097e32a128e1b4125cc2(s, config);
}

}


