using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicationRole2
public class RESTST_5728db9d26b9364eef512c59f8517473Structure : AbstractRESTStructure<ST_5728db9d26b9364eef512c59f8517473Structure> {
[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("StageKey")]
public string AttrStageKey;

[JsonProperty("AssetKey")]
public string AttrAssetKey;

[JsonProperty("ExternalKey")]
public string AttrExternalKey;

[JsonProperty("Claim")]
public string AttrClaim;

public RESTST_5728db9d26b9364eef512c59f8517473Structure() { }

public RESTST_5728db9d26b9364eef512c59f8517473Structure (ST_5728db9d26b9364eef512c59f8517473Structure s, IBehaviorsConfiguration config) {
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

public static ST_5728db9d26b9364eef512c59f8517473Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_5728db9d26b9364eef512c59f8517473Structure obj) { 
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

public static Func<ST_5728db9d26b9364eef512c59f8517473Structure, ssConectaProveedores.RestRecords.RESTST_5728db9d26b9364eef512c59f8517473Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5728db9d26b9364eef512c59f8517473Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5728db9d26b9364eef512c59f8517473Structure FromStructure(ST_5728db9d26b9364eef512c59f8517473Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5728db9d26b9364eef512c59f8517473Structure(s, config);
}

}


