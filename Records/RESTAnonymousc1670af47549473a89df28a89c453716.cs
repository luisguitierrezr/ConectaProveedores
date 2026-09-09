using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessStatusRecord
public class RESTRC_88759af0096e690bb0b27652d93642e4 : AbstractRESTStructure<RC_88759af0096e690bb0b27652d93642e4> {
[JsonProperty("InvoiceAccountingProcessStatus")]
public ssConectaProveedores.RestRecords.RESTEN_49cd884b6b005041992feafa8ecc46e0EntityRecord AttrInvoiceAccountingProcessStatus;

public RESTRC_88759af0096e690bb0b27652d93642e4() { }

public RESTRC_88759af0096e690bb0b27652d93642e4 (RC_88759af0096e690bb0b27652d93642e4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessStatus, new EN_49cd884b6b005041992feafa8ecc46e0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessStatus = ssConectaProveedores.RestRecords.RESTEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.FromStructure(s.ssENInvoiceAccountingProcessStatus, config);
  }
}

public static RC_88759af0096e690bb0b27652d93642e4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_88759af0096e690bb0b27652d93642e4 obj) { 
  RC_88759af0096e690bb0b27652d93642e4 s = new RC_88759af0096e690bb0b27652d93642e4();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessStatus = ssConectaProveedores.RestRecords.RESTEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessStatus);
  }
  return s;
}

public static Func<RC_88759af0096e690bb0b27652d93642e4, ssConectaProveedores.RestRecords.RESTRC_88759af0096e690bb0b27652d93642e4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_88759af0096e690bb0b27652d93642e4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_88759af0096e690bb0b27652d93642e4 FromStructure(RC_88759af0096e690bb0b27652d93642e4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_88759af0096e690bb0b27652d93642e4(s, config);
}

}


