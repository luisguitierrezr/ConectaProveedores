using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM4
public class RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure : AbstractRESTStructure<ST_5f3e5a981bd9e9a45ed03e989538932dStructure> {
[JsonProperty("Item")]
public RestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure> AttrItem;

public RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure() { }

public RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure (ST_5f3e5a981bd9e9a45ed03e989538932dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  }
}

public static ST_5f3e5a981bd9e9a45ed03e989538932dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure obj) { 
  ST_5f3e5a981bd9e9a45ed03e989538932dStructure s = new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();
  if(obj != null) {
  s.ssItem = RL_e2d9cd11480e1409ddda73914c4a2843.FromRestList(obj.AttrItem, ssConectaProveedores.RestRecords.RESTST_6a8665543a0f720f26db84a82f35885fStructure.ToStructure);
  }
  return s;
}

public static Func<ST_5f3e5a981bd9e9a45ed03e989538932dStructure, ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5f3e5a981bd9e9a45ed03e989538932dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure FromStructure(ST_5f3e5a981bd9e9a45ed03e989538932dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5f3e5a981bd9e9a45ed03e989538932dStructure(s, config);
}

}


