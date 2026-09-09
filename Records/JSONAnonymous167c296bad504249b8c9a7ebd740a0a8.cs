using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemInvoiceExtendedRecord
public class JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc : AbstractRESTStructure<RC_53d17e5a9f6c0fdb10660d26c96f84cc> {
[JsonProperty("InvoiceExtendedItem")]
[JsonPropertyName("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc() { }

public JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc (RC_53d17e5a9f6c0fdb10660d26c96f84cc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc, RC_53d17e5a9f6c0fdb10660d26c96f84cc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc s) => ToStructure(s, config);
}
public static RC_53d17e5a9f6c0fdb10660d26c96f84cc ToStructure(ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc obj, IBehaviorsConfiguration config) { 
  RC_53d17e5a9f6c0fdb10660d26c96f84cc s = new RC_53d17e5a9f6c0fdb10660d26c96f84cc();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_53d17e5a9f6c0fdb10660d26c96f84cc, ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_53d17e5a9f6c0fdb10660d26c96f84cc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc FromStructure(RC_53d17e5a9f6c0fdb10660d26c96f84cc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_53d17e5a9f6c0fdb10660d26c96f84cc(s, config);
}

}


