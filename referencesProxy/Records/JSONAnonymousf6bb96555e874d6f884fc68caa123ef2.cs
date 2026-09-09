using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SideMenuBehaviorRecord
public class JSONRC_e3607d6b92545e5793fbeb99fc16b7e7 : AbstractRESTStructure<RC_e3607d6b92545e5793fbeb99fc16b7e7> {
[JsonProperty("SideMenuBehavior")]
[JsonPropertyName("SideMenuBehavior")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord AttrSideMenuBehavior;

public JSONRC_e3607d6b92545e5793fbeb99fc16b7e7() { }

public JSONRC_e3607d6b92545e5793fbeb99fc16b7e7 (RC_e3607d6b92545e5793fbeb99fc16b7e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSideMenuBehavior = ConvertToRestWithoutDefaults(s.ssENSideMenuBehavior, new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.FromStructure, config);
  } else {
AttrSideMenuBehavior = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.FromStructure(s.ssENSideMenuBehavior, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7, RC_e3607d6b92545e5793fbeb99fc16b7e7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7 s) => ToStructure(s, config);
}
public static RC_e3607d6b92545e5793fbeb99fc16b7e7 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7 obj, IBehaviorsConfiguration config) { 
  RC_e3607d6b92545e5793fbeb99fc16b7e7 s = new RC_e3607d6b92545e5793fbeb99fc16b7e7();
  if(obj != null) {
  s.ssENSideMenuBehavior = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord.ToStructure(obj.AttrSideMenuBehavior, config);
  }
  return s;
}

public static Func<RC_e3607d6b92545e5793fbeb99fc16b7e7, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3607d6b92545e5793fbeb99fc16b7e7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7 FromStructure(RC_e3607d6b92545e5793fbeb99fc16b7e7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_e3607d6b92545e5793fbeb99fc16b7e7(s, config);
}

}


