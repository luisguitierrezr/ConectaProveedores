using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedForeignerRecord
public class RESTRC_decbed55750bb4030b04e46c0306e56b : AbstractRESTStructure<RC_decbed55750bb4030b04e46c0306e56b> {
[JsonProperty("InvoiceExtendedForeigner")]
public ssConectaProveedores.RestRecords.RESTEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord AttrInvoiceExtendedForeigner;

public RESTRC_decbed55750bb4030b04e46c0306e56b() { }

public RESTRC_decbed55750bb4030b04e46c0306e56b (RC_decbed55750bb4030b04e46c0306e56b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedForeigner = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedForeigner, new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedForeigner = ssConectaProveedores.RestRecords.RESTEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.FromStructure(s.ssENInvoiceExtendedForeigner, config);
  }
}

public static RC_decbed55750bb4030b04e46c0306e56b ToStructure(ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b obj) { 
  RC_decbed55750bb4030b04e46c0306e56b s = new RC_decbed55750bb4030b04e46c0306e56b();
  if(obj != null) {
  s.ssENInvoiceExtendedForeigner = ssConectaProveedores.RestRecords.RESTEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.ToStructure(obj.AttrInvoiceExtendedForeigner);
  }
  return s;
}

public static Func<RC_decbed55750bb4030b04e46c0306e56b, ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_decbed55750bb4030b04e46c0306e56b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b FromStructure(RC_decbed55750bb4030b04e46c0306e56b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_decbed55750bb4030b04e46c0306e56b(s, config);
}

}


