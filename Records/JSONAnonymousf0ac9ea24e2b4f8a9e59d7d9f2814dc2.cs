using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionList_StructRecord
public class JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0 : AbstractRESTStructure<RC_a6a6e5f593e9e8b5f977af7779bd66f0> {
[JsonProperty("RequisitionList_Struct")]
[JsonPropertyName("RequisitionList_Struct")]
public ssConectaProveedores.RestRecords.JSONST_23b064f7387b135df7725dcd963884ceStructure AttrRequisitionList_Struct;

public JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0() { }

public JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0 (RC_a6a6e5f593e9e8b5f977af7779bd66f0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionList_Struct = ConvertToRestWithoutDefaults(s.ssSTRequisitionList_Struct, new ST_23b064f7387b135df7725dcd963884ceStructure(), ssConectaProveedores.RestRecords.JSONST_23b064f7387b135df7725dcd963884ceStructure.FromStructure, config);
  } else {
AttrRequisitionList_Struct = ssConectaProveedores.RestRecords.JSONST_23b064f7387b135df7725dcd963884ceStructure.FromStructure(s.ssSTRequisitionList_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0, RC_a6a6e5f593e9e8b5f977af7779bd66f0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0 s) => ToStructure(s, config);
}
public static RC_a6a6e5f593e9e8b5f977af7779bd66f0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0 obj, IBehaviorsConfiguration config) { 
  RC_a6a6e5f593e9e8b5f977af7779bd66f0 s = new RC_a6a6e5f593e9e8b5f977af7779bd66f0();
  if(obj != null) {
  s.ssSTRequisitionList_Struct = ssConectaProveedores.RestRecords.JSONST_23b064f7387b135df7725dcd963884ceStructure.ToStructure(obj.AttrRequisitionList_Struct, config);
  }
  return s;
}

public static Func<RC_a6a6e5f593e9e8b5f977af7779bd66f0, ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6a6e5f593e9e8b5f977af7779bd66f0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0 FromStructure(RC_a6a6e5f593e9e8b5f977af7779bd66f0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a6a6e5f593e9e8b5f977af7779bd66f0(s, config);
}

}


