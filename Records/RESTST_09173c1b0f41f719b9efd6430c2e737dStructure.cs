using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// NotificationOptionalConfigs
public class RESTST_09173c1b0f41f719b9efd6430c2e737dStructure : AbstractRESTStructure<ST_09173c1b0f41f719b9efd6430c2e737dStructure> {
[JsonProperty("InteractToClose")]
public bool? AttrInteractToClose;

[JsonProperty("CloseAfterTime")]
public int? AttrCloseAfterTime;

public RESTST_09173c1b0f41f719b9efd6430c2e737dStructure() { }

public RESTST_09173c1b0f41f719b9efd6430c2e737dStructure (ST_09173c1b0f41f719b9efd6430c2e737dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInteractToClose = ConvertToRestWithoutDefaults(s.ssInteractToClose, true);
AttrCloseAfterTime = ConvertToRestWithoutDefaults(s.ssCloseAfterTime, 0);
  } else {
AttrInteractToClose = (bool?) s.ssInteractToClose;
AttrCloseAfterTime = (int?) s.ssCloseAfterTime;
  }
}

public static ST_09173c1b0f41f719b9efd6430c2e737dStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure obj) { 
  ST_09173c1b0f41f719b9efd6430c2e737dStructure s = new ST_09173c1b0f41f719b9efd6430c2e737dStructure();
  if(obj != null) {
  s.ssInteractToClose = obj.AttrInteractToClose == null ? true : obj.AttrInteractToClose.Value;
  s.ssCloseAfterTime = obj.AttrCloseAfterTime == null ? 0 : obj.AttrCloseAfterTime.Value;
  }
  return s;
}

public static Func<ST_09173c1b0f41f719b9efd6430c2e737dStructure, ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_09173c1b0f41f719b9efd6430c2e737dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure FromStructure(ST_09173c1b0f41f719b9efd6430c2e737dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_09173c1b0f41f719b9efd6430c2e737dStructure(s, config);
}

}


