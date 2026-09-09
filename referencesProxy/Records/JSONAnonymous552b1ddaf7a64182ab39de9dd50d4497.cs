using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_CECO_COSMOZ_Request_StructRecord
public class JSONRC_d41fc9ae6fb400f4fec40304f5250129 : AbstractRESTStructure<RC_d41fc9ae6fb400f4fec40304f5250129> {
[JsonProperty("EM_SM_CECO_COSMOZ_Request_Struct")]
[JsonPropertyName("EM_SM_CECO_COSMOZ_Request_Struct")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure AttrEM_SM_CECO_COSMOZ_Request_Struct;

public JSONRC_d41fc9ae6fb400f4fec40304f5250129() { }

public JSONRC_d41fc9ae6fb400f4fec40304f5250129 (RC_d41fc9ae6fb400f4fec40304f5250129 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_CECO_COSMOZ_Request_Struct, new ST_883584831b34399a326748c4b1ce95c9Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.FromStructure(s.ssSTEM_SM_CECO_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129, RC_d41fc9ae6fb400f4fec40304f5250129> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129 s) => ToStructure(s, config);
}
public static RC_d41fc9ae6fb400f4fec40304f5250129 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129 obj, IBehaviorsConfiguration config) { 
  RC_d41fc9ae6fb400f4fec40304f5250129 s = new RC_d41fc9ae6fb400f4fec40304f5250129();
  if(obj != null) {
  s.ssSTEM_SM_CECO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<RC_d41fc9ae6fb400f4fec40304f5250129, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d41fc9ae6fb400f4fec40304f5250129 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129 FromStructure(RC_d41fc9ae6fb400f4fec40304f5250129 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_d41fc9ae6fb400f4fec40304f5250129(s, config);
}

}


