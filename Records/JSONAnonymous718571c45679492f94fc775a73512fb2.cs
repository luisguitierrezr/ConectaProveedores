using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionContractFileRecord
public class JSONRC_471ec64149613ec0a9f3525fc2d9e11c : AbstractRESTStructure<RC_471ec64149613ec0a9f3525fc2d9e11c> {
[JsonProperty("RequisitionContractFile")]
[JsonPropertyName("RequisitionContractFile")]
public ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord AttrRequisitionContractFile;

public JSONRC_471ec64149613ec0a9f3525fc2d9e11c() { }

public JSONRC_471ec64149613ec0a9f3525fc2d9e11c (RC_471ec64149613ec0a9f3525fc2d9e11c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionContractFile = ConvertToRestWithoutDefaults(s.ssENRequisitionContractFile, new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure, config);
  } else {
AttrRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.FromStructure(s.ssENRequisitionContractFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c, RC_471ec64149613ec0a9f3525fc2d9e11c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c s) => ToStructure(s, config);
}
public static RC_471ec64149613ec0a9f3525fc2d9e11c ToStructure(ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c obj, IBehaviorsConfiguration config) { 
  RC_471ec64149613ec0a9f3525fc2d9e11c s = new RC_471ec64149613ec0a9f3525fc2d9e11c();
  if(obj != null) {
  s.ssENRequisitionContractFile = ssConectaProveedores.RestRecords.JSONEN_aeab0089a9236dfc6c684ea98f650647EntityRecord.ToStructure(obj.AttrRequisitionContractFile, config);
  }
  return s;
}

public static Func<RC_471ec64149613ec0a9f3525fc2d9e11c, ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_471ec64149613ec0a9f3525fc2d9e11c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c FromStructure(RC_471ec64149613ec0a9f3525fc2d9e11c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_471ec64149613ec0a9f3525fc2d9e11c(s, config);
}

}


