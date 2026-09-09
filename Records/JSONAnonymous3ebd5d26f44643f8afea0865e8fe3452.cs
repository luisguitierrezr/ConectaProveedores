using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierDetailRecord
public class JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684 : AbstractRESTStructure<RC_2a6a47a042b2e84eddb6ad9d86f0a684> {
[JsonProperty("SupplierDetail")]
[JsonPropertyName("SupplierDetail")]
public ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord AttrSupplierDetail;

public JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684() { }

public JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684 (RC_2a6a47a042b2e84eddb6ad9d86f0a684 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSupplierDetail = ConvertToRestWithoutDefaults(s.ssENSupplierDetail, new EN_57ee0c02163ab55038103469b2569162EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure, config);
  } else {
AttrSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.FromStructure(s.ssENSupplierDetail, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684, RC_2a6a47a042b2e84eddb6ad9d86f0a684> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684 s) => ToStructure(s, config);
}
public static RC_2a6a47a042b2e84eddb6ad9d86f0a684 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684 obj, IBehaviorsConfiguration config) { 
  RC_2a6a47a042b2e84eddb6ad9d86f0a684 s = new RC_2a6a47a042b2e84eddb6ad9d86f0a684();
  if(obj != null) {
  s.ssENSupplierDetail = ssConectaProveedores.RestRecords.JSONEN_57ee0c02163ab55038103469b2569162EntityRecord.ToStructure(obj.AttrSupplierDetail, config);
  }
  return s;
}

public static Func<RC_2a6a47a042b2e84eddb6ad9d86f0a684, ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a6a47a042b2e84eddb6ad9d86f0a684 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684 FromStructure(RC_2a6a47a042b2e84eddb6ad9d86f0a684 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2a6a47a042b2e84eddb6ad9d86f0a684(s, config);
}

}


