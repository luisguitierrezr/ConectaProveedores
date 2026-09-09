using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StepUsersRecord
public class JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf : AbstractRESTStructure<RC_2d3f02da87e3ed9a7fb846204a77cfbf> {
[JsonProperty("StepUsers")]
[JsonPropertyName("StepUsers")]
public ssConectaProveedores.RestRecords.JSONST_f14441a8387aba6d017931caef70dd11Structure AttrStepUsers;

public JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf() { }

public JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf (RC_2d3f02da87e3ed9a7fb846204a77cfbf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStepUsers = ConvertToRestWithoutDefaults(s.ssSTStepUsers, new ST_f14441a8387aba6d017931caef70dd11Structure(), ssConectaProveedores.RestRecords.JSONST_f14441a8387aba6d017931caef70dd11Structure.FromStructure, config);
  } else {
AttrStepUsers = ssConectaProveedores.RestRecords.JSONST_f14441a8387aba6d017931caef70dd11Structure.FromStructure(s.ssSTStepUsers, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf, RC_2d3f02da87e3ed9a7fb846204a77cfbf> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf s) => ToStructure(s, config);
}
public static RC_2d3f02da87e3ed9a7fb846204a77cfbf ToStructure(ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf obj, IBehaviorsConfiguration config) { 
  RC_2d3f02da87e3ed9a7fb846204a77cfbf s = new RC_2d3f02da87e3ed9a7fb846204a77cfbf();
  if(obj != null) {
  s.ssSTStepUsers = ssConectaProveedores.RestRecords.JSONST_f14441a8387aba6d017931caef70dd11Structure.ToStructure(obj.AttrStepUsers, config);
  }
  return s;
}

public static Func<RC_2d3f02da87e3ed9a7fb846204a77cfbf, ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d3f02da87e3ed9a7fb846204a77cfbf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf FromStructure(RC_2d3f02da87e3ed9a7fb846204a77cfbf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2d3f02da87e3ed9a7fb846204a77cfbf(s, config);
}

}


