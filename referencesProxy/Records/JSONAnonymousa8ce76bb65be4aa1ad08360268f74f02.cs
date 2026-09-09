using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// VirtualStoreRecord
public class JSONRC_549f08e709528a6bf28106addf9f0382 : AbstractRESTStructure<RC_549f08e709528a6bf28106addf9f0382> {
[JsonProperty("VirtualStore")]
[JsonPropertyName("VirtualStore")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord AttrVirtualStore;

public JSONRC_549f08e709528a6bf28106addf9f0382() { }

public JSONRC_549f08e709528a6bf28106addf9f0382 (RC_549f08e709528a6bf28106addf9f0382 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVirtualStore = ConvertToRestWithoutDefaults(s.ssENVirtualStore, new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.FromStructure, config);
  } else {
AttrVirtualStore = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.FromStructure(s.ssENVirtualStore, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382, RC_549f08e709528a6bf28106addf9f0382> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382 s) => ToStructure(s, config);
}
public static RC_549f08e709528a6bf28106addf9f0382 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382 obj, IBehaviorsConfiguration config) { 
  RC_549f08e709528a6bf28106addf9f0382 s = new RC_549f08e709528a6bf28106addf9f0382();
  if(obj != null) {
  s.ssENVirtualStore = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.ToStructure(obj.AttrVirtualStore, config);
  }
  return s;
}

public static Func<RC_549f08e709528a6bf28106addf9f0382, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_549f08e709528a6bf28106addf9f0382 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382 FromStructure(RC_549f08e709528a6bf28106addf9f0382 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_549f08e709528a6bf28106addf9f0382(s, config);
}

}


