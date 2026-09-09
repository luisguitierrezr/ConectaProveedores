using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerWeekDay
public class RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord : AbstractRESTStructure<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> {
[JsonProperty("WeekDay")]
public int? AttrWeekDay;

public RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord() { }

public RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWeekDay = (int?) s.ssWeekDay;
  } else {
AttrWeekDay = (int?) s.ssWeekDay;
  }
}

public static EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord obj) { 
  EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord s = new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord();
  if(obj != null) {
  s.ssWeekDay = obj.AttrWeekDay == null ? 0 : obj.AttrWeekDay.Value;
  }
  return s;
}

public static Func<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord FromStructure(EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord(s, config);
}

}


