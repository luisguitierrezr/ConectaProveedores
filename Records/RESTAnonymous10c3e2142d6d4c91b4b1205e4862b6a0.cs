using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerWeekDayRecord
public class RESTRC_210f541f43ec6384ba59bfd8fe4b8837 : AbstractRESTStructure<RC_210f541f43ec6384ba59bfd8fe4b8837> {
[JsonProperty("DatePickerWeekDay")]
public ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord AttrDatePickerWeekDay;

public RESTRC_210f541f43ec6384ba59bfd8fe4b8837() { }

public RESTRC_210f541f43ec6384ba59bfd8fe4b8837 (RC_210f541f43ec6384ba59bfd8fe4b8837 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerWeekDay = ConvertToRestWithoutDefaults(s.ssENDatePickerWeekDay, new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.FromStructure, config);
  } else {
AttrDatePickerWeekDay = ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.FromStructure(s.ssENDatePickerWeekDay, config);
  }
}

public static RC_210f541f43ec6384ba59bfd8fe4b8837 ToStructure(ssConectaProveedores.RestRecords.RESTRC_210f541f43ec6384ba59bfd8fe4b8837 obj) { 
  RC_210f541f43ec6384ba59bfd8fe4b8837 s = new RC_210f541f43ec6384ba59bfd8fe4b8837();
  if(obj != null) {
  s.ssENDatePickerWeekDay = ssConectaProveedores.RestRecords.RESTEN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord.ToStructure(obj.AttrDatePickerWeekDay);
  }
  return s;
}

public static Func<RC_210f541f43ec6384ba59bfd8fe4b8837, ssConectaProveedores.RestRecords.RESTRC_210f541f43ec6384ba59bfd8fe4b8837> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_210f541f43ec6384ba59bfd8fe4b8837 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_210f541f43ec6384ba59bfd8fe4b8837 FromStructure(RC_210f541f43ec6384ba59bfd8fe4b8837 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_210f541f43ec6384ba59bfd8fe4b8837(s, config);
}

}


