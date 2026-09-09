using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionList_StructMobileRecord
public class JSONRC_c4f3f57be4398f0d8a99656890ed9dae : AbstractRESTStructure<RC_c4f3f57be4398f0d8a99656890ed9dae> {
[JsonProperty("RequisitionList_StructMobile")]
[JsonPropertyName("RequisitionList_StructMobile")]
public ssConectaProveedores.RestRecords.JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure AttrRequisitionList_StructMobile;

public JSONRC_c4f3f57be4398f0d8a99656890ed9dae() { }

public JSONRC_c4f3f57be4398f0d8a99656890ed9dae (RC_c4f3f57be4398f0d8a99656890ed9dae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionList_StructMobile = ConvertToRestWithoutDefaults(s.ssSTRequisitionList_StructMobile, new ST_93db82ada2d57fd9d5e68feb0d1d4360Structure(), ssConectaProveedores.RestRecords.JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure.FromStructure, config);
  } else {
AttrRequisitionList_StructMobile = ssConectaProveedores.RestRecords.JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure.FromStructure(s.ssSTRequisitionList_StructMobile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae, RC_c4f3f57be4398f0d8a99656890ed9dae> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae s) => ToStructure(s, config);
}
public static RC_c4f3f57be4398f0d8a99656890ed9dae ToStructure(ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae obj, IBehaviorsConfiguration config) { 
  RC_c4f3f57be4398f0d8a99656890ed9dae s = new RC_c4f3f57be4398f0d8a99656890ed9dae();
  if(obj != null) {
  s.ssSTRequisitionList_StructMobile = ssConectaProveedores.RestRecords.JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure.ToStructure(obj.AttrRequisitionList_StructMobile, config);
  }
  return s;
}

public static Func<RC_c4f3f57be4398f0d8a99656890ed9dae, ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c4f3f57be4398f0d8a99656890ed9dae s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae FromStructure(RC_c4f3f57be4398f0d8a99656890ed9dae s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c4f3f57be4398f0d8a99656890ed9dae(s, config);
}

}


