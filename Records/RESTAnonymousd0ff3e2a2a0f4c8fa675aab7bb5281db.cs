using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccConceptsAccountingDataTypeRecord
public class RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e : AbstractRESTStructure<RC_f80fde4acf9a7dc465a1d535c05dfb8e> {
[JsonProperty("RequisitionAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord AttrRequisitionAccConcepts;

[JsonProperty("AccountingDataType")]
public ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e() { }

public RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e (RC_f80fde4acf9a7dc465a1d535c05dfb8e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccConcepts = ConvertToRestWithoutDefaults(s.ssENRequisitionAccConcepts, new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.FromStructure(s.ssENRequisitionAccConcepts, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static RC_f80fde4acf9a7dc465a1d535c05dfb8e ToStructure(ssConectaProveedores.RestRecords.RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e obj) { 
  RC_f80fde4acf9a7dc465a1d535c05dfb8e s = new RC_f80fde4acf9a7dc465a1d535c05dfb8e();
  if(obj != null) {
  s.ssENRequisitionAccConcepts = ssConectaProveedores.RestRecords.RESTEN_e5ff66566e5f431d75aae3b3535726a7EntityRecord.ToStructure(obj.AttrRequisitionAccConcepts);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType);
  }
  return s;
}

public static Func<RC_f80fde4acf9a7dc465a1d535c05dfb8e, ssConectaProveedores.RestRecords.RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f80fde4acf9a7dc465a1d535c05dfb8e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e FromStructure(RC_f80fde4acf9a7dc465a1d535c05dfb8e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f80fde4acf9a7dc465a1d535c05dfb8e(s, config);
}

}


