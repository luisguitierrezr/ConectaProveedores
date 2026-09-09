using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DayOfWeekRecord
public class RESTRC_b80982ac17cf476fb15d90ab7992f505 : AbstractRESTStructure<RC_b80982ac17cf476fb15d90ab7992f505> {
[JsonProperty("DayOfWeek")]
public ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord AttrDayOfWeek;

public RESTRC_b80982ac17cf476fb15d90ab7992f505() { }

public RESTRC_b80982ac17cf476fb15d90ab7992f505 (RC_b80982ac17cf476fb15d90ab7992f505 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDayOfWeek = ConvertToRestWithoutDefaults(s.ssENDayOfWeek, new EN_994a40086cd6e8196835f26327ddf330EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord.FromStructure, config);
  } else {
AttrDayOfWeek = ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord.FromStructure(s.ssENDayOfWeek, config);
  }
}

public static RC_b80982ac17cf476fb15d90ab7992f505 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b80982ac17cf476fb15d90ab7992f505 obj) { 
  RC_b80982ac17cf476fb15d90ab7992f505 s = new RC_b80982ac17cf476fb15d90ab7992f505();
  if(obj != null) {
  s.ssENDayOfWeek = ssConectaProveedores.RestRecords.RESTEN_994a40086cd6e8196835f26327ddf330EntityRecord.ToStructure(obj.AttrDayOfWeek);
  }
  return s;
}

public static Func<RC_b80982ac17cf476fb15d90ab7992f505, ssConectaProveedores.RestRecords.RESTRC_b80982ac17cf476fb15d90ab7992f505> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b80982ac17cf476fb15d90ab7992f505 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b80982ac17cf476fb15d90ab7992f505 FromStructure(RC_b80982ac17cf476fb15d90ab7992f505 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b80982ac17cf476fb15d90ab7992f505(s, config);
}

}


