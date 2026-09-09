using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// VirtualStore
public class JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord : AbstractRESTStructure<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

public JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord() { }

public JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord, EN_7880828d2b18947e22126c6c81b5d72dEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord s) => ToStructure(s, config);
}
public static EN_7880828d2b18947e22126c6c81b5d72dEntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s = new EN_7880828d2b18947e22126c6c81b5d72dEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  }
  return s;
}

public static Func<EN_7880828d2b18947e22126c6c81b5d72dEntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord FromStructure(EN_7880828d2b18947e22126c6c81b5d72dEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7880828d2b18947e22126c6c81b5d72dEntityRecord(s, config);
}

}


