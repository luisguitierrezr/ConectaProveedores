using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM_RM
public class RESTST_145adfa176456c38d3985aa98c524483Structure : AbstractRESTStructure<ST_145adfa176456c38d3985aa98c524483Structure> {
[JsonProperty("Item")]
public RestList<ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure> AttrItem;

public RESTST_145adfa176456c38d3985aa98c524483Structure() { }

public RESTST_145adfa176456c38d3985aa98c524483Structure (ST_145adfa176456c38d3985aa98c524483Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure>(ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure>(ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure.FromStructureDelegate(config));
  }
}

public static ST_145adfa176456c38d3985aa98c524483Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure obj) { 
  ST_145adfa176456c38d3985aa98c524483Structure s = new ST_145adfa176456c38d3985aa98c524483Structure();
  if(obj != null) {
  s.ssItem = RL_943f32302be61b51261512f4da403b2f.FromRestList(obj.AttrItem, ssConectaProveedores.RestRecords.RESTST_c6a30ab803e481b26794961e87468e52Structure.ToStructure);
  }
  return s;
}

public static Func<ST_145adfa176456c38d3985aa98c524483Structure, ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_145adfa176456c38d3985aa98c524483Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure FromStructure(ST_145adfa176456c38d3985aa98c524483Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure(s, config);
}

}


