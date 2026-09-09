using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StepUsersRecord
public class RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf : AbstractRESTStructure<RC_2d3f02da87e3ed9a7fb846204a77cfbf> {
[JsonProperty("StepUsers")]
public ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure AttrStepUsers;

public RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf() { }

public RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf (RC_2d3f02da87e3ed9a7fb846204a77cfbf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStepUsers = ConvertToRestWithoutDefaults(s.ssSTStepUsers, new ST_f14441a8387aba6d017931caef70dd11Structure(), ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure.FromStructure, config);
  } else {
AttrStepUsers = ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure.FromStructure(s.ssSTStepUsers, config);
  }
}

public static RC_2d3f02da87e3ed9a7fb846204a77cfbf ToStructure(ssConectaProveedores.RestRecords.RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf obj) { 
  RC_2d3f02da87e3ed9a7fb846204a77cfbf s = new RC_2d3f02da87e3ed9a7fb846204a77cfbf();
  if(obj != null) {
  s.ssSTStepUsers = ssConectaProveedores.RestRecords.RESTST_f14441a8387aba6d017931caef70dd11Structure.ToStructure(obj.AttrStepUsers);
  }
  return s;
}

public static Func<RC_2d3f02da87e3ed9a7fb846204a77cfbf, ssConectaProveedores.RestRecords.RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2d3f02da87e3ed9a7fb846204a77cfbf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf FromStructure(RC_2d3f02da87e3ed9a7fb846204a77cfbf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2d3f02da87e3ed9a7fb846204a77cfbf(s, config);
}

}


