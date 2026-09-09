using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsAccountingDataTypeRecord
public class JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e : AbstractRESTStructure<RC_f80fde4acf9a7dc465a1d535c05dfb8e> {
[JsonProperty("RequisitionAccConcepts")]
[JsonPropertyName("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e() { }

public JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e (RC_f80fde4acf9a7dc465a1d535c05dfb8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e, RC_f80fde4acf9a7dc465a1d535c05dfb8e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e s) => ToStructure(s, config);
}
public static RC_f80fde4acf9a7dc465a1d535c05dfb8e ToStructure(ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e obj, IBehaviorsConfiguration config) { 
  RC_f80fde4acf9a7dc465a1d535c05dfb8e s = new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.JSONEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts, config);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_f80fde4acf9a7dc465a1d535c05dfb8e, ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f80fde4acf9a7dc465a1d535c05dfb8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e FromStructure(RC_f80fde4acf9a7dc465a1d535c05dfb8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f80fde4acf9a7dc465a1d535c05dfb8e(s, config);
}

}


