using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedMoreChargesRecord
public class RESTRC_152a5bcdbf970bfba2a0da40766a2168 : AbstractRESTStructure<RC_152a5bcdbf970bfba2a0da40766a2168> {
[JsonProperty("InvoiceExtendedMoreCharges")]
public ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord AttrInvoiceExtendedMoreCharges;

public RESTRC_152a5bcdbf970bfba2a0da40766a2168() { }

public RESTRC_152a5bcdbf970bfba2a0da40766a2168 (RC_152a5bcdbf970bfba2a0da40766a2168 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedMoreCharges = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedMoreCharges, new EN_a9440c310249b67518f0615139b4c690EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedMoreCharges = ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord.FromStructure(s.ssENInvoiceExtendedMoreCharges, config);
  }
}

public static RC_152a5bcdbf970bfba2a0da40766a2168 ToStructure(ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168 obj) { 
  RC_152a5bcdbf970bfba2a0da40766a2168 s = new RC_152a5bcdbf970bfba2a0da40766a2168();
  if(obj != null) {
  s.ssENInvoiceExtendedMoreCharges = ssConectaProveedores.RestRecords.RESTEN_a9440c310249b67518f0615139b4c690EntityRecord.ToStructure(obj.AttrInvoiceExtendedMoreCharges);
  }
  return s;
}

public static Func<RC_152a5bcdbf970bfba2a0da40766a2168, ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_152a5bcdbf970bfba2a0da40766a2168 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168 FromStructure(RC_152a5bcdbf970bfba2a0da40766a2168 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_152a5bcdbf970bfba2a0da40766a2168(s, config);
}

}


