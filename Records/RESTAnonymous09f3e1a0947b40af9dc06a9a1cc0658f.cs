using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionRequisitionStatusDistributionFrequencyRecord
public class RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 : AbstractRESTStructure<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionStatus")]
public ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord AttrRequisitionStatus;

[JsonProperty("Distribution")]
public ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord AttrDistribution;

[JsonProperty("Frequency")]
public ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord AttrFrequency;

public RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9() { }

public RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionStatus = ConvertToRestWithoutDefaults(s.ssENRequisitionStatus, new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure, config);
AttrDistribution = ConvertToRestWithoutDefaults(s.ssENDistribution, new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure, config);
AttrFrequency = ConvertToRestWithoutDefaults(s.ssENFrequency, new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure, config);
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.FromStructure(s.ssENRequisitionStatus, config);
AttrDistribution = ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.FromStructure(s.ssENDistribution, config);
AttrFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.FromStructure(s.ssENFrequency, config);
  }
}

public static RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 obj) { 
  RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s = new RC_7fadf2cbff2fecd5fbe9b2e13c5588e9();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionStatus = ssConectaProveedores.RestRecords.RESTEN_0554a1252840ba4a5c4e6af5899608adEntityRecord.ToStructure(obj.AttrRequisitionStatus);
  s.ssENDistribution = ssConectaProveedores.RestRecords.RESTEN_88460e7eac2a65d244abb23fe44af0adEntityRecord.ToStructure(obj.AttrDistribution);
  s.ssENFrequency = ssConectaProveedores.RestRecords.RESTEN_a6239c65aa61ed4530d18a92034301bbEntityRecord.ToStructure(obj.AttrFrequency);
  }
  return s;
}

public static Func<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9, ssConectaProveedores.RestRecords.RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9 FromStructure(RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7fadf2cbff2fecd5fbe9b2e13c5588e9(s, config);
}

}


