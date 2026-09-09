using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_EM4
public class JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure : AbstractRESTStructure<ST_5f3e5a981bd9e9a45ed03e989538932dStructure> {
[JsonProperty("item")]
[JsonPropertyName("item")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure[] AttrItem;

public JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure() { }

public JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure (ST_5f3e5a981bd9e9a45ed03e989538932dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure, ST_5f3e5a981bd9e9a45ed03e989538932dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure s) => ToStructure(s, config);
}
public static ST_5f3e5a981bd9e9a45ed03e989538932dStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure obj, IBehaviorsConfiguration config) { 
  ST_5f3e5a981bd9e9a45ed03e989538932dStructure s = new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();
  if(obj != null) {
  s.ssItem = RL_e2d9cd11480e1409ddda73914c4a2843.ToList(obj.AttrItem, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6a8665543a0f720f26db84a82f35885fStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_5f3e5a981bd9e9a45ed03e989538932dStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5f3e5a981bd9e9a45ed03e989538932dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure FromStructure(ST_5f3e5a981bd9e9a45ed03e989538932dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5f3e5a981bd9e9a45ed03e989538932dStructure(s, config);
}

}


