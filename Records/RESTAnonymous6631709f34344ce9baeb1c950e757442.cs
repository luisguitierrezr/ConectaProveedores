using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicePolizaStorageRecord
public class RESTRC_285d5103004edd69f9105c056eb9d2a6 : AbstractRESTStructure<RC_285d5103004edd69f9105c056eb9d2a6> {
[JsonProperty("InvoicePolizaStorage")]
public ssConectaProveedores.RestRecords.RESTEN_c914a6fdb165c9751808adf2e01e2226EntityRecord AttrInvoicePolizaStorage;

public RESTRC_285d5103004edd69f9105c056eb9d2a6() { }

public RESTRC_285d5103004edd69f9105c056eb9d2a6 (RC_285d5103004edd69f9105c056eb9d2a6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicePolizaStorage = ConvertToRestWithoutDefaults(s.ssENInvoicePolizaStorage, new EN_c914a6fdb165c9751808adf2e01e2226EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c914a6fdb165c9751808adf2e01e2226EntityRecord.FromStructure, config);
  } else {
AttrInvoicePolizaStorage = ssConectaProveedores.RestRecords.RESTEN_c914a6fdb165c9751808adf2e01e2226EntityRecord.FromStructure(s.ssENInvoicePolizaStorage, config);
  }
}

public static RC_285d5103004edd69f9105c056eb9d2a6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_285d5103004edd69f9105c056eb9d2a6 obj) { 
  RC_285d5103004edd69f9105c056eb9d2a6 s = new RC_285d5103004edd69f9105c056eb9d2a6();
  if(obj != null) {
  s.ssENInvoicePolizaStorage = ssConectaProveedores.RestRecords.RESTEN_c914a6fdb165c9751808adf2e01e2226EntityRecord.ToStructure(obj.AttrInvoicePolizaStorage);
  }
  return s;
}

public static Func<RC_285d5103004edd69f9105c056eb9d2a6, ssConectaProveedores.RestRecords.RESTRC_285d5103004edd69f9105c056eb9d2a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_285d5103004edd69f9105c056eb9d2a6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_285d5103004edd69f9105c056eb9d2a6 FromStructure(RC_285d5103004edd69f9105c056eb9d2a6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_285d5103004edd69f9105c056eb9d2a6(s, config);
}

}


