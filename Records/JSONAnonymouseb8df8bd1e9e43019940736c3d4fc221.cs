using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReassignmentsRecord
public class JSONRC_c9394e1c31772209550f46c7f600d6ee : AbstractRESTStructure<RC_c9394e1c31772209550f46c7f600d6ee> {
[JsonProperty("Reassignments")]
[JsonPropertyName("Reassignments")]
public ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

public JSONRC_c9394e1c31772209550f46c7f600d6ee() { }

public JSONRC_c9394e1c31772209550f46c7f600d6ee (RC_c9394e1c31772209550f46c7f600d6ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
  } else {
AttrReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee, RC_c9394e1c31772209550f46c7f600d6ee> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee s) => ToStructure(s, config);
}
public static RC_c9394e1c31772209550f46c7f600d6ee ToStructure(ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee obj, IBehaviorsConfiguration config) { 
  RC_c9394e1c31772209550f46c7f600d6ee s = new RC_c9394e1c31772209550f46c7f600d6ee();
  if(obj != null) {
  s.ssENReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments, config);
  }
  return s;
}

public static Func<RC_c9394e1c31772209550f46c7f600d6ee, ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c9394e1c31772209550f46c7f600d6ee s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee FromStructure(RC_c9394e1c31772209550f46c7f600d6ee s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c9394e1c31772209550f46c7f600d6ee(s, config);
}

}


