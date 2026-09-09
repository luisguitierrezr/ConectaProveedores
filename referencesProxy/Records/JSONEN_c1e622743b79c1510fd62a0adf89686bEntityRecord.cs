using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SideMenuBehavior
public class JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord : AbstractRESTStructure<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> {
[JsonProperty("SideMenuBehavior")]
[JsonPropertyName("SideMenuBehavior")]
public string AttrSideMenuBehavior;

public JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord() { }

public JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSideMenuBehavior = s.ssSideMenuBehavior;
  } else {
AttrSideMenuBehavior = s.ssSideMenuBehavior;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord, EN_c1e622743b79c1510fd62a0adf89686bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord s) => ToStructure(s, config);
}
public static EN_c1e622743b79c1510fd62a0adf89686bEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s = new EN_c1e622743b79c1510fd62a0adf89686bEntityRecord();
  if(obj != null) {
  s.ssSideMenuBehavior = obj.AttrSideMenuBehavior == null ? "" : obj.AttrSideMenuBehavior;
  }
  return s;
}

public static Func<EN_c1e622743b79c1510fd62a0adf89686bEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord FromStructure(EN_c1e622743b79c1510fd62a0adf89686bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_c1e622743b79c1510fd62a0adf89686bEntityRecord(s, config);
}

}


