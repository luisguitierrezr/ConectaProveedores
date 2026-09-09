using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VirtualStoreRecord
public class RESTRC_549f08e709528a6bf28106addf9f0382 : AbstractRESTStructure<RC_549f08e709528a6bf28106addf9f0382> {
[JsonProperty("VirtualStore")]
public ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord AttrVirtualStore;

public RESTRC_549f08e709528a6bf28106addf9f0382() { }

public RESTRC_549f08e709528a6bf28106addf9f0382 (RC_549f08e709528a6bf28106addf9f0382 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVirtualStore = ConvertToRestWithoutDefaults(s.ssENVirtualStore, new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.FromStructure, config);
  } else {
AttrVirtualStore = ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.FromStructure(s.ssENVirtualStore, config);
  }
}

public static RC_549f08e709528a6bf28106addf9f0382 ToStructure(ssConectaProveedores.RestRecords.RESTRC_549f08e709528a6bf28106addf9f0382 obj) { 
  RC_549f08e709528a6bf28106addf9f0382 s = new RC_549f08e709528a6bf28106addf9f0382();
  if(obj != null) {
  s.ssENVirtualStore = ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord.ToStructure(obj.AttrVirtualStore);
  }
  return s;
}

public static Func<RC_549f08e709528a6bf28106addf9f0382, ssConectaProveedores.RestRecords.RESTRC_549f08e709528a6bf28106addf9f0382> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_549f08e709528a6bf28106addf9f0382 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_549f08e709528a6bf28106addf9f0382 FromStructure(RC_549f08e709528a6bf28106addf9f0382 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_549f08e709528a6bf28106addf9f0382(s, config);
}

}


