using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM_RMRecord
public class RESTRC_f0854a122622e23d0af9485eff078f73 : AbstractRESTStructure<RC_f0854a122622e23d0af9485eff078f73> {
[JsonProperty("PI_ITEM_SM_RM")]
public ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure AttrPI_ITEM_SM_RM;

public RESTRC_f0854a122622e23d0af9485eff078f73() { }

public RESTRC_f0854a122622e23d0af9485eff078f73 (RC_f0854a122622e23d0af9485eff078f73 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM_RM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM_RM, new ST_145adfa176456c38d3985aa98c524483Structure(), ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.FromStructure, config);
  } else {
AttrPI_ITEM_SM_RM = ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.FromStructure(s.ssSTPI_ITEM_SM_RM, config);
  }
}

public static RC_f0854a122622e23d0af9485eff078f73 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f0854a122622e23d0af9485eff078f73 obj) { 
  RC_f0854a122622e23d0af9485eff078f73 s = new RC_f0854a122622e23d0af9485eff078f73();
  if(obj != null) {
  s.ssSTPI_ITEM_SM_RM = ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.ToStructure(obj.AttrPI_ITEM_SM_RM);
  }
  return s;
}

public static Func<RC_f0854a122622e23d0af9485eff078f73, ssConectaProveedores.RestRecords.RESTRC_f0854a122622e23d0af9485eff078f73> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f0854a122622e23d0af9485eff078f73 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f0854a122622e23d0af9485eff078f73 FromStructure(RC_f0854a122622e23d0af9485eff078f73 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f0854a122622e23d0af9485eff078f73(s, config);
}

}


