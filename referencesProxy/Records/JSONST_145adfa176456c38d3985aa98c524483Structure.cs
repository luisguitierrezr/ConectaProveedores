using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM_RM
public class JSONST_145adfa176456c38d3985aa98c524483Structure : AbstractRESTStructure<ST_145adfa176456c38d3985aa98c524483Structure> {
[JsonProperty("item")]
[JsonPropertyName("item")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure[] AttrItem;

public JSONST_145adfa176456c38d3985aa98c524483Structure() { }

public JSONST_145adfa176456c38d3985aa98c524483Structure (ST_145adfa176456c38d3985aa98c524483Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure, ST_145adfa176456c38d3985aa98c524483Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure s) => ToStructure(s, config);
}
public static ST_145adfa176456c38d3985aa98c524483Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure obj, IBehaviorsConfiguration config) { 
  ST_145adfa176456c38d3985aa98c524483Structure s = new ST_145adfa176456c38d3985aa98c524483Structure();
  if(obj != null) {
  s.ssItem = RL_943f32302be61b51261512f4da403b2f.ToList(obj.AttrItem, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c6a30ab803e481b26794961e87468e52Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_145adfa176456c38d3985aa98c524483Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_145adfa176456c38d3985aa98c524483Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure FromStructure(ST_145adfa176456c38d3985aa98c524483Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure(s, config);
}

}


