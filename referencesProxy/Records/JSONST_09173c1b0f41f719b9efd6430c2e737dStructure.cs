using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// NotificationOptionalConfigs
public class JSONST_09173c1b0f41f719b9efd6430c2e737dStructure : AbstractRESTStructure<ST_09173c1b0f41f719b9efd6430c2e737dStructure> {
[JsonProperty("InteractToClose")]
[JsonPropertyName("InteractToClose")]
public bool? AttrInteractToClose;

[JsonProperty("CloseAfterTime")]
[JsonPropertyName("CloseAfterTime")]
public int? AttrCloseAfterTime;

public JSONST_09173c1b0f41f719b9efd6430c2e737dStructure() { }

public JSONST_09173c1b0f41f719b9efd6430c2e737dStructure (ST_09173c1b0f41f719b9efd6430c2e737dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInteractToClose = ConvertToRestWithoutDefaults(s.ssInteractToClose, true);
AttrCloseAfterTime = ConvertToRestWithoutDefaults(s.ssCloseAfterTime, 0);
  } else {
AttrInteractToClose = (bool?) s.ssInteractToClose;
AttrCloseAfterTime = (int?) s.ssCloseAfterTime;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure, ST_09173c1b0f41f719b9efd6430c2e737dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure s) => ToStructure(s, config);
}
public static ST_09173c1b0f41f719b9efd6430c2e737dStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure obj, IBehaviorsConfiguration config) { 
  ST_09173c1b0f41f719b9efd6430c2e737dStructure s = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
  if(obj != null) {
  s.ssInteractToClose = obj.AttrInteractToClose == null ? true : obj.AttrInteractToClose.Value;
  s.ssCloseAfterTime = obj.AttrCloseAfterTime == null ? 0 : obj.AttrCloseAfterTime.Value;
  }
  return s;
}

public static Func<ST_09173c1b0f41f719b9efd6430c2e737dStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_09173c1b0f41f719b9efd6430c2e737dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure FromStructure(ST_09173c1b0f41f719b9efd6430c2e737dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_09173c1b0f41f719b9efd6430c2e737dStructure(s, config);
}

}


