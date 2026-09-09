using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemInvoiceExtendedRecord
public class RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc : AbstractRESTStructure<RC_53d17e5a9f6c0fdb10660d26c96f84cc> {
[JsonProperty("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc() { }

public RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc (RC_53d17e5a9f6c0fdb10660d26c96f84cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static RC_53d17e5a9f6c0fdb10660d26c96f84cc ToStructure(ssConectaProveedores.RestRecords.RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc obj) { 
  RC_53d17e5a9f6c0fdb10660d26c96f84cc s = new RC_53d17e5a9f6c0fdb10660d26c96f84cc();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended);
  }
  return s;
}

public static Func<RC_53d17e5a9f6c0fdb10660d26c96f84cc, ssConectaProveedores.RestRecords.RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53d17e5a9f6c0fdb10660d26c96f84cc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc FromStructure(RC_53d17e5a9f6c0fdb10660d26c96f84cc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_53d17e5a9f6c0fdb10660d26c96f84cc(s, config);
}

}


