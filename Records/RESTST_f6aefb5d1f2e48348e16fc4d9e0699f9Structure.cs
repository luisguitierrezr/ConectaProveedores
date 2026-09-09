using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_CECO
public class RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure : AbstractRESTStructure<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> {
[JsonProperty("Item")]
public RestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure> AttrItem;

public RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure() { }

public RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  }
}

public static ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure obj) { 
  ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure s = new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure();
  if(obj != null) {
  s.ssItem = RL_e2d9cd11480e1409ddda73914c4a2843.FromRestList(obj.AttrItem, ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.ToStructure);
  }
  return s;
}

public static Func<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure, ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure FromStructure(ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure(s, config);
}

}


