using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierDetailRecord
public class RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684 : AbstractRESTStructure<RC_2a6a47a042b2e84eddb6ad9d86f0a684> {
[JsonProperty("SupplierDetail")]
public ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

public RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684() { }

public RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684 (RC_2a6a47a042b2e84eddb6ad9d86f0a684 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
  } else {
AttrSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
  }
}

public static RC_2a6a47a042b2e84eddb6ad9d86f0a684 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684 obj) { 
  RC_2a6a47a042b2e84eddb6ad9d86f0a684 s = new RC_2a6a47a042b2e84eddb6ad9d86f0a684();
  if(obj != null) {
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.RESTEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail);
  }
  return s;
}

public static Func<RC_2a6a47a042b2e84eddb6ad9d86f0a684, ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a6a47a042b2e84eddb6ad9d86f0a684 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684 FromStructure(RC_2a6a47a042b2e84eddb6ad9d86f0a684 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684(s, config);
}

}


