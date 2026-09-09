using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StorageIdRecord
public class JSONRC_6d589cc6382d191584ced81e067dc8ba : AbstractRESTStructure<RC_6d589cc6382d191584ced81e067dc8ba> {
[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

public JSONRC_6d589cc6382d191584ced81e067dc8ba() { }

public JSONRC_6d589cc6382d191584ced81e067dc8ba (RC_6d589cc6382d191584ced81e067dc8ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
  } else {
AttrStorageId = (long?) s.ssStorageId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba, RC_6d589cc6382d191584ced81e067dc8ba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba s) => ToStructure(s, config);
}
public static RC_6d589cc6382d191584ced81e067dc8ba ToStructure(ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba obj, IBehaviorsConfiguration config) { 
  RC_6d589cc6382d191584ced81e067dc8ba s = new RC_6d589cc6382d191584ced81e067dc8ba();
  if(obj != null) {
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  }
  return s;
}

public static Func<RC_6d589cc6382d191584ced81e067dc8ba, ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6d589cc6382d191584ced81e067dc8ba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba FromStructure(RC_6d589cc6382d191584ced81e067dc8ba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6d589cc6382d191584ced81e067dc8ba(s, config);
}

}


