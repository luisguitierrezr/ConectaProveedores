using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedMoreChargesRecord
public class JSONRC_152a5bcdbf970bfba2a0da40766a2168 : AbstractRESTStructure<RC_152a5bcdbf970bfba2a0da40766a2168> {
[JsonProperty("InvoiceExtendedMoreCharges")]
[JsonPropertyName("InvoiceExtendedMoreCharges")]
public ssConectaProveedores.RestRecords.JSONEN_a9440c310249b67518f0615139b4c690EntityRecord AttrInvoiceExtendedMoreCharges;

public JSONRC_152a5bcdbf970bfba2a0da40766a2168() { }

public JSONRC_152a5bcdbf970bfba2a0da40766a2168 (RC_152a5bcdbf970bfba2a0da40766a2168 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedMoreCharges = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedMoreCharges, new EN_a9440c310249b67518f0615139b4c690EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a9440c310249b67518f0615139b4c690EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedMoreCharges = ssConectaProveedores.RestRecords.JSONEN_a9440c310249b67518f0615139b4c690EntityRecord.FromStructure(s.ssENInvoiceExtendedMoreCharges, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168, RC_152a5bcdbf970bfba2a0da40766a2168> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168 s) => ToStructure(s, config);
}
public static RC_152a5bcdbf970bfba2a0da40766a2168 ToStructure(ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168 obj, IBehaviorsConfiguration config) { 
  RC_152a5bcdbf970bfba2a0da40766a2168 s = new RC_152a5bcdbf970bfba2a0da40766a2168();
  if(obj != null) {
  s.ssENInvoiceExtendedMoreCharges = ssConectaProveedores.RestRecords.JSONEN_a9440c310249b67518f0615139b4c690EntityRecord.ToStructure(obj.AttrInvoiceExtendedMoreCharges, config);
  }
  return s;
}

public static Func<RC_152a5bcdbf970bfba2a0da40766a2168, ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_152a5bcdbf970bfba2a0da40766a2168 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168 FromStructure(RC_152a5bcdbf970bfba2a0da40766a2168 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_152a5bcdbf970bfba2a0da40766a2168(s, config);
}

}


