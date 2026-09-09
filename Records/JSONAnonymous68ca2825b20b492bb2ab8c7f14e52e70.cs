using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UpdateIsToCancelFoliosPositionRecord
public class JSONRC_7906bb6b983a6dbe393ae00113e19275 : AbstractRESTStructure<RC_7906bb6b983a6dbe393ae00113e19275> {
[JsonProperty("Update")]
[JsonPropertyName("Update")]
public string AttrUpdate;

[JsonProperty("IsToCancelFolios")]
[JsonPropertyName("IsToCancelFolios")]
public bool? AttrIsToCancelFolios;

[JsonProperty("Position")]
[JsonPropertyName("Position")]
public int? AttrPosition;

public JSONRC_7906bb6b983a6dbe393ae00113e19275() { }

public JSONRC_7906bb6b983a6dbe393ae00113e19275 (RC_7906bb6b983a6dbe393ae00113e19275 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUpdate = ConvertToRestWithoutDefaults(s.ssUpdate, "");
AttrIsToCancelFolios = ConvertToRestWithoutDefaults(s.ssIsToCancelFolios, false);
AttrPosition = ConvertToRestWithoutDefaults(s.ssPosition, 0);
  } else {
AttrUpdate = s.ssUpdate;
AttrIsToCancelFolios = (bool?) s.ssIsToCancelFolios;
AttrPosition = (int?) s.ssPosition;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275, RC_7906bb6b983a6dbe393ae00113e19275> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275 s) => ToStructure(s, config);
}
public static RC_7906bb6b983a6dbe393ae00113e19275 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275 obj, IBehaviorsConfiguration config) { 
  RC_7906bb6b983a6dbe393ae00113e19275 s = new RC_7906bb6b983a6dbe393ae00113e19275();
  if(obj != null) {
  s.ssUpdate = obj.AttrUpdate == null ? "" : obj.AttrUpdate;
  s.ssIsToCancelFolios = obj.AttrIsToCancelFolios == null ? false : obj.AttrIsToCancelFolios.Value;
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  }
  return s;
}

public static Func<RC_7906bb6b983a6dbe393ae00113e19275, ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7906bb6b983a6dbe393ae00113e19275 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275 FromStructure(RC_7906bb6b983a6dbe393ae00113e19275 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7906bb6b983a6dbe393ae00113e19275(s, config);
}

}


