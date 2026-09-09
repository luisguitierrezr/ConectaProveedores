using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemRecord
public class RESTRC_7f2610cf0c5fadd86ba78c902c31effa : AbstractRESTStructure<RC_7f2610cf0c5fadd86ba78c902c31effa> {
[JsonProperty("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

public RESTRC_7f2610cf0c5fadd86ba78c902c31effa() { }

public RESTRC_7f2610cf0c5fadd86ba78c902c31effa (RC_7f2610cf0c5fadd86ba78c902c31effa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
  }
}

public static RC_7f2610cf0c5fadd86ba78c902c31effa ToStructure(ssConectaProveedores.RestRecords.RESTRC_7f2610cf0c5fadd86ba78c902c31effa obj) { 
  RC_7f2610cf0c5fadd86ba78c902c31effa s = new RC_7f2610cf0c5fadd86ba78c902c31effa();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem);
  }
  return s;
}

public static Func<RC_7f2610cf0c5fadd86ba78c902c31effa, ssConectaProveedores.RestRecords.RESTRC_7f2610cf0c5fadd86ba78c902c31effa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f2610cf0c5fadd86ba78c902c31effa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7f2610cf0c5fadd86ba78c902c31effa FromStructure(RC_7f2610cf0c5fadd86ba78c902c31effa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7f2610cf0c5fadd86ba78c902c31effa(s, config);
}

}


