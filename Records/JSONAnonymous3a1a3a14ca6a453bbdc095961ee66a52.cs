using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemRecord
public class JSONRC_7f2610cf0c5fadd86ba78c902c31effa : AbstractRESTStructure<RC_7f2610cf0c5fadd86ba78c902c31effa> {
[JsonProperty("InvoiceExtendedItem")]
[JsonPropertyName("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

public JSONRC_7f2610cf0c5fadd86ba78c902c31effa() { }

public JSONRC_7f2610cf0c5fadd86ba78c902c31effa (RC_7f2610cf0c5fadd86ba78c902c31effa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa, RC_7f2610cf0c5fadd86ba78c902c31effa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa s) => ToStructure(s, config);
}
public static RC_7f2610cf0c5fadd86ba78c902c31effa ToStructure(ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa obj, IBehaviorsConfiguration config) { 
  RC_7f2610cf0c5fadd86ba78c902c31effa s = new RC_7f2610cf0c5fadd86ba78c902c31effa();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem, config);
  }
  return s;
}

public static Func<RC_7f2610cf0c5fadd86ba78c902c31effa, ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f2610cf0c5fadd86ba78c902c31effa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa FromStructure(RC_7f2610cf0c5fadd86ba78c902c31effa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7f2610cf0c5fadd86ba78c902c31effa(s, config);
}

}


