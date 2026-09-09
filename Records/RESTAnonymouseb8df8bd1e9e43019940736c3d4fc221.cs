using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReassignmentsRecord
public class RESTRC_c9394e1c31772209550f46c7f600d6ee : AbstractRESTStructure<RC_c9394e1c31772209550f46c7f600d6ee> {
[JsonProperty("Reassignments")]
public ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

public RESTRC_c9394e1c31772209550f46c7f600d6ee() { }

public RESTRC_c9394e1c31772209550f46c7f600d6ee (RC_c9394e1c31772209550f46c7f600d6ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
  } else {
AttrReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
  }
}

public static RC_c9394e1c31772209550f46c7f600d6ee ToStructure(ssConectaProveedores.RestRecords.RESTRC_c9394e1c31772209550f46c7f600d6ee obj) { 
  RC_c9394e1c31772209550f46c7f600d6ee s = new RC_c9394e1c31772209550f46c7f600d6ee();
  if(obj != null) {
  s.ssENReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments);
  }
  return s;
}

public static Func<RC_c9394e1c31772209550f46c7f600d6ee, ssConectaProveedores.RestRecords.RESTRC_c9394e1c31772209550f46c7f600d6ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c9394e1c31772209550f46c7f600d6ee s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c9394e1c31772209550f46c7f600d6ee FromStructure(RC_c9394e1c31772209550f46c7f600d6ee s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c9394e1c31772209550f46c7f600d6ee(s, config);
}

}


