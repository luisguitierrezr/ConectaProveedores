using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionStatusDistributionFrequencyRecord
public class JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 : AbstractRESTStructure<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionStatus")]
[JsonPropertyName("RequisitionStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

[JsonProperty("Distribution")]
[JsonPropertyName("Distribution")]
public ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord AttrDistribution;

[JsonProperty("Frequency")]
[JsonPropertyName("Frequency")]
public ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

public JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9() { }

public JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
AttrDistribution = ConvertToRestWithoutDefaults(s.ssENDistribution, new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
AttrDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure(s.ssENDistribution, config);
AttrFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9, RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s) => ToStructure(s, config);
}
public static RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 obj, IBehaviorsConfiguration config) { 
  RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s = new RC_7fadf2cbff2fecd5fbe9b2e13c5588e9();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.JSONEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus, config);
  s.ssENDistribution = ssConectaProveedores.RestRecords.JSONEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.ToStructure(obj.AttrDistribution, config);
  s.ssENFrequency = ssConectaProveedores.RestRecords.JSONEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency, config);
  }
  return s;
}

public static Func<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9, ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 FromStructure(RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7fadf2cbff2fecd5fbe9b2e13c5588e9(s, config);
}

}


