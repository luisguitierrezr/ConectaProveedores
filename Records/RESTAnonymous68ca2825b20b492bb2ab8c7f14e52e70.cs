using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UpdateIsToCancelFoliosPositionRecord
public class RESTRC_7906bb6b983a6dbe393ae00113e19275 : AbstractRESTStructure<RC_7906bb6b983a6dbe393ae00113e19275> {
[JsonProperty("Update")]
public string AttrUpdate;

[JsonProperty("IsToCancelFolios")]
public bool? AttrIsToCancelFolios;

[JsonProperty("Position")]
public int? AttrPosition;

public RESTRC_7906bb6b983a6dbe393ae00113e19275() { }

public RESTRC_7906bb6b983a6dbe393ae00113e19275 (RC_7906bb6b983a6dbe393ae00113e19275 s, IBehaviorsConfiguration config) {
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

public static RC_7906bb6b983a6dbe393ae00113e19275 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7906bb6b983a6dbe393ae00113e19275 obj) { 
  RC_7906bb6b983a6dbe393ae00113e19275 s = new RC_7906bb6b983a6dbe393ae00113e19275();
  if(obj != null) {
  s.ssUpdate = obj.AttrUpdate == null ? "" : obj.AttrUpdate;
  s.ssIsToCancelFolios = obj.AttrIsToCancelFolios == null ? false : obj.AttrIsToCancelFolios.Value;
  s.ssPosition = obj.AttrPosition == null ? 0 : obj.AttrPosition.Value;
  }
  return s;
}

public static Func<RC_7906bb6b983a6dbe393ae00113e19275, ssConectaProveedores.RestRecords.RESTRC_7906bb6b983a6dbe393ae00113e19275> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7906bb6b983a6dbe393ae00113e19275 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7906bb6b983a6dbe393ae00113e19275 FromStructure(RC_7906bb6b983a6dbe393ae00113e19275 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7906bb6b983a6dbe393ae00113e19275(s, config);
}

}


