using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicePolizaRecord
public class RESTRC_14fd6714905cc16780383cc2da86ee0d : AbstractRESTStructure<RC_14fd6714905cc16780383cc2da86ee0d> {
[JsonProperty("InvoicePoliza")]
public ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord AttrInvoicePoliza;

public RESTRC_14fd6714905cc16780383cc2da86ee0d() { }

public RESTRC_14fd6714905cc16780383cc2da86ee0d (RC_14fd6714905cc16780383cc2da86ee0d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicePoliza = ConvertToRestWithoutDefaults(s.ssENInvoicePoliza, new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure, config);
  } else {
AttrInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.FromStructure(s.ssENInvoicePoliza, config);
  }
}

public static RC_14fd6714905cc16780383cc2da86ee0d ToStructure(ssConectaProveedores.RestRecords.RESTRC_14fd6714905cc16780383cc2da86ee0d obj) { 
  RC_14fd6714905cc16780383cc2da86ee0d s = new RC_14fd6714905cc16780383cc2da86ee0d();
  if(obj != null) {
  s.ssENInvoicePoliza = ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord.ToStructure(obj.AttrInvoicePoliza);
  }
  return s;
}

public static Func<RC_14fd6714905cc16780383cc2da86ee0d, ssConectaProveedores.RestRecords.RESTRC_14fd6714905cc16780383cc2da86ee0d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_14fd6714905cc16780383cc2da86ee0d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_14fd6714905cc16780383cc2da86ee0d FromStructure(RC_14fd6714905cc16780383cc2da86ee0d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_14fd6714905cc16780383cc2da86ee0d(s, config);
}

}


