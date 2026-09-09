using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApplicationRole2
public class JSONST_5728db9d26b9364eef512c59f8517473Structure : AbstractRESTStructure<ST_5728db9d26b9364eef512c59f8517473Structure> {
[JsonProperty("Key")]
[JsonPropertyName("Key")]
public string AttrKey;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("StageKey")]
[JsonPropertyName("StageKey")]
public string AttrStageKey;

[JsonProperty("AssetKey")]
[JsonPropertyName("AssetKey")]
public string AttrAssetKey;

[JsonProperty("ExternalKey")]
[JsonPropertyName("ExternalKey")]
public string AttrExternalKey;

[JsonProperty("Claim")]
[JsonPropertyName("Claim")]
public string AttrClaim;

public JSONST_5728db9d26b9364eef512c59f8517473Structure() { }

public JSONST_5728db9d26b9364eef512c59f8517473Structure (ST_5728db9d26b9364eef512c59f8517473Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrStageKey = ConvertToRestWithoutDefaults(s.ssStageKey, "");
AttrAssetKey = ConvertToRestWithoutDefaults(s.ssAssetKey, "");
AttrExternalKey = ConvertToRestWithoutDefaults(s.ssExternalKey, "");
AttrClaim = ConvertToRestWithoutDefaults(s.ssClaim, "");
  } else {
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrStageKey = s.ssStageKey;
AttrAssetKey = s.ssAssetKey;
AttrExternalKey = s.ssExternalKey;
AttrClaim = s.ssClaim;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure, ST_5728db9d26b9364eef512c59f8517473Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure s) => ToStructure(s, config);
}
public static ST_5728db9d26b9364eef512c59f8517473Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure obj, IBehaviorsConfiguration config) { 
  ST_5728db9d26b9364eef512c59f8517473Structure s = new ST_5728db9d26b9364eef512c59f8517473Structure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssStageKey = obj.AttrStageKey == null ? "" : obj.AttrStageKey;
  s.ssAssetKey = obj.AttrAssetKey == null ? "" : obj.AttrAssetKey;
  s.ssExternalKey = obj.AttrExternalKey == null ? "" : obj.AttrExternalKey;
  s.ssClaim = obj.AttrClaim == null ? "" : obj.AttrClaim;
  }
  return s;
}

public static Func<ST_5728db9d26b9364eef512c59f8517473Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5728db9d26b9364eef512c59f8517473Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure FromStructure(ST_5728db9d26b9364eef512c59f8517473Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure(s, config);
}

}


