using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// VirtualStore
public class RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord : AbstractRESTStructure<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("RegionId")]
public long? AttrRegionId;

public RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord() { }

public RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrRegionId = (long?) s.ssRegionId;
  }
}

public static EN_7880828d2b18947e22126c6c81b5d72dEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord obj) { 
  EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s = new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord, ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord FromStructure(EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_7880828d2b18947e22126c6c81b5d72dEntityRecord(s, config);
}

}


