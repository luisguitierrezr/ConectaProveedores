using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessStatusRecord
public class JSONRC_88759af0096e690bb0b27652d93642e4 : AbstractRESTStructure<RC_88759af0096e690bb0b27652d93642e4> {
[JsonProperty("InvoiceAccountingProcessStatus")]
[JsonPropertyName("InvoiceAccountingProcessStatus")]
public ssConectaProveedores.RestRecords.JSONEN_49cd884b6b005041992feafa8ecc46e0EntityRecord AttrInvoiceAccountingProcessStatus;

public JSONRC_88759af0096e690bb0b27652d93642e4() { }

public JSONRC_88759af0096e690bb0b27652d93642e4 (RC_88759af0096e690bb0b27652d93642e4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessStatus, new EN_49cd884b6b005041992feafa8ecc46e0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessStatus = ssConectaProveedores.RestRecords.JSONEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.FromStructure(s.ssENInvoiceAccountingProcessStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4, RC_88759af0096e690bb0b27652d93642e4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4 s) => ToStructure(s, config);
}
public static RC_88759af0096e690bb0b27652d93642e4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4 obj, IBehaviorsConfiguration config) { 
  RC_88759af0096e690bb0b27652d93642e4 s = new RC_88759af0096e690bb0b27652d93642e4();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessStatus = ssConectaProveedores.RestRecords.JSONEN_49cd884b6b005041992feafa8ecc46e0EntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessStatus, config);
  }
  return s;
}

public static Func<RC_88759af0096e690bb0b27652d93642e4, ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_88759af0096e690bb0b27652d93642e4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4 FromStructure(RC_88759af0096e690bb0b27652d93642e4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_88759af0096e690bb0b27652d93642e4(s, config);
}

}


