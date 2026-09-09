using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderResult
public class JSONST_5a17d82af8397abda9cf3915ce9c082fStructure : AbstractRESTStructure<ST_5a17d82af8397abda9cf3915ce9c082fStructure> {
[JsonProperty("OrderNumber")]
[JsonPropertyName("OrderNumber")]
public string AttrOrderNumber;

[JsonProperty("HasSuccess")]
[JsonPropertyName("HasSuccess")]
public bool? AttrHasSuccess;

[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public string AttrErrorMessage;

public JSONST_5a17d82af8397abda9cf3915ce9c082fStructure() { }

public JSONST_5a17d82af8397abda9cf3915ce9c082fStructure (ST_5a17d82af8397abda9cf3915ce9c082fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderNumber = s.ssOrderNumber;
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrOrderNumber = s.ssOrderNumber;
AttrHasSuccess = (bool?) s.ssHasSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure, ST_5a17d82af8397abda9cf3915ce9c082fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure s) => ToStructure(s, config);
}
public static ST_5a17d82af8397abda9cf3915ce9c082fStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure obj, IBehaviorsConfiguration config) { 
  ST_5a17d82af8397abda9cf3915ce9c082fStructure s = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();
  if(obj != null) {
  s.ssOrderNumber = obj.AttrOrderNumber == null ? "" : obj.AttrOrderNumber;
  s.ssHasSuccess = obj.AttrHasSuccess == null ? false : obj.AttrHasSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_5a17d82af8397abda9cf3915ce9c082fStructure, ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5a17d82af8397abda9cf3915ce9c082fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure FromStructure(ST_5a17d82af8397abda9cf3915ce9c082fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_5a17d82af8397abda9cf3915ce9c082fStructure(s, config);
}

}


